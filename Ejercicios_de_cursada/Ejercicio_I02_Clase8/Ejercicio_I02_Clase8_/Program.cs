using System;
using Biblioteca;
using System.Collections.Generic;
namespace Ejercicio_I02_Clase8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Gaston", 33300831, 145, 124);
            Jugador jugador2 = new Jugador("Petro", 33035575, 25, 44);
            Jugador jugador3 = new Jugador("Emma", 55505502, 54, 98);
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(jugador);
            jugadores.Add(jugador2);
            jugadores.Add(jugador3);


            Equipo equipo1 = new Equipo("Los Indestructibles",jugadores);



            Console.WriteLine("Hello World!");
        }
    }
}
