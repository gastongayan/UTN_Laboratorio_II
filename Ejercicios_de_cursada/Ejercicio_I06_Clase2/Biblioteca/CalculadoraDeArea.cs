using System;

namespace Biblioteca
{
    public class CalculadoraDeArea
    {
        const float PI = 3.14159265358979F;
        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return longitudLado * 4;
        }
        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            return baseTriangulo * altura;
        }
        public static double CalcularAreaCirculo(double radio) 
        {
            return PI * Math.Pow(radio, 2);
        }
    }
}
