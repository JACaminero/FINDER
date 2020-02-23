using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataLayer.Business
{
    public class BusinessSexo
    {
        /// <summary>
        /// Gets algun sexo de la base de datos default, dado su id
        /// </summary>
        /// <param name="idSexo"> el id del objeto que se va a buscar </param>
        /// <returns> Un sexo especifico </returns>
        public Sexo GetByID(int idSexo)
        {
            SqlConnection con = ConnectionBuilder.GetDefaultConnection();

            string sentence = "SELECT * FROM Sexo " +
                              "WHERE ID_Sexo = @idSexo";

            SqlCommand command = new SqlCommand(sentence, con);
            command.Parameters.AddWithValue("@idSexo", idSexo);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            Sexo sex = new Sexo();

            while (reader.Read())
            {
                sex.ID_Sexo = reader.GetInt32(0);
                sex.NombreSexo = reader.GetString(1);
            }
            reader.Close();
            con.Close();

            return sex;
        }
    }
}
