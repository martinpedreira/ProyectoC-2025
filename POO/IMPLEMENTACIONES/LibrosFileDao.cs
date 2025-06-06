using System;
using POO.CLASES;
using POO.INTERFACES;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace POO.IMPLEMENTACIONES
{
    internal class LibrosFileDao : ILibrosDao
    {
        string filePath = ConfigurationManager.AppSettings["dbFilePath"];
        public void Agregar(Libros libros)
        {
            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(libros);
            }
                    
            
        }

        public int Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public int Modificar(Libros libros)
        {
            throw new NotImplementedException();
        }

        public List<Libros> ObtenerPorAutor(string autor)
        {
            throw new NotImplementedException();
        }

        public Libros ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Libros> ObtenerPorLectura(string lectura)
        {
            throw new NotImplementedException();
        }

        public List<Libros> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}
