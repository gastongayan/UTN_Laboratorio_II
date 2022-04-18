using System;
using Validaciones;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
           
            string numeroTexto;
            int minimo = 0;
            int maximo = 0;
            int contador = 0;
            int suma = 0;
            int promedio = 0;
            for (int i = 0; i < 10; i++)
            {
                do
                {
                    Console.WriteLine("Ingrese {0}° numero: ", i+1);
                    numeroTexto = Console.ReadLine();
                                       
                } while (!int.TryParse(numeroTexto, out numeros[i]) || !Validador.Validar(numeros[i], -100, 100));
                
                contador++;
                suma += numeros[i];

                if (maximo == 0 || numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
                
                if(minimo == 0 || numeros[i] < minimo)
                {
                    minimo = numeros[i];
                }

            }
            promedio = suma / contador;

            Console.WriteLine("Minimo: {0}    Maximo: {1}    Promedio: {2}",minimo,maximo,promedio);
        }
    }
}
