using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataLayer.Data;

namespace DataLayer.Business
{
    class BusinessFetiche
    {
        public Fetiche GetById(int idFetiche)
        {
            SqlConnection con = ConnectionBuilder.GetDefaultConnection();

            string sentence = "SELECT * FROM Fetiche" +
                              "WHERE ID_Fetiche = @idFetiche";

            SqlCommand command = new SqlCommand(sentence, con);
            command.Parameters.AddWithValue("@idFetiche", idFetiche);

            con.Open();
            SqlDataReader reader = command.ExecuteReader();
            Fetiche fetish = new Fetiche();

            while (reader.Read())
            {
                fetish.ID_Fetiche = reader.GetInt32(0);
                fetish.NombreFetiche = reader.GetString(1);
            }
            reader.Close();
            con.Close();

            return fetish;
        }
    }
}
