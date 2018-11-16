namespace RegistroRunning
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dp_horaLlegada = new System.Windows.Forms.DateTimePicker();
            this.dp_horaPartida = new System.Windows.Forms.DateTimePicker();
            this.cb_corrida = new System.Windows.Forms.ComboBox();
            this.tb_numero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_registro = new System.Windows.Forms.DataGridView();
            this.NumeroCorredor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corrida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaPartida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaLlegada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbl_mensaje = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgv_resultados = new System.Windows.Forms.DataGridView();
            this.corridaRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lugarRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoRes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.btn_resetear = new System.Windows.Forms.Button();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox1.Controls.Add(this.dp_horaLlegada);
            this.groupBox1.Controls.Add(this.dp_horaPartida);
            this.groupBox1.Controls.Add(this.cb_corrida);
            this.groupBox1.Controls.Add(this.tb_numero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(20, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(697, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Datos del registros del corredor ]";
            // 
            // dp_horaLlegada
            // 
            this.dp_horaLlegada.CustomFormat = "HH:mm";
            this.dp_horaLlegada.Location = new System.Drawing.Point(535, 67);
            this.dp_horaLlegada.Name = "dp_horaLlegada";
            this.dp_horaLlegada.Size = new System.Drawing.Size(145, 26);
            this.dp_horaLlegada.TabIndex = 7;
            this.dp_horaLlegada.Value = new System.DateTime(2018, 11, 15, 10, 41, 0, 0);
            // 
            // dp_horaPartida
            // 
            this.dp_horaPartida.CustomFormat = "HH:mm";
            this.dp_horaPartida.Location = new System.Drawing.Point(350, 67);
            this.dp_horaPartida.Name = "dp_horaPartida";
            this.dp_horaPartida.Size = new System.Drawing.Size(145, 26);
            this.dp_horaPartida.TabIndex = 6;
            this.dp_horaPartida.Value = new System.DateTime(2018, 11, 15, 10, 54, 0, 0);
            // 
            // cb_corrida
            // 
            this.cb_corrida.FormattingEnabled = true;
            this.cb_corrida.Items.AddRange(new object[] {
            "",
            "5",
            "10",
            "20",
            "40"});
            this.cb_corrida.Location = new System.Drawing.Point(188, 67);
            this.cb_corrida.Name = "cb_corrida";
            this.cb_corrida.Size = new System.Drawing.Size(129, 28);
            this.cb_corrida.TabIndex = 5;
            // 
            // tb_numero
            // 
            this.tb_numero.Location = new System.Drawing.Point(19, 67);
            this.tb_numero.Name = "tb_numero";
            this.tb_numero.Size = new System.Drawing.Size(129, 26);
            this.tb_numero.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hora Llegada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(347, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora Partida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Corrida (km)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(20, 170);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(202, 50);
            this.btn_agregar.TabIndex = 1;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(267, 170);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(202, 50);
            this.btn_actualizar.TabIndex = 2;
            this.btn_actualizar.Text = "Actualizar";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(514, 170);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(202, 50);
            this.btn_eliminar.TabIndex = 3;
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox2.Controls.Add(this.dgv_registro);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox2.Location = new System.Drawing.Point(20, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(702, 274);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Registro Corrida ]";
            // 
            // dgv_registro
            // 
            this.dgv_registro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_registro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NumeroCorredor,
            this.corrida,
            this.horaPartida,
            this.horaLlegada,
            this.tiempo});
            this.dgv_registro.Location = new System.Drawing.Point(19, 35);
            this.dgv_registro.Name = "dgv_registro";
            this.dgv_registro.Size = new System.Drawing.Size(661, 217);
            this.dgv_registro.TabIndex = 0;
            this.dgv_registro.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registro_CellClick);
            this.dgv_registro.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_registro_CellContentClick);
            // 
            // NumeroCorredor
            // 
            this.NumeroCorredor.HeaderText = "Número Corredor";
            this.NumeroCorredor.Name = "NumeroCorredor";
            // 
            // corrida
            // 
            this.corrida.HeaderText = "Corrida";
            this.corrida.Name = "corrida";
            // 
            // horaPartida
            // 
            this.horaPartida.HeaderText = "Hora Partida";
            this.horaPartida.Name = "horaPartida";
            // 
            // horaLlegada
            // 
            this.horaLlegada.HeaderText = "Hora Llegada";
            this.horaLlegada.Name = "horaLlegada";
            // 
            // tiempo
            // 
            this.tiempo.HeaderText = "Tiempo";
            this.tiempo.Name = "tiempo";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox3.Controls.Add(this.lbl_mensaje);
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(20, 533);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(703, 88);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[ Mensajes ]";
            // 
            // lbl_mensaje
            // 
            this.lbl_mensaje.AutoSize = true;
            this.lbl_mensaje.Location = new System.Drawing.Point(15, 46);
            this.lbl_mensaje.Name = "lbl_mensaje";
            this.lbl_mensaje.Size = new System.Drawing.Size(76, 20);
            this.lbl_mensaje.TabIndex = 0;
            this.lbl_mensaje.Text = "Mensaje";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Cornsilk;
            this.groupBox4.Controls.Add(this.dgv_resultados);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.groupBox4.Location = new System.Drawing.Point(737, 25);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(575, 502);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "[ Resultados Running ]";
            // 
            // dgv_resultados
            // 
            this.dgv_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_resultados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corridaRes,
            this.numeroRes,
            this.lugarRes,
            this.tiempoRes});
            this.dgv_resultados.Location = new System.Drawing.Point(13, 39);
            this.dgv_resultados.Name = "dgv_resultados";
            this.dgv_resultados.RowHeadersWidth = 60;
            this.dgv_resultados.Size = new System.Drawing.Size(550, 440);
            this.dgv_resultados.TabIndex = 1;
            // 
            // corridaRes
            // 
            this.corridaRes.HeaderText = "Corrida";
            this.corridaRes.Name = "corridaRes";
            // 
            // numeroRes
            // 
            this.numeroRes.HeaderText = "Número";
            this.numeroRes.Name = "numeroRes";
            // 
            // lugarRes
            // 
            this.lugarRes.HeaderText = "Lugar";
            this.lugarRes.Name = "lugarRes";
            // 
            // tiempoRes
            // 
            this.tiempoRes.HeaderText = "Tiempo";
            this.tiempoRes.Name = "tiempoRes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 20);
            this.label5.TabIndex = 0;
            // 
            // btn_consultar
            // 
            this.btn_consultar.Location = new System.Drawing.Point(737, 549);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(167, 50);
            this.btn_consultar.TabIndex = 7;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            // 
            // btn_resetear
            // 
            this.btn_resetear.Location = new System.Drawing.Point(941, 549);
            this.btn_resetear.Name = "btn_resetear";
            this.btn_resetear.Size = new System.Drawing.Size(167, 50);
            this.btn_resetear.TabIndex = 8;
            this.btn_resetear.Text = "Resetear";
            this.btn_resetear.UseVisualStyleBackColor = true;
            this.btn_resetear.Click += new System.EventHandler(this.btn_resetear_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Location = new System.Drawing.Point(1145, 549);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(167, 50);
            this.btn_cerrar.TabIndex = 9;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1324, 639);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_resetear);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_actualizar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Consulta Estadistica de Running";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_registro)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_resultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dp_horaPartida;
        private System.Windows.Forms.ComboBox cb_corrida;
        private System.Windows.Forms.TextBox tb_numero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dp_horaLlegada;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_registro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroCorredor;
        private System.Windows.Forms.DataGridViewTextBoxColumn corrida;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaPartida;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaLlegada;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbl_mensaje;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_resultados;
        private System.Windows.Forms.DataGridViewTextBoxColumn corridaRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn lugarRes;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoRes;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button btn_resetear;
        private System.Windows.Forms.Button btn_cerrar;
    }
}

