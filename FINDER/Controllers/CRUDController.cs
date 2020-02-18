using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using FluentValidation.Results;
using FINDER.Controllers;
using FluentValidation.Mvc;

namespace FINDER.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        public static BusinessUsuario businessUsuario = new BusinessUsuario();


        public ActionResult CrudBuilder()
        {
            Usuario usuario = new Usuario();
            return View(usuario);
        }

        [HttpPost]
        
        public ActionResult CrudBuilder([CustomizeValidator(RuleSet = "Insert")] Usuario usuario)
        {
            UsuarioValidator usuarioValidator = new UsuarioValidator();
            ValidationResult result = usuarioValidator.Validate(usuario);
            if (!ModelState.IsValid)
            {
                //result.AddToModelState(ModelState, null);
                return View("CrudBuilder");
            }

            businessUsuario.Insert(usuario);
            
            return RedirectToAction("CrudBuilder");
        }

        public ActionResult Update()
        {
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult SelectByID([CustomizeValidator(RuleSet="GetByID")]Usuario userID)
        {
            Usuario usuario = businessUsuario.GetWithId(userID.ID);
            UsuarioValidator usuarioValidator = new UsuarioValidator();
            ValidationResult result = usuarioValidator.Validate(usuario);

            if (!ModelState.IsValid)
            {
                return View("Update", userID);
            }

            return View("Update", usuario);
        }

        public ActionResult SelectAll()
        {
            List<Usuario> listUsuario = businessUsuario.SelectAll();
            return View(listUsuario);
        }

    }
}