
using LLotofacil.Models;
using LLotofacil.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Controllers
{
    public class ApostaController : Controller
    {
        private readonly IAposta _Aposta;
        public ApostaController(IAposta _IAposta)
        {
            _Aposta = _IAposta;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(LotofacilAposta model)
        {
            if (ModelState.IsValid)
            {
                _Aposta.Add(model);
                return RedirectToAction("Historico");
            }
            return View(model);
        }
        public IActionResult Historico()
        {
            return View(_Aposta.GetApostas);
        }
    }
}
