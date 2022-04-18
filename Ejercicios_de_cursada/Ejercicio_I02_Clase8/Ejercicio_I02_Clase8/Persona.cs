using System;

namespace Biblioteca
{
    public class Persona
    {
        private long dni;
        private string nombre;


        public Persona(string nombre) : this(nombre, 0)
        {
            
        }


        public Persona(string nombre, long dni)
        {
            this.Nombre = nombre;
            this.Dni = dni;
        }

        public long Dni
        {
            get { return dni; }
            set { dni = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string MostrarDatos()
        {
            return $"Nombre: {this.Nombre} \nDNI: {this.Dni}";
        }

        
    }
}
