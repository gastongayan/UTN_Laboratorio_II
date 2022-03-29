using System;

namespace Prestamos
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        public Cuenta(string titular, decimal cantidad)
        {
            if(!string.IsNullOrEmpty(titular) && cantidad > 0)
            {
                SetTitular(titular);
                SetCantidad(cantidad);

            }
            
        }

        public void SetTitular(string titular)
        {
            if (!string.IsNullOrEmpty(titular))
            {
                this.titular = titular;
            }
            
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public void SetCantidad(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad = cantidad;
            }
            
        }

        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"Nombre del Titular: {this.titular}   Cantidad: {this.cantidad}";
        }

        public void Ingresar(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad = cantidad;
            }    
        }

        public void Retirar(decimal cantidad)
        {
            if(cantidad > 0)
            {
                this.cantidad -= cantidad;
            }
        }
    }
}
