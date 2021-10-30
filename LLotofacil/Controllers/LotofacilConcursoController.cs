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
            if (id == null)
            {
                return NotFound();
            }

            Lotofacil lotofacil = concurso.GetConcurso(id);

            if (lotofacil == null)
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
        public ActionResult Simular(int? Dezena_01, int? Dezena_02, int? Dezena_03, int? Dezena_04, int? Dezena_05,
                                    int? Dezena_06, int? Dezena_07, int? Dezena_08, int? Dezena_09, int? Dezena_10,
                                    int? Dezena_11, int? Dezena_12, int? Dezena_13, int? Dezena_14, int? Dezena_15)
        {

            //ViewBag para mostrar na tela as dezenas digitadas
            ViewBag.Dezena_01 = Dezena_01;
            ViewBag.Dezena_02 = Dezena_02;
            ViewBag.Dezena_03 = Dezena_03;
            ViewBag.Dezena_04 = Dezena_04;
            ViewBag.Dezena_05 = Dezena_05;
            ViewBag.Dezena_06 = Dezena_06;
            ViewBag.Dezena_07 = Dezena_07;
            ViewBag.Dezena_08 = Dezena_08;
            ViewBag.Dezena_09 = Dezena_09;
            ViewBag.Dezena_10 = Dezena_10;
            ViewBag.Dezena_11 = Dezena_11;
            ViewBag.Dezena_12 = Dezena_12;
            ViewBag.Dezena_13 = Dezena_13;
            ViewBag.Dezena_14 = Dezena_14;
            ViewBag.Dezena_15 = Dezena_15;

            List<Lotofacil> listLotofacil = new List<Lotofacil>();
            listLotofacil = concurso.GetPontos(Dezena_01, Dezena_02, Dezena_03, Dezena_04, Dezena_05,
                                                       Dezena_06, Dezena_07, Dezena_08, Dezena_09, Dezena_10,
                                                       Dezena_11, Dezena_12, Dezena_13, Dezena_14, Dezena_15).ToList();


            if (listLotofacil == null)
            {
                return NotFound();
            }

            return View(listLotofacil);
        }
    }
}
