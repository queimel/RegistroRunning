using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RegistroRunning.Controlador;


namespace RegistroRunning
{
    public partial class Form1 : Form
    {
        ControladorRegistroCorrida ocrc = new ControladorRegistroCorrida();
        DataGridViewRow FilaSeleccionada;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dp_horaPartida.Format = DateTimePickerFormat.Custom;
            dp_horaPartida.CustomFormat = "HH:mm:ss";
            dp_horaPartida.ShowUpDown = true;

            dp_horaLlegada.Format = DateTimePickerFormat.Custom;
            dp_horaLlegada.CustomFormat = "HH:mm:ss";
            dp_horaLlegada.ShowUpDown = true;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_resetear_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";
            tb_numero.Text = "";
            cb_corrida.SelectedIndex = 0;
            dp_horaPartida.Text = "";
            dp_horaLlegada.Text = "";
            dgv_registro.Rows.Clear();
            dgv_resultados.Rows.Clear();
            tb_numero.Focus();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";
            if ("".Equals(tb_numero.Text))
            {
                lbl_mensaje.Text = "Debe ingresar un número de corredor...";
                tb_numero.Focus();
            }
            else
            {
                int idCorredor;
                if (int.TryParse(tb_numero.Text, out idCorredor))
                {
                    if (idCorredor > 0)
                    {
                        if (cb_corrida.SelectedIndex > 0)
                        {
                            int corrida = int.Parse(cb_corrida.SelectedItem.ToString());

                            if ("".Equals(dp_horaPartida.Text))
                            {
                                lbl_mensaje.Text = "Debe ingresar una hora de partida";
                                dp_horaPartida.Focus();
                            }
                            else
                            {
                                DateTime horaPartida = dp_horaPartida.Value;
                                if ("".Equals(dp_horaLlegada.Text))
                                {
                                    lbl_mensaje.Text = "Debe ingresar una hora de llegada";
                                    dp_horaLlegada.Focus();
                                }
                                else
                                {
                                    DateTime horaLlegada = dp_horaLlegada.Value;
                                    // Validación Básica OK
                                    int sw = ocrc.existeRegistro(idCorredor);
                                    switch (sw)
                                    {
                                        case 0: // No existe, entoces se agrega

                                            if (ocrc.agregarRegistro(idCorredor, corrida, horaPartida, horaLlegada) == 1)
                                            {
                                                lbl_mensaje.Text = "Registro Agregado";
                                                tb_numero.Text = "";
                                                cb_corrida.SelectedIndex = 0;
                                                dp_horaPartida.Text = "";
                                                dp_horaLlegada.Text = "";
                                                tb_numero.Focus();
                                                TimeSpan tiempo = (horaLlegada - horaPartida);
                                                dgv_registro.Rows.Add(idCorredor, $"{corrida}K", horaPartida.ToString("HH:mm:ss"), horaLlegada.ToString("HH:mm:ss"), tiempo.ToString(@"hh\:mm\:ss"));
                                            }
                                            else
                                            {
                                                lbl_mensaje.Text = "Agregue nuevamente ...";
                                                tb_numero.Focus();
                                            }
                                            break;
                                        case 1: // Ya existe
                                            lbl_mensaje.Text = "Registro existente";
                                            tb_numero.Focus();
                                            break;
                                        default: // Error
                                            lbl_mensaje.Text = "Agregue nuevamente ...";
                                            tb_numero.Focus();
                                            break;
                                    }
                                    //
                                }
                            }
                        }
                        else
                        {
                            lbl_mensaje.Text = "Debe Seleccionar una corrida";
                            cb_corrida.Focus();
                        }
                    }
                    else
                    {
                        lbl_mensaje.Text = "Debe ingresar un número de corredor mayor a 0";
                        tb_numero.Focus();
                    }
                }
                else
                {
                    lbl_mensaje.Text = "Debe ingresar un número de corredor númerico";
                    tb_numero.Focus();
                }
            }



        }

        // click en tabla para eliminar / actualizar
        private void dgv_registro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_registro_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                FilaSeleccionada = this.dgv_registro.Rows[e.RowIndex];
                int numeroRegistro = int.Parse(FilaSeleccionada.Cells["NumeroCorredor"].Value.ToString());

                var registro = ocrc.buscarRegistro(numeroRegistro);

                tb_numero.Text = registro.numeroCorredor.ToString();

                int categoria = 0;

