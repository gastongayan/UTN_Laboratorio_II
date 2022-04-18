using System;

namespace Biblioteca
{
    public class Publicacion
    {

        private string titulo;
        private int paginas;
        protected DateTime fechaDePublicacion;

        public Publicacion(string titulo, int paginas)
        {
            this.titulo = titulo;
            this.paginas = paginas;

        }

        public string Titulo
        {
            get { return titulo; } 
        }

        public int Paginas 
        {   get { return this.paginas; } 
            set { this.paginas = value; }
        }

        public DateTime FechaDePublicacion
        { 
            get { return fechaDePublicacion; } 
        }


    }
}
