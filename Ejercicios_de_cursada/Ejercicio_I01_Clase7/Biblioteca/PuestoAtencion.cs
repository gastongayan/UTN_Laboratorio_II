using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
namespace Biblioteca
{
    public class PuestoAtencion
    {
        public enum EPuesto { Caja1, Caja2 };
        private static int numeroActual;
        private EPuesto puesto;

        public PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(EPuesto puesto)
        {
            this.puesto = puesto;
        }
        public static int NumeroActual
        {
            get { return ++numeroActual; }

        }

        public bool Atender(Cliente c)
        {
            if(c is not null)
            {
                Thread.Sleep(3000);
                return true;
            }
            return false;
        }
    }
}
