using ClassLibraryLoterica.Models;
using ClassLibraryService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Controllers
{
    public class LotofacilConcursoController : Controller
    {
        private readonly ILotofacil concurso;
        public LotofacilConcursoController(ILotofacil concurso)
        {
            this.concurso = concurso;
        }
        public IActionResult Index()
        {
            List<Lotofacil> listLotofacil = new List<Lotofacil>();
            listLotofacil = concurso.GetAllConcursos().ToList();
            return View(listLotofacil);
        }
        public IActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            Lotofacil lotofacil = concurso.GetConcurso(id);

            if(lotofacil == null)
            {
                return NotFound();
            }

            return View(lotofacil);
        }
       public ActionResult Simular()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Simular(int? Dezena_01, int? Dezena_02, int? Dezena_03, int? Dezena_04, int? Dezena_05, int? Dezena_06, int? Dezena_07, int? Dezena_08,
                                               int? Dezena_09, int? Dezena_10, int? Dezena_11, int? Dezena_12, int? Dezena_13, int? Dezena_14, int? Dezena_15)
   {

            Lotofacil lotofacil = concurso.GetPontos15(Dezena_01, Dezena_02, Dezena_03, Dezena_04, Dezena_05, Dezena_06,
                Dezena_07, Dezena_08, Dezena_09, Dezena_10, Dezena_11, Dezena_12, Dezena_13, Dezena_14, Dezena_15);

            if (lotofacil == null)
            {
                return NotFound();
            }

            return View(lotofacil);
        }
    }
}
