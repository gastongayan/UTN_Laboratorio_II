using System;
using Biblioteca;
namespace Clase_4_Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //int entero;
            //float flotante;

            //Conversion explicita

            Tiempo t = (Tiempo)"21:35:55";

            Console.WriteLine(t.Mostrar());


            Tiempo tiempo1 = new Tiempo(4, 20, 54);
            Tiempo tiempo = tiempo1;
            Tiempo tiempo2 = new Tiempo(4, 20);
            Tiempo tiempo3 = new Tiempo(4);
            Tiempo tiempo4 = new Tiempo(4, 20, 54);

            Console.WriteLine(tiempo1.Mostrar());
            Console.WriteLine(tiempo2.Mostrar());
            Console.WriteLine(tiempo3.Mostrar());

            //sobre carga del operador ==
            Console.WriteLine(tiempo == tiempo1);
            Console.WriteLine(tiempo == tiempo4);

            //Compara posiciones de memoria
            Console.WriteLine(Object.ReferenceEquals(tiempo, tiempo1));
            Console.WriteLine(Object.ReferenceEquals(tiempo, tiempo4));

            //conversion explicita
            //entero = (int)flotante;


            //convercion implicita
            int segundo = tiempo;
            Console.WriteLine(tiempo.Mostrar());
            Console.WriteLine(segundo);
        }
    }
}
