using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace JuegoSimon3
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<int> secuenciaColores = new List<int>();
        bool hablando = false;
        int puntaje = 0;
        int indice = 0;

        public Form1()
        {
            InitializeComponent();
            nuevoJuego();
        }
        
        public void nuevoJuego()
        {
            Thread.Sleep(1000);
            hablando = true;
            foreach (int activa in secuenciaColores)
            {
                switch (activa)
                {
                    case 0:
                        button_0.BackColor = Color.Blue;
                        Thread.Sleep(500);
                        button_0.BackColor = Color.MidnightBlue;
                        break;
                    case 1:
                        button_1.BackColor = Color.Yellow;
                        Thread.Sleep(500);
                        button_1.BackColor = Color.Olive;
                        break;
                    case 2:
                        button_2.BackColor = Color.Red;
                        Thread.Sleep(500);
                        button_2.BackColor = Color.DarkRed;
                        break;
                    case 3:
                        button_3.BackColor = Color.Lime;
                        Thread.Sleep(500);
                        button_3.BackColor = Color.Green;
                        break;
                }
                Thread.Sleep(500);
            }
            hablando = false;
            
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            //Extrae el nombre del boton presionado.
            String botonPresionado = ((Button)sender).Name;
            //Lo guarda al numero cortando a partir del _ desde el nombre del boton.
            string[] numeroBoton = botonPresionado.Split('_');
            checkear(Convert.ToInt32(numeroBoton[1]));
        }

        private void checkear(int valorIngresado)
        {
            if (hablando || secuenciaColores.Count == 0) return;
            if (secuenciaColores[indice] == valorIngresado) indice++;
            else
            {
                MessageBox.Show("Has perdido! Tu puntaje final ha sido " + (secuenciaColores.Count -1));
                indice = 0;
                secuenciaColores = new List<int>();
                hablando = false;

            }
            if (indice >= secuenciaColores.Count)
            {

                indice = 0;
                secuenciaColores.Add(random.Next(0, 4));
                new Thread(nuevoJuego).Start();
            }
            label_Puntaje_Nro.Text = (secuenciaColores.Count -1).ToString();
        }

        private void button_jugar_Click(object sender, EventArgs e)
        {
            label_Puntaje_Nro.Text = "0";
            incrementarSecuencia();
        }

        private void incrementarSecuencia()
        {
            secuenciaColores.Add(random.Next(0, 4));
            new Thread(nuevoJuego).Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button_0_MouseDown(object sender, MouseEventArgs e)
        {
            button_0.BackColor = Color.Blue;
        }

        private void button_0_MouseUp(object sender, MouseEventArgs e)
        {
            button_0.BackColor = Color.MidnightBlue;
        }
        private void button_1_MouseDown(object sender, MouseEventArgs e)
        {
            button_1.BackColor = Color.Yellow;
        }

        private void button_1_MouseUp(object sender, MouseEventArgs e)
        {
            button_1.BackColor = Color.Olive;
        }
        private void button_2_MouseDown(object sender, MouseEventArgs e)
        {
            button_2.BackColor = Color.Red;
        }

        private void button_2_MouseUp(object sender, MouseEventArgs e)
        {
            button_2.BackColor = Color.DarkRed;
        }
        private void button_3_MouseDown(object sender, MouseEventArgs e)
        {
            button_3.BackColor = Color.Lime;
        }

        private void button_3_MouseUp(object sender, MouseEventArgs e)
        {
            button_3.BackColor = Color.Green;
        }
    }
}
