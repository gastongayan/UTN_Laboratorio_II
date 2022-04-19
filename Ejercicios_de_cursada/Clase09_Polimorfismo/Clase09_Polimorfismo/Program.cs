using System;
using Biblioteca;
namespace Clase09_Polimorfismo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Animal gato = new Gato();
            Animal animal = new Animal();


            Console.WriteLine($"Perro: {perro.EmitirSonido()}  \nGato: {gato.EmitirSonido()}   \nAnimal: {animal.EmitirSonido()}");
        }
    }
}
