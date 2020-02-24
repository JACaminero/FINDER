using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataLayer.Business;

namespace DataLayer
{
    public class BusinessUsuario : ICrudBuilder<Usuario>
    {
        public void Insert(Usuario usuario)
        {
            string sentence = $"INSERT INTO [dbo].[Usuario] ([nombre], [fechaNacimiento], [bio], " +
                $"[localizacion],[patrimonio], [ID_Sexo], [foto])" +
                $"VALUES(@nombre, @fechaNacimiento, @bio, @localizacion, @patrimonio, @Sexo, @foto)";

            SqlConnection con = ConnectionBuilder.GetDefaultConnection();

            SqlCommand command = new SqlCommand(sentence, con);
            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
            command.Parameters.AddWithValue("@bio", usuario.Bio);
            command.Parameters.AddWithValue("@localizacion", usuario.Localizacion);
            command.Parameters.AddWithValue("@patrimonio", usuario.Patrimonio);
            command.Parameters.AddWithValue("@Sexo", usuario.Sexo.ID_Sexo);
            command.Parameters.AddWithValue("@foto", usuario.Imagen);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public void Delete(int id)
        {
            SqlConnection con = ConnectionBuilder.GetDefaultConnection();
            string sentence = "DELETE FROM Usuario " +
                                "WHERE ID_Usuario = @id";
            
            SqlCommand command = new SqlCommand(sentence, con);
            command.Parameters.AddWithValue("@id", id);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
        
        public List<Usuario> SelectAll()
        {
            SqlConnection con = ConnectionBuilder.GetDefaultConnection();
            string sentence = "SELECT nombre, fechaNacimiento, " +
                "bio, localizacion, patrimonio, ISNULL(ID_Sexo, 0), ID_Usuario, ISNULL(foto, 0x10)" +
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
                int idSexo = reader.GetInt32(5);
                usuario.Sexo = new Sexo(idSexo);
                usuario.ID = reader.GetInt32(6);
                usuario.Imagen = (byte[])reader.GetValue(7);

                listUser.Add(usuario);
            }
            reader.Close();
            con.Close();

            return listUser;
        }

        public void Update(Usuario toUpdate)
        {
            SqlConnection con = ConnectionBuilder.GetDefaultConnection();

            string sentence = $"UPDATE Usuario " +
                "SET nombre = @nombre, fechaNacimiento = @fecha, " +
                "bio = @bio, localizacion = @localizacion, patrimonio = @patrimonio, ID_Sexo = @idSexo, foto = @foto " +
                "WHERE ID_Usuario = @id";

            SqlCommand command = new SqlCommand(sentence, con);
            command.Parameters.AddWithValue("@nombre", toUpdate.Nombre);
            command.Parameters.AddWithValue("@fecha", toUpdate.FechaNacimiento);
            command.Parameters.AddWithValue("@bio", toUpdate.Bio);
            command.Parameters.AddWithValue("@localizacion", toUpdate.Localizacion);
            command.Parameters.AddWithValue("@patrimonio", toUpdate.Patrimonio);
            command.Parameters.AddWithValue("@idSexo", toUpdate.Sexo.ID_Sexo);
            command.Parameters.AddWithValue("@id", toUpdate.ID);
            command.Parameters.AddWithValue("@foto", toUpdate.Imagen); 

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }

        public Usuario GetWithId(int id)
        {
            SqlConnection con = ConnectionBuilder.GetDefaultConnection();

            string sentence = "SELECT nombre, fechaNacimiento, " +
                "bio, localizacion, patrimonio, ISNULL(ID_Sexo, 0), foto, ID_Usuario FROM Usuario " +
                              "WHERE ID_Usuario = @id";

            SqlCommand comm = new SqlCommand(sentence, con);
            comm.Parameters.AddWithValue("@id", id);

            con.Open();
            var reader = comm.ExecuteReader();
            Usuario user = new Usuario();

            while (reader.Read())
            {
                user.Nombre = reader.GetValue(0).ToString();
                user.FechaNacimiento = reader.GetDateTime(1);
                user.Bio = reader.GetValue(2).ToString();
                user.Localizacion = reader.GetValue(3).ToString();
                user.Patrimonio = Convert.ToDecimal(reader.GetValue(4));
                int idSexo = Convert.ToInt16(reader.GetValue(5));
                user.Sexo = new Sexo(idSexo);
            }
            user.ID = id;

            reader.Close();
            con.Close();

            return user;
        }
    }
}
