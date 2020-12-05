using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhaAppVSCode.Models;

namespace MinhaAppVSCode.Controllers
{
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categorias?}")]
        public IActionResult Index(int id, string categorias)
        {
            var filme = new Filme()
            {
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Avaliacao = "10",
                Valor = 2000
            };

            return RedirectToAction("Privacy", filme);
        }

        [Route("privacidade")]
        [Route("politica-privacidade")]
        public IActionResult Privacy(Filme movie)
        {
            if (ModelState.IsValid)
            {

            }

            foreach (var colErreurs in ModelState.Values.SelectMany(p=>p.Errors))
            {
                Console.WriteLine(colErreurs.ErrorMessage);
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
