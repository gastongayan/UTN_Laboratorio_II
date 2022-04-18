using System;

namespace Conversores
{
    public class Conversor
    {
        /// <summary>
        /// Convierte numero entero ingresado por parametro al sistema binario
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>numero binario en formato texto</returns>
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string numeroBinario= String.Empty;

            while(numeroEntero > 0)
            {
                
                if((numeroEntero % 2) == 0)
                {
                    numeroBinario += "0";
                }
                else
                {
                    numeroBinario += "1";
                }
                numeroEntero /= 2;
            }
            numeroBinario = InvertirString(numeroBinario);
            return numeroBinario;
        }
            


        
        /// <summary>
        /// Convierte numero binario entero recibido por parametro a sistema decimal
        /// </summary>
        /// <param name="numeroBinario"></param>
        /// <returns></returns>
        public static int ConvertirBinarioADecimal(int numeroBinario) 
        {
            int exponente = 0;
            int numeroDecimal = 0;
            int resto = 0;

            do
            {
                resto = numeroBinario % 10;
                numeroBinario /= 10;
                numeroDecimal += (int)(resto * Math.Pow(2, exponente));
                exponente++;

            }while(numeroBinario > 0);
            
            return numeroDecimal;
        }

        /// <summary>
        /// Clase para invertir el texto ingresado como parametro
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>texto invertido</returns>
        /// 
        private static string InvertirString(string texto)
        {
            char[] charArray = texto.ToCharArray();
            string textoInvertido = String.Empty;
            
            for (int i = charArray.Length - 1; i >= 0; i--)
            {
                textoInvertido += charArray[i];
            }
           
            return textoInvertido;
        }
    }
}
