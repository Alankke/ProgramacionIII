using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca___11_05_2023
{
    internal class Libro : IComparable<Libro>, IColeccionable

    {
        public string autor;
        private string titulo;

        public string Autor
        {
            get
            {
                return autor;
            }
            set
            {
                autor = value;
            }
        }
        public string Titulo
        {
            get
            {
                return titulo;
            }
            set
            {
                titulo = value;
            }
        }

        public Libro(string Autor, string Titulo)
        {
            this.Autor = Autor;
            this.Titulo = Titulo;
        }
        public void Describir()
        {
            Console.WriteLine($"{titulo} de {autor}");
        }
        public int CompareTo(Libro other)
        {
            return Titulo.CompareTo(other.Titulo);
        }
    }

}
