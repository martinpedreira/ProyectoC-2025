using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.CLASES
{
    public class Libros
    {
        public int Id { get; set; }
        public string Titulo { get; set; }

        public string Autor { get; set; }

        public DateTime AñoPublicacion { get; set; }

        public int Puntaje { get; set; }
        
        public string Genero { get; set; }

        public string Lectura { get; set; }

        

        public Libros()
        {

        }

        public Libros(int id, string titulo, string autor, DateTime añoPublicacion, string genero,string lectura)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            AñoPublicacion = añoPublicacion;
            Genero = genero;
            Lectura = lectura;
        }
        public override string ToString()
        {
            return $" Titulo: {Titulo}, Autor: {Autor}";
        }
    }
}
