using System;
using Biblioteca;
using System.Collections.Generic;
namespace Clase8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publicacion publicacion = new Publicacion("Batman", 50);
            Libro libro = new Libro("Cuentos de la selva", "Horacio quiroga", 156463, 126);
            Libro libro2 = new Libro("Cuentos de amor y locura", "Horacio quiroga", 1576554463, 196);
            Libro libro3 = new Libro("Recuerdos que mienten un poco", "Indio Solari", 1463, 398);
            Libro libro4 = new Libro("Santa macarena", "Bart Simpsons", 1463485, 988);

            List<Publicacion> publicaciones = new List<Publicacion>();
            Articulo articulo = new Articulo("UTN", "Herencia en C#", 1250);
            publicaciones.Add(libro);
            publicaciones.Add(libro2);
            publicaciones.Add(libro3);
            publicaciones.Add(libro4);
            publicaciones.Add(articulo);

            foreach(Publicacion item in publicaciones)
            {
                Console.WriteLine(MostrarInformacion(item));
            }
            
            


        }
        public static string MostrarInformacion(Publicacion publicacion)
        {
            return $"{publicacion.GetType().Name} Titulo: {publicacion.Titulo} Cantidad de paginas: {publicacion.Paginas} Fecha de publicacion: {publicacion.FechaDePublicacion}";
        }
    }
}
