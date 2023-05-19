using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca___11_05_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Libro libro1 = new Libro("Pepito", "A");
            Libro libro2 = new Libro("Jose", "B");
            Libro libro3 = new Libro("Juan", "ABC");
            Libro libro4 = new Libro("Pedro", "C");
            Libro libro5 = new Libro("Monica", "D");
            Libro libro6 = new Libro("Agostina", "CBB");
            Libro[] biblioteca = { libro1, libro2, libro3, libro4, libro5, libro6, };
            Array.Sort(biblioteca);
            foreach(Libro libro in biblioteca)
            {
                libro.Describir();
            }
            Console.ReadLine();
        }
    }
}
