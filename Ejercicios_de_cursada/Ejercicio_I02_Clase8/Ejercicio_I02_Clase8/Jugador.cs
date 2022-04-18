using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador : Persona
    {
        private int partidosJugados;
        private int totalGoles;

        public Jugador(string nombre, long dni, int partidosJugados, int totalGoles) : base(nombre, dni)
        {
            this.PartidosJugados = partidosJugados;
            this.TotalGoles = totalGoles;
        }

        public int PartidosJugados
        {
            get { return partidosJugados; }
            set { partidosJugados = value; }
        }

        public int TotalGoles 
        { 
            get { return totalGoles; } 
            set { totalGoles = value; }
        }

        public string MostrarDatos()
        {
            return $"Partidos jugados: {this.PartidosJugados} \nTotal de goles: {this.TotalGoles}";
        }
        public static bool operator ==(Jugador jugador1, Jugador jugador2)
        {
            if (jugador1.Nombre == jugador2.Nombre && jugador1.Dni == jugador2.Dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Jugador jugador1, Jugador jugador2)
        {
            return !(jugador1 == jugador2);
        }

    }
}
