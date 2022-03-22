using System;

/*
 * Ingresar 5 números por consola, 
 * guardándolos en una variable escalar. 
 * Luego calcular y mostrar: el valor máximo, 
 * el valor mínimo y el promedio.
 * */

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[5];
            string numeroTexto;
            bool resultado;
            int maximo=0;
            int minimo=0;
            float promedio=0f;
            int suma=0;
            int contador=0;
           

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                numeroTexto = Console.ReadLine();
                resultado = int.TryParse(numeroTexto, out numero[i]);
                while (!resultado && numero[i] <= 0)
                {
                    Console.WriteLine("Error, vuelva a ingresar un numero y mayor que 0: ");
                    numeroTexto = Console.ReadLine();
                    resultado = int.TryParse(numeroTexto, out numero[i]);
                }
                if (maximo == 0 || numero[i] > maximo)
                {
                    maximo = numero[i];
                }
                if (minimo == 0 || numero[i] < minimo)
                {
                    minimo = numero[i];
                }
                contador++;
                suma += numero[i];
            }
            promedio = suma / contador;
            Console.WriteLine("Maximo: {0} Minimo: {1} Promedio: {2}", maximo, minimo, promedio);
           

        }
    }
}
