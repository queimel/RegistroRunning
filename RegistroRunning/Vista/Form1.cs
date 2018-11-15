using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroRunning
{
    public partial class Form1 : Form
    {
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
