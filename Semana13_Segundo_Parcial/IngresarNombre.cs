using System;
using System.Windows.Forms;

namespace PracticaParcial2
{
    public partial class IngresarNombre : Form
    {
        public string Nombre { get; set; }
        public IngresarNombre()
        {
            InitializeComponent();
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            NombreTextBox.Text = string.Empty;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Nombre = NombreTextBox.Text;
            VentanaPrincipal ventanaPrincipal = new VentanaPrincipal();
            ventanaPrincipal.NombreJugador = Nombre;
            ventanaPrincipal.ShowDialog();
        }
    }
}
