using System;

namespace Biblioteca
{
    public class Tiempo
    {
        private int hora;
        private int minuto;
        private int segundo;

        public Tiempo(int hora, int minuto, int segundo)
        {
            this.hora = hora;
            this.minuto = minuto;   
            this.segundo = segundo; 

        }
        public Tiempo(int hora, int minuto):this(hora, minuto, 1)
        {
        }
        public Tiempo(int hora) : this(hora, 0)
        {
        }
        public string Mostrar()
        {
            return $"{this.hora}:{this.minuto}:{this.segundo}";
        }
        public static bool operator == (Tiempo t1, Tiempo t2)
        {
            return t1.hora == t2.hora && t1.minuto == t2.minuto && t1.segundo == t2.segundo;
        }
        public static bool operator != (Tiempo t1, Tiempo t2)
        {
            return !(t1 == t2);
        }
        
        
        
        /// <summary>
        /// Devuelve el valor de la hora expresado en segundos
        /// </summary>
        /// <param name="t"></param>
        public static implicit operator int(Tiempo t)
        {
            return ((t.hora * 60) + t.minuto) * 60 + t.segundo;
        }

        public static explicit operator Tiempo(string t)
        {
            string [] tiempoString = t.Split(':');
            return new Tiempo(int.Parse(tiempoString[0]), int.Parse(tiempoString[1]), int.Parse(tiempoString[2]));
        }

        
    }
}
