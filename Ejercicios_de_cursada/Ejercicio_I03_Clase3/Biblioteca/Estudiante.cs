using System;

namespace Biblioteca
{
    public class Estudiante
    {
        string nombre;
        string apellido;
        string legajo;
        int notaPrimerParcial;
        int notaSegundoParcial;
        int random;

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.random = InicializarRandom();
        }
        public Estudiante() : this("", "", "")
        {

        }

        public int InicializarRandom()
        {
            Random random = new Random();
            return random.Next(6, 10);
        }
       
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private float CalcularPromedio()
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        public int CalcularNotaFinal()
        {
            return this.random;
        }
    }
}
