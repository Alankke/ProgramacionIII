using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncriptacionCesar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string alfabeto = "aábcdeéfghiíjklmnoópqrstuúüvwxyz";
            Console.WriteLine("Ingrese un texto a encriptar");
            string input = Console.ReadLine();
            Console.WriteLine("Ingrese el desplazamiento");
            int key = Convert.ToInt32(Console.ReadLine());
        }

        public void encriptar(string mensaje, string alfabeto, int key)
        {



        }
    }
}
