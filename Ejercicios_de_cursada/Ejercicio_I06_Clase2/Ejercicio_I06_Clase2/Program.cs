using System;
using Biblioteca;
namespace Ejercicio_I06_Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcionTexto = string.Empty;
            int opcion = 0;
            string ladoTexto = string.Empty;
            int ladoCuadrado = 0;
            string baseTrianguloTexto = string.Empty;
            int baseTriangulo = 0;
            string alturaTrianguloTexto = string.Empty;
            int alturaTriangulo = 0;
            string radioCirculoTexto = string.Empty;
            int radioCirculo = 0;
            double area = 0;
            do
            {
                Console.WriteLine("Ingrese una opcion:");
                Console.WriteLine("1 - Calcular area de un Cuadrado");
                Console.WriteLine("2 - Calcular area de un Triangulo");
                Console.WriteLine("3 - Calcular area de un Circulo");
                opcionTexto = Console.ReadLine();

            } while (!int.TryParse(opcionTexto, out opcion));
            switch (opcion)
            {
                case 1:
                    do
                    {
                        Console.WriteLine("Ingrese medida del lado del cuadrado en centimetros:");
                        ladoTexto = Console.ReadLine();
                    } while (!int.TryParse(ladoTexto, out ladoCuadrado));
                    area = CalculadoraDeArea.CalcularAreaCuadrado(ladoCuadrado);
                    Console.WriteLine("El area del cuadrado es: {0}  cm2", area);
                    break;

                case 2:
                    do
                    {
                        Console.WriteLine("Ingrese base del triangulo en centimetros:");
                         baseTrianguloTexto = Console.ReadLine();
                        Console.WriteLine("Ingrese altura del triangulo en centimetros:");
                        alturaTrianguloTexto = Console.ReadLine();
                    } while (!(int.TryParse(baseTrianguloTexto, out baseTriangulo)) || !(int.TryParse(alturaTrianguloTexto, out alturaTriangulo)));
                    area = CalculadoraDeArea.CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                    Console.WriteLine("El area del triangulo es: {0} cm2", area);
                    break;

                case 3:
                    do
                    {
                        Console.WriteLine("Ingrese radio del circulo en centimetros:");
                        radioCirculoTexto = Console.ReadLine();
                    } while (!int.TryParse(radioCirculoTexto, out radioCirculo));
                    area = CalculadoraDeArea.CalcularAreaCirculo(radioCirculo);
                    Console.WriteLine("El area del circulo es: {0} cm2", area);
                    break;


            }


        }
    }
}
