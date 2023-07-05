using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PracticaParcial2
{
    public partial class VentanaPrincipal : Form
    {

        public string NombreJugador { get; set; }
        List<int> numerosSorteados = new List<int>();
        List<int> numerosCarton;
        private Button[,] botones;

        public VentanaPrincipal()
        {
            InitializeComponent();
            GenerarCarton();
            botones = new Button[4, 4]
            {
                { button1, button2, button3, button4},
                { button5, button6, button7, button8 },
                { button9, button10, button11, button12 },
                { button13, button14, button15, button16 }
            };
        }

        private void GenerarButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int numeroGenerado = random.Next(1, 75);

            if (!numerosSorteados.Contains(numeroGenerado))
            {
                numerosSorteados.Add(numeroGenerado);
            }
            var ultimo = numerosSorteados.Last();
            MostrarNumeroLabel.Text = ultimo.ToString();
            MostrarNumerosGeneradosLabel.Text = "";
            for (int i = 0; i < numerosSorteados.Count; i++)
            {
                MostrarNumerosGeneradosLabel.Text += numerosSorteados[i].ToString() + " ";
            }

        }

        private void GenerarCarton()
        {
            List<int> numeros = GenerarNumerosAleatorios(1, 75);

            int index = 0;
            foreach (Button button in CartonTableLayoutPanel.Controls)
            {
                button.Text = numeros[index].ToString();
                index++;

            }
        }

        public List<int> GenerarNumerosAleatorios(int min, int max)
        {
            numerosCarton = new List<int>();

            for (int i = min; i <= max; i++)
            {
                numerosCarton.Add(i);
            }

            Random random = new Random();

            int n = numerosCarton.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = numerosCarton[k];
                numerosCarton[k] = numerosCarton[n];
                numerosCarton[n] = value;
            }

            return numerosCarton;
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            boton.BackColor = Color.Green;
            VerificarColumna();
            VerificarFila();
            VerificarDiagonales();

        }

        private void VerificarFila()
        {
            for (int columna = 0; columna < 4; columna++)
            {
                bool columnaCompleta = true;
                for (int fila = 0; fila < 4; fila++)
                {
                    if (botones[columna, fila].BackColor != Color.Green)
                    {
                        columnaCompleta = false;
                        break;
                    }
                }

                if (columnaCompleta)
                {
                    // Deshabilitar todos los botones
                    DeshabilitarBotones();
                    return;
                }
            }
        }

        private void VerificarColumna()
        {
            for (int columna = 0; columna < 4; columna++)
            {
                bool columnaCompleta = true;
                for (int fila = 0; fila < CartonTableLayoutPanel.RowCount; fila++)
                {
                    Control control = CartonTableLayoutPanel.GetControlFromPosition(columna, fila);
                    if (control.BackColor != Color.Green)
                    {
                        columnaCompleta = false;
                        break;
                    }
                }

                if (columnaCompleta)
                {
                    DeshabilitarBotones();
                    return;
                }
            }
        }

        private void VerificarDiagonales()
        {
            bool diagonalCompleta1 = true;
            for (int i = 0; i < 4; i++)
            {
                Control boton = CartonTableLayoutPanel.GetControlFromPosition(i, i);
                if (boton.BackColor != Color.Green)
                {
                    diagonalCompleta1 = false;
                }
            }

            if (diagonalCompleta1)
            {
                DeshabilitarBotones();
                return;
            }


            bool diagonalCompleta2 = true;
            for (int i = 0; i < CartonTableLayoutPanel.RowCount; i++)
            {
                Control control = CartonTableLayoutPanel.GetControlFromPosition(i, CartonTableLayoutPanel.RowCount - 1 - i);
                if (control.BackColor != Color.Green)
                {
                    diagonalCompleta2 = false;
                    break;
                }
            }
            if (diagonalCompleta2)
            {
                DeshabilitarBotones();
                return;
            }


        }

        private void DeshabilitarBotones()
        {
            foreach (Button boton in CartonTableLayoutPanel.Controls)
            {
                boton.Enabled = false;
                GenerarButton.Enabled = false;
                labelTexto.Text = $"Felicidades {NombreJugador}!  Has ganado";

            }
        }

        private void buttonJugarDeNuevo_Click(object sender, EventArgs e)
        {
            foreach (Control control in CartonTableLayoutPanel.Controls)
            {
                if (control is Button button)
                {
                    button.Enabled = true;
                    button.BackColor = DefaultBackColor;
                    GenerarButton.Enabled = true;
                    labelTexto.Visible = false;
                    MostrarNumerosGeneradosLabel.Text = "";
                    numerosSorteados.Clear();
                    MostrarNumeroLabel.Text = "0";
                    GenerarCarton();
                }
            }

        }

        private void buttonGuardarPartida_Click(object sender, EventArgs e)
        {

            FileInfo fi = new FileInfo(@"partida_guardada.txt");
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Write);
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine($"Fecha de la partida: {DateTime.Now}");
                sw.WriteLine($"Jugador: {NombreJugador}");
                sw.WriteLine($"Numeros del Carton: ");
                foreach (Button boton in CartonTableLayoutPanel.Controls)
                {
                    sw.Write(boton.Text + " ");
                }

                sw.WriteLine();
                sw.WriteLine("Numeros Sorteados: ");
                foreach (int numeroSorteado in numerosSorteados)
                {
                    sw.Write(numeroSorteado + " ");
                }
                sw.WriteLine();
                MessageBox.Show("El archivo se creó correctamente");
            }
            fs.Close();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            labelTexto.Text = "Bienvenido! " + NombreJugador;

        }

    }
}
