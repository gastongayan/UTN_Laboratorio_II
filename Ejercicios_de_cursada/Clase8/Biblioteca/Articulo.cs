using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Articulo : Publicacion

    {
        private string editorial;
        public Articulo(string editorial, string titulo, int paginas) : base(titulo, paginas)
        {
            this.editorial = editorial;
        }

        public string MostrarInfo()
        {
            return "Soy un Articulo";
        }
    }
}
