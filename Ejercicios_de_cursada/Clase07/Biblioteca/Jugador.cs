using System;

namespace Biblioteca
{
    public class Jugador
    {
        private Color color;
        private int dni;
        private string nombre;
        private int partidasJugadas;
        private int totalGoles;

        public Jugador(string nombre, int dni, int partidasJugadas, int totalGoles)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.partidasJugadas = partidasJugadas;
            this.totalGoles = totalGoles;
        }
        public enum Color
        {
            Rojo,
            Azul = 10,
            Amarillo
        }

        public Color ColorCamiseta
        {
            get
            {
                return color;
            }
            set
            {
                this.color = value;    
            }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public int TotalGoles
        {
            get { return this.totalGoles; }
        }
        
        public int PartidasJugadas
        {
            get 
            { 
                return this.partidasJugadas; 
            }
        }
        public float PromedioGoles
        {
            get
            {
                return (float)this.TotalGoles / this.PartidasJugadas;
            }
        }
    }
}
