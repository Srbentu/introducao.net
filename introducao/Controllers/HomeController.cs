using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using introducao.Models;


namespace introducao.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ActionResult Index()
        {
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                PessoaName = "Breno",
                PessoaType = "Estag"
            };
            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["PessoaName"] = pessoa.PessoaName;
            ViewData["PessoaType"] = pessoa.PessoaType;
            ViewBag.id = pessoa.PessoaId;
            return View();
        }

        public IActionResult Contatos()
        {
            return View();
        }
        
    }
}
