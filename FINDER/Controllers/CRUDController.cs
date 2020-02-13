using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using System.Configuration;
using System.Data.SqlClient;

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

        private static CrudBuilder crud = new CrudBuilder();
        [HttpPost]
        public ActionResult CrudBuilder(Usuario usuario, FormCollection frm)
        {
            usuario.Nombre = Request.Form["TxtNombre"];
            usuario.FechaNacimiento = Convert.ToDateTime(Request.Form["TxtFecha"]);
            usuario.Localizacion = Request.Form["TxtLocalizacion"];
            usuario.Patrimonio = Convert.ToInt32(Request.Form["TxtPatrimonio"]);
            //HtmlElement rbelement = ;
            //usuario.Genero = Convert.ToChar(Request.Form["RBMasculino"]);
            //usuario.Genero = Convert.ToChar(Request.Form["RBFemenino"]);
            usuario.Bio = Request.Form["TxtBio"];

            crud.Insert(usuario);
            return RedirectToAction("CrudBuilder");
        }

        public ActionResult Update()
        {
            return View(new Usuario());
        }
    }
}