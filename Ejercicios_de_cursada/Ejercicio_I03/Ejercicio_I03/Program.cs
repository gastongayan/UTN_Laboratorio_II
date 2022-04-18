using System;
using Conversores;

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroBinario;
            int numeroDecimal;
            numeroBinario = Conversor.ConvertirDecimalABinario(155);
            Console.WriteLine(numeroBinario);
            numeroDecimal = Conversor.ConvertirBinarioADecimal(int.Parse(numeroBinario));
            Console.WriteLine(numeroDecimal);

        }
    }
}
