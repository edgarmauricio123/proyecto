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
    public partial class Estudiantes : Form
    {
        public Estudiantes()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            // para centrar el frame
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height)/2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width)/2;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void INICIO_Click(object sender, EventArgs e)
        {
            proyecto.Form1 mostrar = new proyecto.Form1();
            mostrar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            proyecto.Ingresar_NUEVO mostrar = new proyecto.Ingresar_NUEVO();
            mostrar.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proyecto.Modificar_Alumno mostrar = new proyecto.Modificar_Alumno();
            mostrar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proyecto.Eliminar_Existente mostrar = new proyecto.Eliminar_Existente();
            mostrar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            proyecto.Lista_completa mostrar = new proyecto.Lista_completa();
            mostrar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            proyecto.Form1 mostrar = new proyecto.Form1();
            mostrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            proyecto.Estudiantes mostrar = new proyecto.Estudiantes();
            mostrar.ShowDialog(this);
        }

        private void PROFESORES_Click(object sender, EventArgs e)
        {
            proyecto.Profesores mostrar = new proyecto.Profesores();
            mostrar.ShowDialog();
        }
    }
}
