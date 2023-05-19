using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion_13_04
{
    internal class Dado
    {
        public static Random rnd = new Random();
        //Metodo para arrojar el dado, en este caso como son dos dados es en un rango entre 2 y 12
        public int arrojar()
        {
            lock (rnd)
            {
                return rnd.Next(2, 13);
            }
        }
    }
}
