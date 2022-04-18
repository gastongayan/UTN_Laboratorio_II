using System;
using Biblioteca;

namespace Ejercicio_I02_Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Gaston", "21/11/2011", "14.524.151");
            Persona persona2 = new Persona("Guillermina", "10/09/1987", "25.454.663");
            Persona persona3 = new Persona("Emma", "01/04/2016", "54.325.541");

            Console.WriteLine(persona1.Mostrar());
            Console.WriteLine(persona2.Mostrar());
            Console.WriteLine(persona3.Mostrar());

            Console.WriteLine(persona1.EsMayorDeEdad());
            Console.WriteLine(persona2.EsMayorDeEdad());
            Console.WriteLine(persona3.EsMayorDeEdad());
            
        }
    }
}
