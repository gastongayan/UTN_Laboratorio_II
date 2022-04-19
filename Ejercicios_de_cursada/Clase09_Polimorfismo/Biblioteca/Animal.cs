using System;

namespace Biblioteca
{
    public class Animal
    {
        string nombre;
        int edad;

        public Animal(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public virtual string EmitirSonido()
        {
            return "gggrr";
        }

        public static bool operator ==(Animal a1, Animal a2)
        {
            return a1 is not null &&
                a2 is not null &&
                a1.edad == a2.edad &&
                a1.nombre == a2.nombre;
        }

        public static bool operator !=(Animal a1, Animal a2)
        {
            return a1 is not null &&
                a2 is not null &&
                !(a1 == a2);
        }
        public override bool Equals(object obj)
        {
            return this == (Animal)obj;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
