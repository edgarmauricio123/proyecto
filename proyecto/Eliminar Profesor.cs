using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace proyecto
{
    public partial class Eliminar_Profesor : Form
    {

        public Eliminar_Profesor()
        {
            InitializeComponent();
        }
        static string conexion = "SERVER=localhost;PORT=3307; DATABASE=entradas_tecnologico; UID=root;PASSWORD=;";
        MySqlConnection cn = new MySqlConnection(conexion);
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Iniciar un hilo para simular el proceso de guardar
            Thread guardarThread = new Thread(Guardar);//Aca crea un nuevo hilo que lo va inicializar
                                                       //en el metdo guardar
            guardarThread.Start();//Esta linea de codigo hace referencia al inicio del hilo
        }
        private void Guardar()//Aca especifica el nombre del metodo que simulara el proceso de guardar
        {

            for (int i = 0; i <= 100; i++)// Simular un proceso de guardado
            {

                Invoke((MethodInvoker)delegate {// Actualizara la barra de progreso desde el hilo secundario
                    progressBar1.Value = i;
                });


                Thread.Sleep(50);// Simular espera es decir sera el tiempo en que estara activa la barra 
            }


            MessageBox.Show("¡Guardado completado!");// Este es un mensaje que se mostrara al finalizar el
                                                     //proceso la barra de progreso
        }


        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
