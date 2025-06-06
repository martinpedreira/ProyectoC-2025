using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POO.CLASES;
using POO.INTERFACES;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;

namespace POO.IMPLEMENTACIONES
{
    public class LibrosSqlServerDao : ILibrosDao
    {
        #region Commands
        private readonly string insertCommand = "INSERT INTO Libros(Titulo,Autor,Genero,AñoDePublicacion,Lectura,Puntaje)VALUES(@Titulo,@Autor,@Genero,@AñoDePublicacion,@Lectura,@Puntaje);";

        private readonly string selectCommand = "SELECT  * FROM Libros";

        private readonly string deleteCommand = "DELETE FROM Libros WHERE  Id = @Id";

        private readonly string updateCommand = "UPDATE Libros SET Titulo = @Titulo,Autor = @Autor, Genero = @Genero, AñoDePublicacion = @AñoDePublicacion,Lectura = @Lectura,Puntaje = @Puntaje  WHERE Id = @Id";

        private readonly string SelectOne = "SELECT  * FROM Libros WHERE  Id = @Id";

        private readonly string SelectByAutor = "SELECT * FROM Libros WHERE Autor LIKE @Autor";

        private readonly string SelectByLectura = "SELECT * FROM Libros WHERE Lectura LIKE @Lectura";
        #endregion


        private string connString = ConfigurationManager.ConnectionStrings["SqlServer"].ConnectionString;
        public void Agregar(Libros libros)
        {
            if (libros != null)
            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(this.insertCommand, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@Titulo", libros.Titulo);
                        sqlCommand.Parameters.AddWithValue("@Autor", libros.Autor);
                        sqlCommand.Parameters.AddWithValue("@Genero", libros.Genero);
                        sqlCommand.Parameters.AddWithValue("@AñoDePublicacion", libros.AñoPublicacion);
                        sqlCommand.Parameters.AddWithValue("@Lectura", libros.Lectura);
                        sqlCommand.Parameters.AddWithValue("@Puntaje",libros.Puntaje);
                        

                        object retorno = sqlCommand.ExecuteScalar();
                        if (retorno != null)
                        {
                            libros.Id = int.Parse(retorno.ToString());
                        }

                    }

                }
            }
            else
            {
                throw new ArgumentNullException("No se puede insertar un registro nulo");
            }
        }


        public int Eliminar(int id)
        {

            {
                using (SqlConnection conn = new SqlConnection(connString))
                {
                    conn.Open();
                    using (SqlCommand sqlCommand = new SqlCommand(this.deleteCommand, conn))
                    {
                        sqlCommand.Parameters.AddWithValue("@Id", id);


                        return sqlCommand.ExecuteNonQuery();
                    }

                }
            }
        }


        public int Modificar(Libros libros)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand sqlCommand = new SqlCommand(this.updateCommand, conn))
                {

                    sqlCommand.Parameters.AddWithValue("@Titulo", libros.Titulo);
                    sqlCommand.Parameters.AddWithValue("@Autor", libros.Autor);
                    sqlCommand.Parameters.AddWithValue("@Genero", libros.Genero);
                    sqlCommand.Parameters.AddWithValue("@AñoDePublicacion", libros.AñoPublicacion);
                    sqlCommand.Parameters.AddWithValue("@Lectura", libros.Lectura);
                    sqlCommand.Parameters.AddWithValue("@Puntaje", libros.Puntaje);
                   


                    sqlCommand.Parameters.AddWithValue("@Id", libros.Id);


                    return sqlCommand.ExecuteNonQuery();
                }

            }
        }

        public List<Libros> ObtenerPorAutor(string autor)
        {
            List<Libros> libros = new List<Libros>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();



                using (SqlCommand sqlCommand = new SqlCommand(this.SelectByAutor, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Autor", $"%{autor.ToLower()}%");
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Libros libro = new Libros();
                        libro.Id = int.Parse(reader["Id"].ToString());
                        libro.Titulo = reader["Titulo"].ToString();
                        libro.Autor = reader["Autor"].ToString();
                        libro.Genero = reader["Genero"].ToString();
                        libro.Lectura = reader["Lectura"].ToString();
                        libro.AñoPublicacion = DateTime.Parse(reader["AñoDePublicacion"].ToString());
                        libro.Puntaje = reader["Puntaje"] != DBNull.Value ? Convert.ToInt32(reader["Puntaje"]) : 0;



                        libros.Add(libro);

                    }

                }
                return libros;
            }  }

        public Libros ObtenerPorId(int id)
        {
            List<Libros> libros = new List<Libros>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                using (SqlCommand sqlCommand = new SqlCommand(this.SelectOne, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Id", id);
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.Read())
                    {
                        Libros libro = new Libros();
                        libro.Id = int.Parse(reader["Id"].ToString());
                        libro.Titulo = reader["Titulo"].ToString();
                        libro.Autor = reader["Autor"].ToString();
                        libro.Genero = reader["Genero"].ToString();
                        libro.Lectura = reader["Lectura"].ToString();
                        libro.AñoPublicacion = DateTime.Parse(reader["AñoDePublicacion"].ToString());
                        libro.Puntaje = reader["Puntaje"] != DBNull.Value ? Convert.ToInt32(reader["Puntaje"]) : 0;



                        return libro;
                    }
                    return null;
                }
            }
        }

        public List<Libros> ObtenerTodos()
        {
            List<Libros> libros = new List<Libros>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();



                using (SqlCommand sqlCommand = new SqlCommand(this.selectCommand, conn))
                {
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Libros libro = new Libros();
                        libro.Id = int.Parse(reader["Id"].ToString());
                        libro.Titulo = reader["Titulo"].ToString();
                        libro.Autor = reader["Autor"].ToString();
                        libro.Genero = reader["Genero"].ToString();
                        libro.Lectura = reader["Lectura"].ToString();
                        libro.AñoPublicacion = DateTime.Parse(reader["AñoDePublicacion"].ToString());
                        libro.Puntaje = reader["Puntaje"] != DBNull.Value ? (int)reader["Puntaje"] : 0;



                        libros.Add(libro);
                    }
                }
            }

            return libros;

        }

        public List<Libros> ObtenerPorLectura(string lectura)
        {
            List<Libros> libros = new List<Libros>();
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();



                using (SqlCommand sqlCommand = new SqlCommand(this.SelectByLectura, conn))
                {
                    sqlCommand.Parameters.AddWithValue("@Lectura", $"{lectura}%");
                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Libros libro = new Libros();
                        libro.Id = int.Parse(reader["Id"].ToString());
                        libro.Titulo = reader["Titulo"].ToString();
                        libro.Autor = reader["Autor"].ToString();
                        libro.Genero = reader["Genero"].ToString();
                        libro.Lectura = reader["Lectura"].ToString();
                        libro.AñoPublicacion = DateTime.Parse(reader["AñoDePublicacion"].ToString());
                        libro.Puntaje = reader["Puntaje"] != DBNull.Value ? Convert.ToInt32(reader["Puntaje"]) : 0;



                        libros.Add(libro);

                    }

                }
                return libros;
            }

        }


    }
    
}