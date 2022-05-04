using System.Collections.ObjectModel;
using System.Linq;
using introducao.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

namespace Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        public ActionResult Usuario()
        {
            var usuario = new Usuario();
            return View(usuario);
        }
        
        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
                return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "Hugos",
                "Breno",
                "Julia"
            };
            //return Json(bdExemplo.All(x => x.ToLower() != login.ToLower(), JsonRequestBehaivor.AllowGet ));
            var json = bdExemplo.FirstOrDefault(x => x.ToLower() != login.ToLower());
            return Json(json);
        }
    }
}