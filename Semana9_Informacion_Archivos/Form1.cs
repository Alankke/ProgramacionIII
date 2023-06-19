using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana9_Informacion_Archivos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            folderBrowserDialog1.ShowDialog();
            label1.Text = folderBrowserDialog1.SelectedPath;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string enter = Environment.NewLine;
            DirectoryInfo carpeta_elegida = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
            FileSystemInfo[] archivos = carpeta_elegida.GetFileSystemInfos();

            foreach (FileInfo archivo in archivos)
            {

                textBox1.AppendText($"{enter}Nombre: {archivo.Name} {enter}Tamaño: {archivo.Length} {enter}Tamaño total: {archivo.Length / 1024} Kb {enter}---------------------------------------------------------");
            }
        }
    }
}
