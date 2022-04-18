using System;

namespace Validaciones
{
    public class Validador
    {
        public static bool Validar(int valor, int minimo, int maximo)
        {
            return valor > minimo && valor < maximo;
        }

    }
}

