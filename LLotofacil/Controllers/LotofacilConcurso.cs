using ClassLibraryLoterica.Models;
using ClassLibraryService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LLotofacil.Controllers
{
    public class LotofacilConcurso : Controller
    {
        private readonly ILotofacil concurso;
        public LotofacilConcurso(ILotofacil concurso)
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
    }
}
