using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion_13_04
{
    internal class Jugador
    {
        //Todos los jugadores tienen 100 de saldo
        private int saldo = 100;
       
        //Constructor
        public Jugador() 
        {
        
        }

        //Getters y Setters
        public double getSaldo() { return saldo; }

        //Metodo para que el jugador apueste el monto que desee
        public int apostar()
        {
            int montoapostado;
            Console.WriteLine("Ingrese un monto a apostar");
            montoapostado = Convert.ToInt32(Console.ReadLine());

            if( montoapostado > saldo ) 
            {
                montoapostado = saldo;
            }

            saldo -= montoapostado;
            return montoapostado;
        }

        //Metodo para que el jugador elija algun numero entre el 2 y el 12
      
        //Metodo para sumar si es que gana
        public void gana(int montoapostado)
        {
            saldo += montoapostado;
        }

        //Metodo para restar si es que pierda
        public void pierde(int montoapostado)
        {
            saldo -= montoapostado;
        }
       
    }
}
