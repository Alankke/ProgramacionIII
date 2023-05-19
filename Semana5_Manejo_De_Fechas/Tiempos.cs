using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeFechas
{
    internal class Tiempos
    {
        private static int[,] feriadosUtn =
        {

            {1,1}, {3,24}, {4,2}, {4,6}, {4,7}, {5,1}, {5,2}, {5,25}, {5,26},
            {6,17}, {6,19}, {6,20}, {7,9}, {8,19}, {8,21}, {8,27}, {9,21}, {10,13},
            {10,16}, {11,20}, {12,8}, {12,25}
        };
        public static int[,] Feriados { get => feriadosUtn; set => feriadosUtn = value; }


        public static bool IsHoliday(DateTime fecha)
        {
            for (int i = 0; i < feriadosUtn.GetLength(0); i++)
            {
                if (feriadosUtn[i, 0] == fecha.Month && feriadosUtn[i, 1] == fecha.Day) return true;
            }

            return false;
        }

        public static int ObtenerDiasCalendario(DateTime fecha1, DateTime fecha2)
        {
            TimeSpan dif = fecha1 - fecha2;
            return Math.Abs(dif.Days);
        }

        public static int ObtenerDiasLaborables(DateTime fecha1, DateTime fecha2)
        {
            DateTime auxiliar;

            if (fecha1 > fecha2)
            {
                auxiliar = fecha2;
            } else auxiliar = fecha1;

            int cantidadDias = ObtenerDiasCalendario(fecha1, fecha2);
            int diaslaborables = cantidadDias;

            
            for(int i = 0; i < cantidadDias; i++)
            {
                if (auxiliar.DayOfWeek == DayOfWeek.Saturday || auxiliar.DayOfWeek == DayOfWeek.Sunday || IsHoliday(auxiliar))
                {
                    diaslaborables--;
                }
                auxiliar = auxiliar.AddDays(1);
            }
            return diaslaborables;
        }

        public static DateTime SumarDiasLaborables(DateTime fecha1, int cantidadDias)
        {
            DateTime suma = fecha1.AddDays(cantidadDias);
           
            return suma;
        }





    }
}
