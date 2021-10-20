using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LLotofacil.Models;
using LLotofacil.Repository;

namespace LLotofacil.Controllers
{
    public class LotofacilApostasController : Controller
    {
        private readonly LotericaDbContext _context;

        public LotofacilApostasController(LotericaDbContext context)
        {
            _context = context;
        }

        // GET: LotofacilApostas
        public async Task<IActionResult> Index()
        {
            return View(await _context.LotofacilApostas.ToListAsync());
        }

        // GET: LotofacilApostas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lotofacilAposta = await _context.LotofacilApostas
                .FirstOrDefaultAsync(m => m.ApostaID == id);
            if (lotofacilAposta == null)
            {
                return NotFound();
            }

            return View(lotofacilAposta);
        }

        // GET: LotofacilApostas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LotofacilApostas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ApostaID,Data,Dezena_01,Dezena_02,Dezena_03,Dezena_04,Dezena_05,Dezena_06,Dezena_07,Dezena_08,Dezena_09,Dezena_10,Dezena_11,Dezena_12,Dezena_13,Dezena_14,Dezena_15,Valor,Pontuacao,Ganho")] LotofacilAposta lotofacilAposta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lotofacilAposta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lotofacilAposta);
        }

        // GET: LotofacilApostas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lotofacilAposta = await _context.LotofacilApostas.FindAsync(id);
            if (lotofacilAposta == null)
            {
                return NotFound();
            }
            return View(lotofacilAposta);
        }

        // POST: LotofacilApostas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ApostaID,Data,Dezena_01,Dezena_02,Dezena_03,Dezena_04,Dezena_05,Dezena_06,Dezena_07,Dezena_08,Dezena_09,Dezena_10,Dezena_11,Dezena_12,Dezena_13,Dezena_14,Dezena_15,Valor,Pontuacao,Ganho")] LotofacilAposta lotofacilAposta)
        {
            if (id != lotofacilAposta.ApostaID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lotofacilAposta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LotofacilApostaExists(lotofacilAposta.ApostaID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(lotofacilAposta);
        }

        // GET: LotofacilApostas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lotofacilAposta = await _context.LotofacilApostas
                .FirstOrDefaultAsync(m => m.ApostaID == id);
            if (lotofacilAposta == null)
            {
                return NotFound();
            }

            return View(lotofacilAposta);
        }

        // POST: LotofacilApostas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lotofacilAposta = await _context.LotofacilApostas.FindAsync(id);
            _context.LotofacilApostas.Remove(lotofacilAposta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LotofacilApostaExists(int id)
        {
            return _context.LotofacilApostas.Any(e => e.ApostaID == id);
        }
    }
}
