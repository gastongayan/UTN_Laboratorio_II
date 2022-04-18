using System;

namespace Biblioteca
{
    /// <summary>
    /// Enumerado de colores
    /// </summary>
    public enum Colores { Rojo, Blanco, Azul, Gris, Negro }

    public class Automovil : VehiculoTerrestre
    {

        private short cantidadMarchas;
        private int cantidadPasajeros;
        

        public Automovil(short cantidadRuedas, short cantidadPuertas,short cantidadMarchas, Colores color, int cantidadPasajeros):base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public short CantidadMarchas
        {
            get { return this.cantidadMarchas; }
            set { this.cantidadMarchas = value; }
        }

        public int CantidadPasajeros
        {
            get { return this.cantidadPasajeros; }
            set { this.cantidadPasajeros = value; }
        }


      
        
    }
}
