using System;
using Biblioteca;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroUno = 0;
            string numeroUnoTexto;
            int numeroDos = 0;
            string numeroDosTexto;
            string operador = string.Empty;
            float resultado = -1; 

            do
            {
                Console.WriteLine("Ingrese un numero:");
                numeroUnoTexto = Console.ReadLine();

                if (int.TryParse(numeroUnoTexto, out numeroUno))
                {
                    Console.WriteLine("Ingrese otro numero:");
                    numeroDosTexto = Console.ReadLine();

                    if(int.TryParse(numeroDosTexto, out numeroDos))
                    {
                        Console.WriteLine("Ingrese operador:");
                        operador = Console.ReadLine();
                        resultado = Calculadora.Calcular(numeroUno, numeroDos, operador);
                    }
                }
                if(resultado == -1)
                {
                    Console.WriteLine("Operacion no valida, reingrese nuevamente los datos");
                }

            } while (resultado == -1);
           

            Console.WriteLine(resultado);
        }
    }
}