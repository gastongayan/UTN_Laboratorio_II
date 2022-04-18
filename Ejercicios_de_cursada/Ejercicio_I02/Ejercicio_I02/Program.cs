using System;
using Metodos;
/*
 * Consigna#
Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje "¿Desea continuar? (S/N)".

Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.

El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
 * 
 */
namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero;
            int suma = 0;
            string numeroTexto;
            string respuesta;
            do
            {
                Console.WriteLine("Ingrese un numero:");
                numeroTexto = Console.ReadLine();
                if (int.TryParse(numeroTexto, out numero))
                {
                    suma += numero;
                }
                else
                {
                    Console.WriteLine("Dato ingresado incorrecto, no se realizo ninguna operación");
                }
                Console.WriteLine("Desea continuar? (S/N) ");
                respuesta = Console.ReadLine();
            } while (Validador.ValidadarRespuesta(respuesta));
            Console.WriteLine("Suma total: {0}", suma);
           
        }
    }
}