                if (registro.categoria == 5)
                {
                    categoria = 1;
                }
                else if (registro.categoria == 10)
                {
                    categoria = 2;
                }
                else if (registro.categoria == 20)
                {
                    categoria = 3;
                }
                else if (registro.categoria == 40)
                {
                    categoria = 4;
                }
                cb_corrida.SelectedIndex = categoria;
                dp_horaPartida.Value = registro.horaPartida;
                dp_horaLlegada.Value = registro.horaLlegada;


            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {

            lbl_mensaje.Text = "";
            if ("".Equals(tb_numero.Text))
            {
                lbl_mensaje.Text = "Debe Seleccionar un registro...";
                tb_numero.Focus();
            }
            else
            {
                int idCorredor;
                if (int.TryParse(tb_numero.Text, out idCorredor))
                {
                    if (idCorredor > 0)
                    {
                        int sw = ocrc.existeRegistro(idCorredor);
                        switch (sw)
                        {
                            case 0: // No existe, no se puede eliminar
                                lbl_mensaje.Text = "Registro No Existe";
                                tb_numero.Focus();
                                break;
                            case 1: // Ya existe


                                    if (ocrc.eliminarRegistro(idCorredor) == 1)
                                    {
                                        lbl_mensaje.Text = "Registro eliminado exitosamente";
                                        tb_numero.Text = "";
                                        cb_corrida.SelectedIndex = 0;
                                        dp_horaPartida.Text = "";
                                        dp_horaLlegada.Text = "";
                                        tb_numero.Focus();

                                        dgv_registro.Rows.Remove(FilaSeleccionada);
                                    }
                                    else
                                    {
                                        lbl_mensaje.Text = "Ocurrio un error al eliminar";
                                        tb_numero.Focus();
                                    }
                           
                                
                                break;
                            default: // Error
                                lbl_mensaje.Text = "Intente nuevamente ...";
                                tb_numero.Focus();
                                break;
                        }
                        //
                    }
                    else
                    {
                        lbl_mensaje.Text = "Debe ingresar un número de corredor mayor a 0";
                        tb_numero.Focus();
                    }
                }
                else
                {
                    lbl_mensaje.Text = "Debe ingresar un número de corredor númerico";
                    tb_numero.Focus();
                }
            }
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            lbl_mensaje.Text = "";
            if ("".Equals(tb_numero.Text))
            {
                lbl_mensaje.Text = "Debe ingresar un número de corredor...";
                tb_numero.Focus();
            }
            else
            {
                int idCorredor;
                if (int.TryParse(tb_numero.Text, out idCorredor))
                {
                    if (idCorredor > 0)
                    {
                        if (cb_corrida.SelectedIndex > 0)
                        {
                            int corrida = int.Parse(cb_corrida.SelectedItem.ToString());

                            if ("".Equals(dp_horaPartida.Text))
                            {
                                lbl_mensaje.Text = "Debe ingresar una hora de partida";
                                dp_horaPartida.Focus();
                            }
                            else
                            {
                                DateTime horaPartida = dp_horaPartida.Value;
                                if ("".Equals(dp_horaLlegada.Text))
                                {
                                    lbl_mensaje.Text = "Debe ingresar una hora de llegada";
                                    dp_horaLlegada.Focus();
                                }
                                else
                                {
                                    DateTime horaLlegada = dp_horaLlegada.Value;
                                    // Validación Básica OK
                                    int sw = ocrc.existeRegistro(idCorredor);
                                    switch (sw)
                                    {
                                        case 0: // No existe, entoces se agrega

                                            lbl_mensaje.Text = "Registro existente";
                                            tb_numero.Focus();
                                            break;
                                        case 1: // Ya existe

                                            if (ocrc.actualizarRegistro(idCorredor, corrida, horaPartida, horaLlegada) == 1)
                                            {
                                                lbl_mensaje.Text = "Registro Actualizado";
                                                tb_numero.Text = "";
                                                cb_corrida.SelectedIndex = 0;
                                                dp_horaPartida.Text = "";
                                                dp_horaLlegada.Text = "";
                                                tb_numero.Focus();
                                                TimeSpan tiempo = (horaLlegada - horaPartida);
                                                int fila = FilaSeleccionada.Index;

                                                FilaSeleccionada.SetValues(idCorredor, $"{corrida}K", horaPartida.ToString("HH:mm:ss"), horaLlegada.ToString("HH:mm:ss"), tiempo.ToString(@"hh\:mm\:ss"));
                                            }
                                            else
                                            {
                                                lbl_mensaje.Text = "Intente nuevamente ...";
                                                tb_numero.Focus();
                                            }
                                            break;
                                        default: // Error
                                            lbl_mensaje.Text = "Intente nuevamente ...";
                                            tb_numero.Focus();
                                            break;
                                    }
                                    //
                                }
                            }
                        }
                        else
                        {
                            lbl_mensaje.Text = "Debe Seleccionar una corrida";
                            cb_corrida.Focus();
                        }
                    }
                    else
                    {
                        lbl_mensaje.Text = "Debe ingresar un número de corredor mayor a 0";
                        tb_numero.Focus();
                    }
                }
                else
                {
                    lbl_mensaje.Text = "Debe ingresar un número de corredor númerico";
                    tb_numero.Focus();
                }
            }
        }
    }
}
