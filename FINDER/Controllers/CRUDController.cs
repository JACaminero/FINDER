using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FINDER.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD

        public ActionResult CrudBuilder()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        public ActionResult CrudBuilder(Usuario usuario, FormCollection frm)
        {
            var connectionString = ConfigurationManager.ConnectionStrings["FINDERDB"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);

            string sentence = $"INSERT INTO [dbo].[Usuario] ([nombre], [fechaNacimiento],[bio] ," +
                $"[localizacion],[patrimonio], [genero],[foto])" +
                $"VALUES(@nombre, @fechaNacimiento, @bio, @localizacion, @patrimonio, @genero, null)";

            usuario.Nombre = Request.Form["TxtNombre"];
            usuario.FechaNacimiento = Convert.ToDateTime(Request.Form["TxtFecha"]);
            usuario.Localizacion = Request.Form["TxtLocalizacion"];
            usuario.Patrimonio = Convert.ToInt32(Request.Form["TxtPatrimonio"]);

            //HtmlElement rbelement = ;
            
            
            usuario.Genero = Convert.ToChar(Request.Form["RBMasculino"]);
            usuario.Genero = Convert.ToChar(Request.Form["RBFemenino"]);
            
            usuario.Bio = Request.Form["TxtBio"];

            SqlCommand command = new SqlCommand(sentence, con);
            command.Parameters.AddWithValue("@nombre", usuario.Nombre);
            command.Parameters.AddWithValue("@fechaNacimiento", usuario.FechaNacimiento);
            command.Parameters.AddWithValue("@bio", usuario.Bio);
            command.Parameters.AddWithValue("@localizacion", usuario.Localizacion);
            command.Parameters.AddWithValue("@patrimonio", usuario.Patrimonio);
            command.Parameters.AddWithValue("@genero", usuario.Genero);

            con.Open();
            command.ExecuteNonQuery();
            con.Close();
            return RedirectToAction("CrudBuilder");
        }
    }
}