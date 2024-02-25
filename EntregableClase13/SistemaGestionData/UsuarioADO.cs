
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Entidades
{
    public static class UsuarioADO
    {
        private static string connectionString;


        static UsuarioADO()
        {
            UsuarioADO.connectionString = "Server=.; Database=coderhouse; Trusted_Connection=True;";
        }

        public static List<Usuario> ObtenerTodosLosUsuarios()
        {
            
                List<Usuario> listadoDeUsuarios = new List<Usuario>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM USUARIO;";
                    SqlCommand sqlCommand = new SqlCommand(query, connection);
                    connection.Open();

                    SqlDataReader reader = sqlCommand.ExecuteReader();

                    while (reader.Read())
                    {
                        Usuario usuario = new Usuario();
                        usuario.Id = Convert.ToInt32(reader["Id"]);
                        usuario.Nombre = reader["Nombre"].ToString();
                        usuario.Apellido = reader["Apellido"].ToString();
                        usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                        usuario.Password = reader["Contraseña"].ToString();
                        usuario.Email = reader["Mail"].ToString();

                        listadoDeUsuarios.Add(usuario);

                    }
                }

                return listadoDeUsuarios;



        }
        public static Usuario ObtenerUnUsuarioPorId(int id)
        {
        

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM USUARIO WHERE ID=@ID;";
                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("ID", id);
                connection.Open();

                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(reader["Id"]);
                    usuario.Nombre = reader["Nombre"].ToString();
                    usuario.Apellido = reader["Apellido"].ToString();
                    usuario.NombreUsuario = reader["NombreUsuario"].ToString();
                    usuario.Password = reader["Contraseña"].ToString();
                    usuario.Email = reader["Mail"].ToString();

                    return usuario;

                }
            }
            throw new Exception("Usuario inexistente");

        }

        public static void CrearUsuario(Usuario usuario)
        {

        }

        public static void ActualizarUsuarioPorId(int id, Usuario usuario)
        {

        }


        public static void BorrarUsuarioPorId(int id)
        {

        }
    }
}
