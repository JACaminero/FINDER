using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataLayer;
using FluentValidation.Results;
using FINDER.Controllers;
using FluentValidation.Mvc;
using FluentValidation;
namespace FINDER.Controllers
{
    public class CRUDController : Controller
    {
        public static BusinessUsuario businessUsuario = new BusinessUsuario();
        // GET: CRUD
        public ActionResult CrudBuilder()
        {
            return View(new Usuario());
        }

        [HttpPost]
        public ActionResult CrudBuilder(Usuario usuario)
        {
            UsuarioValidator usuarioValidator = new UsuarioValidator();
            usuarioValidator.Validate(usuario);

            if (!ModelState.IsValid)
            {
                return View("CrudBuilder");
            }

            usuario.Sexo = new Sexo(usuario.Sexo.ID_Sexo);
            businessUsuario.Insert(usuario);

            TempData["Success"] = "Operacion Exitosa!!!!!!";
            return RedirectToAction("CrudBuilder");
        }

        public ActionResult Update([CustomizeValidator(RuleSet = "GetByID")]Usuario userID)
        {
            UsuarioValidator validator = new UsuarioValidator();
            ValidationResult result = validator.Validate(userID, ruleSet: "GetByID");
            Usuario usuario = businessUsuario.GetWithId(userID.ID);
            if (usuario.Sexo == null)
            {
                usuario.Sexo = new Sexo(0);
            }
            if (!ModelState.IsValid)
            {
                userID.Sexo = new Sexo(0);
                return View("Update", userID);
            }   
            return View(usuario);
        }

        [HttpPost]
        public ActionResult Update(FormCollection form, Usuario usuario)
        {
            UsuarioValidator usuarioValidator = new UsuarioValidator();
            usuarioValidator.Validate(usuario);
            int id = usuario.ID;
            usuario.Sexo = new Sexo(usuario.Sexo.ID_Sexo);
            businessUsuario.Update(usuario);

            if (!ModelState.IsValid)
            {
                usuario.Sexo = new Sexo(0);
                return View("Update", usuario);
            }

            return View("Update", new Usuario(0));
        }

        public ActionResult SelectAll()
        {
            List<Usuario> listUsuario = businessUsuario.SelectAll();
            return View(listUsuario);
        }

        [HttpPost]
        public ActionResult SelectAll(int id)
        {
            businessUsuario.Delete(id);
            return RedirectToAction("SelectAll");
        }
    }
}