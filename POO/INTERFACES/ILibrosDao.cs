using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.CLASES;
using POO.IMPLEMENTACIONES;

namespace POO.INTERFACES
{
    public interface ILibrosDao
    {
        void Agregar(Libros libros);
        int Eliminar(int id);   
        int Modificar (Libros libros); 
        Libros ObtenerPorId(int id);

        List<Libros> ObtenerTodos();

        List<Libros> ObtenerPorAutor(string autor);

        List<Libros> ObtenerPorLectura(string lectura);
    }
}
