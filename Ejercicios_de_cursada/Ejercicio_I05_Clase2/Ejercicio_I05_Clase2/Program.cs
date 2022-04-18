using System;
using System.Text;
using Biblioteca;

namespace Ejercicio_I05_Clase2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int numero = 0;
            string numeroTexto = string.Empty;
            StringBuilder tabla = new StringBuilder();



            do
            {
                Console.WriteLine("Ingrese un numero");
                numeroTexto = Console.ReadLine();

            } while (!int.TryParse(numeroTexto, out numero) || numero < 1);
            
            tabla = TablasMatematicas.MostrarTabla(numero);
            Console.WriteLine(tabla);
            
        }
    }
}
