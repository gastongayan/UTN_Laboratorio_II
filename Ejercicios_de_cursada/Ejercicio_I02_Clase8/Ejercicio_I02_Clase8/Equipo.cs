using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadJugadores;
        List<Jugador> jugadores;
        private string nombre;

        public Equipo(string nombre, List<Jugador> jugadores)
        {
            this.nombre = nombre;
            this.jugadores = jugadores;
            this.cantidadJugadores = (short)jugadores.Count;


        }

        public static bool operator +(Equipo e, Jugador j)
        {
            if(e is not null)
            {
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }
    }
}
