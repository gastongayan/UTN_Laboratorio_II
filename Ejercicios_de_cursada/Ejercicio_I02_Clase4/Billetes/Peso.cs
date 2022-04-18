using System;

namespace Billetes
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        public Peso()
        {
            Peso.cotzRespectoDolar = 102.65;
        }
        public Peso(double cantidad)
        {
             this.cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizacion) : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }
        public double GetCantidad
        {
            get { return cantidad; }
        }

        public static double GetCotizacion
        {
            get { return Peso.cotzRespectoDolar; }
        }

        public static implicit operator Peso(double p)
        {
            return new Peso(p);
        }

        public static explicit operator Dolar(Peso p)
        {
            return new Dolar((p.cantidad / Peso.GetCotizacion));
        }

        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad == p2.GetCantidad;
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            return p.GetCantidad == ((Peso)d).GetCantidad;

        }
        public static bool operator ==(Peso p, Euro e)
        {
            return p.GetCantidad == ((Peso)e).GetCantidad;

        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

    }
    
   
}
