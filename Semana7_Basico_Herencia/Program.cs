using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//FALTA CALCULO DE INTERESES NEGATIVOS, SI EL SALDO ES NEGATIVO ENTONCES COBRAR POR EJEMPLO 5,25 DE INTERES
namespace EjercicioCuentasProg3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Random monto = new Random();

            Console.WriteLine("Ingrese el nombre del dueño de la Caja de Ahorro ");
            string dueño = Console.ReadLine();

            Console.WriteLine($"Ingrese Saldo de: {dueño}");
            int saldo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ingrese Cbu de: {dueño}");
            int cbu = Convert.ToInt32(Console.ReadLine());

            CajaDeAhorro cajaahorro1 = new CajaDeAhorro(dueño, saldo, cbu);

            Console.WriteLine("Ingrese el nombre del dueño de la Cuenta Corriente ");
            string dueño1 = Console.ReadLine();

            Console.WriteLine($"Ingrese Saldo de: {dueño1}");
            int saldo1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Ingrese Cbu de: {dueño1}");
            int cbu1 = Convert.ToInt32(Console.ReadLine());

            CuentaCorriente cuentacorriente1 = new CuentaCorriente(dueño1, saldo1, cbu1);

            do
            {
                cajaahorro1.deposito(Convert.ToInt32(monto.Next(0, 10000)));
                Console.WriteLine($"Saldo nuevo de {dueño}: {cajaahorro1.getSaldo()}\n");
                cajaahorro1.extraccion(Convert.ToInt32(monto.Next(0, 10000)));
                Console.WriteLine($"Saldo nuevo de {dueño}: {cajaahorro1.getSaldo()}\n");

                cuentacorriente1.deposito(Convert.ToInt32(monto.Next(0, 10000)));
                Console.WriteLine($"Saldo nuevo de {dueño1}: {cuentacorriente1.getSaldo()}\n");
                cuentacorriente1.extraccion(Convert.ToInt32(monto.Next(0, 10000)));
                Console.WriteLine($"Saldo nuevo de {dueño1}: {cuentacorriente1.getSaldo()}\n");

                i++;
            } while (i <= 100);
            Console.WriteLine("Pulse tecla para salir");
            Console.ReadKey();
        }
    }
}


