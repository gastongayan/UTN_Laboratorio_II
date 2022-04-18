using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public sealed class Libro : Publicacion 

    {
        private int ISBN;
        private string autor;

        public Libro(string titulo, string autor, int ISBN, int paginas):base(titulo, paginas)
        {
            this.autor = autor;
            this.ISBN = ISBN;
            this.fechaDePublicacion = DateTime.Now;

        }

        public string MostrarInfo()
        {
            return "Soy un libro";
        }
    }
}
