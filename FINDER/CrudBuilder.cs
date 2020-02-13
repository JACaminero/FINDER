using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataLayer;
using System.Data.SqlClient;
using System.Configuration;

namespace FINDER
{
    public class CrudBuilder
    {

        public SqlConnection GetConnection()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["FINDERDB"].ConnectionString;
            return new SqlConnection(connectionString);
        }

        public void Insert(Usuario usuario)
        {
            string sentence = $"INSERT INTO [dbo].[Usuario] ([nombre], [fechaNacimiento], [bio], " +
                $"[localizacion],[patrimonio], [genero], [foto])" +
                $"VALUES(@nombre, @fechaNacimiento, @bio, @localizacion, @patrimonio, null)";

            SqlConnection con = GetConnection();

            SqlCommand command = new SqlCommand(sentence, con);
            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
            command.Parameters.AddWithValue("@bio", usuario.Bio);
            command.Parameters.AddWithValue("@localizacion", usuario.Localizacion);
            command.Parameters.AddWithValue("@patrimonio", usuario.Patrimonio);
            //command.Parameters.AddWithValue("@genero", usuario.Genero);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
        }
        
        public void Delete()
        {
            return;
        }

        public List<Usuario> Select()
        {
            return new List<Usuario>();
        }
        
        public void Update(int id_user)
        {
            SqlConnection con = GetConnection();

            string sentence = $"UPDATE Usuario " +
                "SET nombre = @nombre, fechaNacimiento = @fecha, " +
                    "bio = @bio, localizacion = @localizacion, patrimonio = @patrimonio" +
                    "WHERE ID_Usuario = @id";

            SqlCommand command = new SqlCommand(sentence, con);


        }
    }
}