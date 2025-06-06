using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.CLASES;
using POO.INTERFACES;

namespace POO.IMPLEMENTACIONES
{
    public class LibrosMemoryDao : ILibrosDao

    {
        private List<Libros> libros = new List<Libros>();

        public LibrosMemoryDao() 
        {
            //Generamos algunos objetos por defecto
            libros.Add(new Libros(1, "El principito", "Antoine", new DateTime(1943, 4, 6), "Literatura Infantil", "Leido"));
            libros.Add(new Libros(2, "Moby Dick", "Herman Meleville", new DateTime(1851,11, 14), "Aventura","No leido"));
            libros.Add(new Libros(3, "Angeles y Demonios", "Dan Brown", new DateTime(2000, 2, 10), "Intriga y Suspenso","Leido"));

        }
        public void Agregar(Libros libro)
        {
            int ultimoId = libros.Count;
            libro.Id = ultimoId + 1;
            libros.Add(libro);

        }

        public int Eliminar(int id)
        {
            libros.RemoveAll(o  => o.Id == id);
            return 1;
        }

        public int Modificar(Libros libros)
        {
            Libros libros1 = ObtenerPorId(libros.Id);

            libros1.Titulo = libros.Titulo;
            libros1.Autor = libros1.Autor;
            libros1.Genero = libros1.Genero;
            libros1.AñoPublicacion = libros.AñoPublicacion;
            libros.Lectura = libros1.Lectura;
            libros.Puntaje= libros1.Puntaje;

            return 1;
        }

        public List<Libros> ObtenerPorAutor(string autor)
        {
            return libros.Where(o =>  o.Autor.Contains(autor)).ToList();
        }

        public Libros ObtenerPorId(int id)
        {
            
            foreach (var libros in libros)
            {
                if (libros.Id == id)
                {
                    return (libros);
                }
            }
            return null;
        }

        public List<Libros> ObtenerPorLectura(string lectura)
        {
            return libros;
        }

        public List<Libros> ObtenerTodos()
        {
            return libros;
        }



    }
}
