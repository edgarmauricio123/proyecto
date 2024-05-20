using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto
{
    public partial class Lista_completa_Profesores : Form
    {
        public Lista_completa_Profesores()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proyecto.Profesores mostrar = new proyecto.Profesores();
            mostrar.ShowDialog();
        }

        private void INICIO_Click(object sender, EventArgs e)
        {

        }
    }
}
