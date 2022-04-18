using System;

namespace Biblioteca
{
    public class Calculadora
    {
        public static float Calcular(int operando1, int operando2, string operadorMatematico)
        {
            float resultado = 0F;
            switch (operadorMatematico){
                
                case "+":
                    
                    resultado = operando1 + operando2;
                    break;

                case "-":

                    resultado = operando1 - operando2;
                    break;

                case "/":

                    resultado = operando1 / operando2;
                    break;

                case "*":

                    resultado = operando1 * operando2;
                    break;
                
                default:

                    resultado = -1;
                    break;


            }
            return resultado;
        }
    }
}
