﻿using System;
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
    public partial class Profesores : Form
    {
        public Profesores()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            proyecto.Modificar_Profesor_Existente mostrar = new proyecto.Modificar_Profesor_Existente();
            mostrar.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            proyecto.Ingresar_Nuevo_Profesor mostrar = new proyecto.Ingresar_Nuevo_Profesor();
            mostrar.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            proyecto.Eliminar_Profesor mostrar = new proyecto.Eliminar_Profesor();
            mostrar.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            proyecto.Lista_completa_Profesores mostrar = new proyecto.Lista_completa_Profesores();
            mostrar.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            proyecto.Form1 mostrar = new proyecto.Form1();
            mostrar.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
