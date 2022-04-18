using System;
using System.Text;
namespace StringBuilder02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Gaston";

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("Hola ");
            stringBuilder.Append("Mundo");
            stringBuilder.AppendLine("Con una linea abajo");
            stringBuilder.Append(Environment.NewLine); ;
            stringBuilder.AppendFormat($"Mi nombre es {nombre}");

            Console.WriteLine("{0}",stringBuilder);
        }
    }
}
