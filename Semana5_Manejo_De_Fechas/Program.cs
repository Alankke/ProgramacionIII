using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeFechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una primer fecha para obtener dias calendario");
            DateTime fechaingresada = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese una segunda fecha para obtener dias calendario");
            DateTime fechaingresada2 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Los dias calendario que hay entre esas dos fechas son: " + Tiempos.ObtenerDiasCalendario(fechaingresada, fechaingresada2));

            Console.WriteLine("Ahora ingrese una primer fecha para obtener dias laborables (se exceptuan los feriados y fines de semana)");
            DateTime fechalaboral = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese una segunda fecha para obtener dias laborables (se exceptuan los feriados y fines de semana)");
            DateTime fechalaboral2 = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Los dias laborables que hay entre esas dos fechas son: " + Tiempos.ObtenerDiasLaborables(fechalaboral, fechalaboral2));

            Console.WriteLine("Ahora ingrese una fecha para sumar dias laborables");
            DateTime fechalaboralsuma = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de dias que quiera sumar"); 
            int dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Luego de {dias} días la fecha es: {Tiempos.SumarDiasLaborables(fechalaboralsuma,dias)}");

            Console.ReadKey();
        }
    }
}
