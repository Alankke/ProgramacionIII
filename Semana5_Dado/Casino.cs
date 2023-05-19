using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leccion_13_04
{
    
    internal class Casino
    {
        private int pozo = 10000;

        public int getPozo() { return pozo; }
        //Tipo de apuesta y calcula segun el monto del jugador
        public void conserva(int monto, int dado, Jugador jugador)
        {
            pozo += monto;
            int eleccionjugador = elegir();
            calculo(monto, dado, jugador, 2, 1, eleccionjugador );

        }

        //Tipo de apuesta y calcula segun el monto del jugador
        public void arriesga(int monto, int dado, Jugador jugador) 
        {
            pozo += monto;
            int eleccionjugador = elegir();
            calculo(monto, dado, jugador, 5, 2, eleccionjugador);
        }

        //Tipo de apuesta y calcula segun el monto del jugador
        public void desespera(int monto, int dado, Jugador jugador) 
        {
            pozo += monto;
            int eleccionjugador = elegir();
            calculo(monto, dado, jugador, 15, 4, eleccionjugador);

        }

        //Tipo de apuesta y calcula segun el monto del jugador
        public void calculo(int monto, int dado, Jugador jugador, int multgana, int multpierde, int eleccionjugador)
        {

            int calculo;

            if (eleccionjugador == dado)
            {
                calculo = monto + monto * multgana;
                Console.WriteLine("El jugador, Ganó $" + calculo);
                jugador.gana(calculo);                
                pozo -= calculo;
            }
            else
            {
                calculo = monto * multpierde;
                Console.WriteLine("Perdiste $" + calculo);
                jugador.pierde(calculo);
                pozo += calculo;
            }

        }

        //Metodo para que el jugador elija el numero que piensa que van a salir
        private int elegir()
        {
            try
            {
                Console.WriteLine("Ingrese un numero entre el 2 y el 12 para adivinar");
                int eleccionjugador = Convert.ToInt32(Console.ReadLine());
                return eleccionjugador;
            }
            catch(Exception e)
            {
                throw;
            }
            
        }
    }
}
