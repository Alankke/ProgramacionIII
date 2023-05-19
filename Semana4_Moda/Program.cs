using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Moda_Prog3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de numeros para calcular la moda");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());
            int[] numeros = new int[cantidadNumeros];

            //Pedir al usuario que cargue el vector
            for (int i = 0;  i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            calcularModa(numeros);
            Console.WriteLine("Apriete una tecla para salir");
            Console.ReadKey();

        }
        public static void calcularModa(int[] numeros )
        {

            int numeroMaximo = numeros[0];
            int maximoVeces = 0;
            int x = 0;
            //Dos while anidados para recorrer y evaluar el numero que mas aparece
            while (x < numeros.Length)
            {
                int cantidadVeces = 0;
                int j = 0;
                while (j < numeros.Length)
                {
                    if (numeros[j] == numeros[x]) cantidadVeces++;
                    j++;
                }
                if (cantidadVeces > maximoVeces)
                {
                    numeroMaximo = numeros[x];
                    maximoVeces = cantidadVeces;
                }
                x++;
                
            }
            
            Console.WriteLine($"La moda de los numeros proporcionados es {numeroMaximo} que aparece {maximoVeces} veces");
            Console.WriteLine($"El mayor número es {numeros.Max()} y el menor número es {numeros.Min()}");
        }
                
    }
}
