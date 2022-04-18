using System;
using System.Text;
namespace Ingresantes
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;
        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            setNombre(nombre);
            setDireccion(direccion);
            setGenero(genero);
            setPais(pais);
            setEdad(edad);
            setCursos(cursos);
        }

        public void setNombre(string nombre)
        {
            if(nombre is not null)
            {
                this.nombre = nombre;
            }
            
        }

        public void setDireccion(string direccion)
        {
            if(direccion is not null)
            {
                this.direccion = direccion;
            }
        }

        public void setGenero(string genero)
        {
            if(genero is not null)
            {
                this.genero = genero;
            }
        }

        public void setPais(string pais)
        {
            if(pais is not null)
            {
                this.pais = pais;
            }
        }

        public void setEdad(int edad)
        {
            if(edad >= 0)
            {
                this.edad = edad;
            }
        }

        public void setCursos(string[] cursos)
        {
            this.cursos = cursos;
        }

        public string Mostrar()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Nombre: {this.nombre}");
            stringBuilder.AppendLine($"Direccion: {this.direccion}");
            stringBuilder.AppendLine($"Edad: {this.edad}");
            stringBuilder.AppendLine($"Genero: {this.genero}");
            stringBuilder.AppendLine($"Pais: {this.pais}");
            stringBuilder.AppendLine($"Cursos:");

            foreach (string curso in this.cursos)
            {
                stringBuilder.AppendLine(curso);
            }
            return stringBuilder.ToString();
        }
    }
}
