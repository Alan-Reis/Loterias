using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Controllers
{
    public class ApostaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Historico()
        {
            return View();
        }
    }
}
