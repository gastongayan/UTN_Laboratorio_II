using System;

namespace Biblioteca
{
    public class Persona
    {
        string nombre;
        string fechaDeNacimiento;
        string dni;

        public Persona(string nombre, string fechaDeNacimiento, string dni)
        {
            if(!string.IsNullOrEmpty(nombre) || !string.IsNullOrEmpty(fechaDeNacimiento) || !string.IsNullOrEmpty(dni))
            {
                SetNombre(nombre);
                SetFechaNacimiento(fechaDeNacimiento);
                SetDni(dni);
            }
            
        }

        public void SetNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
        }

        public void SetFechaNacimiento(string fechaDeNacimiento)
        {
            if (!string.IsNullOrEmpty(fechaDeNacimiento))
            {
                this.fechaDeNacimiento = fechaDeNacimiento;
            }
        }
        public void SetDni(string dni)
        {
            if (!string.IsNullOrEmpty(dni))
            {
                this.dni = dni;
            }
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public string GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public string GetDni()
        {
            return this.dni;
        }

        private int CalcularEdad()
        {
            DateTime fecha = Convert.ToDateTime(this.fechaDeNacimiento);
            DateTime fechaActual = DateTime.Now;
            return fechaActual.Year - fecha.Year;
        }

        public string Mostrar()
        {
            return $"{this.nombre} -- {this.fechaDeNacimiento} -- {this.dni}";
        }

        public string EsMayorDeEdad()
        {
            string mensaje;
            if(CalcularEdad() > 17)
            {
                mensaje = "Es mayor de edad";
            }
            else
            {
                mensaje = "Es menor";
            }
            return mensaje;
        }
    }
}
