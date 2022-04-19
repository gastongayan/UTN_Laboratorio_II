using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Perro : Animal
    {
        public override string EmitirSonido()
        {
            return "Guau";    
        }

        public static bool operator ==(Perro p1, Perro p2)
        {
            return (Animal)p1 == p2;
        }
        public static bool operator !=(Perro p1, Perro p2)
        {
            return !(p1 == p2);
        }

        public override bool Equals(object obj)
        {
            Perro perro = obj as Perro;

            return perro is not null && this == (Perro)obj;
        }
    }
}
