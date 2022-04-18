using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DirectorTecnico : Persona
    {
        public DateTime fechaNacimiento;
        public DirectorTecnico(string nombre, long dni, DateTime fechaNacimiento) : base(nombre, dni)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public static bool operator ==(DirectorTecnico director1, DirectorTecnico director2)
        {
            if (director1.Nombre == director2.Nombre && director1.Dni == director2.Dni)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(DirectorTecnico director1, DirectorTecnico director2)
        {
            return !(director1 == director2);
        }
    }
}
