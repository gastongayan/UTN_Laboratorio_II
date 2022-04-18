using System;

namespace Entidades
{
    public class Mascotas
    {
        public string nombre;
        public int edad;
        public string raza;
        public string especie;
        public bool hambre;


        public Mascotas(string nombre, string especie, int edad, string raza)
        {
            this.nombre = nombre;
            this.especie = especie;
            this.edad = edad;
            this.raza = raza;

        }
        public string Saludar()
        {
            return $"Hola mi nombre es {this.nombre} y soy un {this.especie} de la raza {this.raza} y tengo {this.edad} años. hambre {this.hambre}";
        }

        public static void Alimentar(Mascotas mascota)
        {
            if(!mascota.hambre)
            {
                mascota.hambre = true;
            }    
            
        }

        public void SetNombre(string nombre)
        {
            if (!string.IsNullOrEmpty(nombre))
            {
                this.nombre = nombre;
            }
        }

        public string GetNombre()
        {
            return this.nombre;
        }
    }
}
