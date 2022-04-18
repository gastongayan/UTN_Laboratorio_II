using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        private int pesoCarga;
        private short cantidadMarchas;

        public Camion(short cantidadRuedas, short cantidadPuertas, short cantidadMarchas, Colores color,  int pesoCarga) : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.pesoCarga = pesoCarga;
            this.cantidadMarchas = cantidadMarchas;
        }

        public int PesoCarga
        {
            get { return pesoCarga; }
            set { pesoCarga = value; }
        }

        public short CantidadMarchas
        {
            get { return cantidadMarchas; }
            set { cantidadMarchas = value; }
        }

    }
}
