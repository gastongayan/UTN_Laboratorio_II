using System;
using Prestamos;
namespace Ejercicio_I01_Clase3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Cuenta cuenta1 = new Cuenta("Gaston", 2500365);
            Cuenta cuenta2 = new Cuenta("Guillermina", 4865999);

            cuenta1.Ingresar(265444);
            cuenta2.Ingresar(65422);

            Console.WriteLine(cuenta1.Mostrar());
            Console.WriteLine(cuenta2.Mostrar());
            

            cuenta1.Retirar(45877);
            cuenta2.Retirar(98874);

            Console.WriteLine(cuenta1.Mostrar());
            Console.WriteLine(cuenta2.Mostrar());



            


        }
    }
}
