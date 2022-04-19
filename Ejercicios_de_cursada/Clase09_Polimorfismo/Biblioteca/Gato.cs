using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Gato : Animal
    {
        bool tienePulgas;
        public Gato(string nombre, int edad): base(nombre, edad)
        {

        }
        public override string EmitirSonido()
        {
            return "Miaaauu";
        }

        public static bool operator ==(Gato g1, Gato g2)
        {
            return (Animal)g1 == g2 && g1.tienePulgas == g2.tienePulgas
        }
        public static bool operator !=(Gato g1, Gato g2)
        {
            return !(g1 == g2);
        }

        public override bool Equals(object obj)
        {
            Gato gato = obj as Gato;

            return gato is not null && this == (Gato)obj;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }
    }
}
