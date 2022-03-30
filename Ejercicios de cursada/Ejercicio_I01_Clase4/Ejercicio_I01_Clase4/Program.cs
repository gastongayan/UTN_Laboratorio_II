using System;
using Biblioteca;

namespace Ejercicio_I01_Clase4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();
            Sumador sumadorB = new Sumador(2);
            Sumador sumadorC = new Sumador(10);


            Console.WriteLine($"La suma de dos long {sumador.Sumar(45, 2)}");
            Console.WriteLine($"La suma de dos string{sumador.Sumar(" Hola "," Mundo ")}");

            int cantidadSumas = (int)sumador;
            Console.WriteLine(cantidadSumas);
            Console.WriteLine(sumadorB + sumador);
            Console.WriteLine(sumadorB | sumador);
            Console.WriteLine(sumador | sumadorC);

        }
    }
}
