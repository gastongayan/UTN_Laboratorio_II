using System;
using System.Text;

namespace Biblioteca
{
    public class TablasMatematicas
    {
        public static StringBuilder MostrarTabla(int numero)
        {
            StringBuilder tabla = new StringBuilder();
            int resultado = 0;
            if(numero > 0)
            {
                for(int i = 1; i < 10; i++)
                {
                    resultado = numero * i;
                    tabla.AppendFormat($"{i.ToString()} x {numero} = {resultado}");
                    tabla.AppendLine();
                    
                }
            }
            return tabla;
        }
    }
}
