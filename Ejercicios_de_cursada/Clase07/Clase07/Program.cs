using System;
using Biblioteca;
using System.Text;
using System.Collections.Generic;
namespace Clase07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador("Gaston", 33300831, 5, 10);
            Jugador jugador2 = new Jugador("Emma", 55505502, 19, 180);

            jugador.ColorCamiseta = Jugador.Color.Amarillo;
            List<Jugador> jugadores = new List<Jugador>();

            jugadores.Add(jugador);
            jugadores.Add(jugador2);

            jugador.ColorCamiseta = (Jugador.Color)jugador2.ColorCamiseta;

            Console.WriteLine("Hello World!");
        }
    }
}
