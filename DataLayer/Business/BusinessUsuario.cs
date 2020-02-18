using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer
{
    public class BusinessUsuario : ICrudBuilder<Usuario>
    {
        public void Insert(Usuario usuario)
        {
            
            string sentence = $"INSERT INTO [dbo].[Usuario] ([nombre], [fechaNacimiento], [bio], " +
                $"[localizacion],[patrimonio], [ID_Sexo], [foto])" +
                $"VALUES(@nombre, @fechaNacimiento, @bio, @localizacion, @patrimonio, @Sexo, null)";

            SqlConnection con = ConnectionBuilder.GetDefaultConnection();

            SqlCommand command = new SqlCommand(sentence, con);
            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
            command.Parameters.AddWithValue("@bio", usuario.Bio);
            command.Parameters.AddWithValue("@localizacion", usuario.Localizacion);
            command.Parameters.AddWithValue("@patrimonio", usuario.Patrimonio);
            command.Parameters.AddWithValue("@Sexo", usuario.Sexo);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            return;
        }

        public List<Usuario> SelectAll()
        {
            SqlConnection con = ConnectionBuilder.GetDefaultConnection();
            string sentence = "SELECT nombre, fechaNacimiento, " +
                "bio, localizacion, patrimonio, ID_Sexo, foto " +
                "FROM Usuario";

            SqlCommand command = new SqlCommand(sentence, con);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            List<Usuario> listUser = new List<Usuario>();
            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.Nombre = reader.GetValue(0).ToString();
                usuario.FechaNacimiento = reader.GetDateTime(1);
                usuario.Bio = reader.GetValue(2).ToString();
                usuario.Localizacion = reader.GetValue(3).ToString();
                usuario.Patrimonio = Convert.ToDecimal(reader.GetValue(4));
                //usuario.Sexo = Convert.ToChar(reader.GetValue(5));

                listUser.Add(usuario);
            }
            reader.Close();
            con.Close();

            return listUser;
        }

        public void Update(Usuario usuario)
        {
            SqlConnection con = ConnectionBuilder.GetDefaultConnection();

            string sentence = $"UPDATE Usuario " +
                "SET nombre = @nombre, fechaNacimiento = @fecha, " +
                "bio = @bio, localizacion = @localizacion, patrimonio = @patrimonio" +
                "WHERE ID_Usuario = @id";

            SqlCommand command = new SqlCommand(sentence, con);
            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
            command.Parameters.AddWithValue("@bio", usuario.Bio);
            command.Parameters.AddWithValue("@localizacion", usuario.Localizacion);
            command.Parameters.AddWithValue("@patrimonio", usuario.Patrimonio);
            command.Parameters.AddWithValue("@id", usuario.ID);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public Usuario GetWithId(int id)
        {
            SqlConnection con = ConnectionBuilder.GetDefaultConnection();

            string sentence = "SELECT * FROM Usuario " +
                              "WHERE ID_Usuario = @id";

            SqlCommand comm = new SqlCommand(sentence, con);
            comm.Parameters.AddWithValue("@id", id);

            con.Open();
            var reader = comm.ExecuteReader();
            Usuario user = new Usuario();

            while (reader.Read())
            {
                user.Nombre = reader.GetValue(1).ToString();
                user.FechaNacimiento = reader.GetDateTime(2);
                user.Bio = reader.GetValue(3).ToString();
                user.Localizacion = reader.GetValue(4).ToString();
                user.Patrimonio = Convert.ToDecimal(reader.GetValue(5));
                //user.Sexo = Convert.ToChar(reader.GetValue(6));
            }
            reader.Close();
            con.Close();
            return user;
        }
    }
}
