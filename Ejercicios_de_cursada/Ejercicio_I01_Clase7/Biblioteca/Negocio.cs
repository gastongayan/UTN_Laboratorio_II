using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        public Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.EPuesto.Caja1);   

        }
        public Negocio(string nombre):this()
        {
            this.nombre = nombre; 
        }



        public Cliente Cliente
        {
            get { return this.clientes.Dequeue(); }
            set { _ = this + value; }
        }

        public static bool operator ==(Cliente c, Negocio n)
        {
            foreach(Cliente cliente in n.clientes)
            {
                if(cliente == c)
                {
                    return true;
                }
            }
        }

        public static bool operator !=(Cliente c, Negocio n)
        {
            return !(c == n);
        }

        public static bool operator !=(Cliente c, Negocio n)
    }
}
