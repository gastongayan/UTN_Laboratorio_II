using System;
using Entidades;

namespace Objetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mascotas perro = new Mascotas("Dory", "Perro", 2, "Caniche");
                       

            Mascotas gato = new Mascotas("Bola de nieve", "Gato", 5, "Persa");
            

            Mascotas.Alimentar(perro);
            
            Console.WriteLine(perro.Saludar());

            Console.WriteLine(gato.Saludar());

        }
    }
}
