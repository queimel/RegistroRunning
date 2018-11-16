using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegistroRunning.Modelo;

namespace RegistroRunning.Controlador
{
    class ControladorRegistroCorrida
    {
        List<RegistroCorrida> listaRegistros = new List<RegistroCorrida>();

        public int existeRegistro(int idCorredor)
        {
            try
            {
                foreach (RegistroCorrida e in listaRegistros)
                {
                    if (e.numeroCorredor == idCorredor)
                    {
                        return 1; // Existe el corredor en la lista registros
                    }
                }
                return 0; // No existe corredor en el registro
            }
            catch (Exception e)
            {
                return -1; // Error
            }
        }

        public int agregarRegistro( int idCorredor, int categoria, DateTime horaPartida, DateTime horaLlegada)
        {
            try
            {
                RegistroCorrida registro = new RegistroCorrida(idCorredor, categoria, horaPartida, horaLlegada);
                listaRegistros.Add(registro);
                return 1; // Se agrego correctamente
            }
            catch (Exception e)
            {
                return -1; // Error
            }
        }

        public int eliminarRegistro (int idCorredor)
        {
            try
            {
                foreach (RegistroCorrida e in listaRegistros)
                {
                    if (e.numeroCorredor == idCorredor)
                    {
                        listaRegistros.Remove(e);
                        return 1; // Se elimino correctamente
                    }
                }
                return 0;
            }
            catch (Exception e)
            {
                return -1; // Error
            }
        }

        public RegistroCorrida buscarRegistro(int idCorredor)
        {
            RegistroCorrida resultado = listaRegistros.Find(x => x.numeroCorredor == idCorredor);
            return resultado;
        }

        public int actualizarRegistro(int idCorredor, int categoria, DateTime horaPartida, DateTime horaLlegada)
        {
            try
            {
                foreach (RegistroCorrida e in listaRegistros)
                {
                    if (e.numeroCorredor == idCorredor)
                    {
                        e.categoria = categoria;
                        e.horaPartida = horaPartida;
                        e.horaLlegada = horaLlegada;

                        return 1; // Se Actualizo correctamente
                    }
                }
                return 0;
            }
            catch (Exception e)
            {
                return -1; // Error
            }
        }
    }
}
