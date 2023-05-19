using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Leccion_13_04
{
    
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //Creacion de objetos
            Dado dado = new Dado();
            Casino casino = new Casino();
            Jugador jugador1 = new Jugador();
            Jugador jugador2 = new Jugador();

            while (jugador1.getSaldo() > 0 && jugador2.getSaldo() > 0) 
            {
                //Tira el dado para asignar un valor y crear un numero random
                int numRandom = dado.arrojar();

                //hace que apuesten un monto los dos jugadores
                int elegido1 = jugador1.apostar();
                int elegido2 = jugador2.apostar();

                Console.WriteLine("Elija su apuesta con los numeros 1, 2 o 3: \n1)Conservadora \n2)Arriesgada \n3)Desesperada");

                //pide al jugador1 el tipo de apuesta
                Console.WriteLine("Tipo de apuesta para jugador 1");
                int tipoapuesta1 = Convert.ToInt32(Console.ReadLine());

                //pide al jugador2 el tipo de apuesta
                Console.WriteLine("Tipo de apuesta para jugador 2");
                int tipoapuesta2= Convert.ToInt32(Console.ReadLine());

                //juega la ronda con el jugador1
                jugarRonda(jugador1, casino, tipoapuesta1, elegido1, numRandom);

                //juega la ronda con el jugador2
                jugarRonda(jugador2, casino, tipoapuesta2, elegido2, numRandom);

                Console.ReadKey();
            }
            if(jugador1.getSaldo() < 0 && jugador2.getSaldo() < 0)
            {
                Console.WriteLine("El juego ha terminado porque los dos jugadores han quedado sin saldo");
            }
            else
            {
                if(casino.getPozo() < 0)
                {
                    Console.WriteLine("El juego ha terminado porque el casino quedó sin pozo");
                }
            }
        }
        static void jugarRonda(Jugador jugador, Casino casino, int tipo, int monto, int numRandom)
        {
            switch(tipo)
            {
                case 1:
                    casino.conserva(monto, numRandom, jugador);
                    break;
                case 2:
                    casino.arriesga(monto, numRandom, jugador);
                    break;
                case 3:
                    casino.desespera(monto, numRandom, jugador);
                    break;
            }
        }
    
    }
}


