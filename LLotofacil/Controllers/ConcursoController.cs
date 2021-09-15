using LLotofacil.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Controllers
{
    public class ConcursoController : Controller
    {
        private readonly IConcurso _Concurso;
        public ConcursoController(IConcurso _IConcurso)
        {
            _Concurso = _IConcurso;
        }
        
        public IActionResult Index()
        {
            return View(_Concurso.GetConcursos);
        }
        public IActionResult Resultados()
        {
            return View(_Concurso.GetConcursos);
        }
    }
}
