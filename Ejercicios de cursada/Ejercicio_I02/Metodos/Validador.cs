using System;

namespace Metodos
{
    public class Validador
    {
        public static bool ValidadarRespuesta(string respuesta)
        {
            return respuesta == "S" || respuesta == "s";
        }
    }
}
