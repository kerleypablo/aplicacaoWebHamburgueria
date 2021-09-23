using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class MateriaPrimasController : Controller
    {
        private readonly WebApplication1Context _context;
        private readonly FornecedoresServices _fornecedoresServices;

        public MateriaPrimasController(WebApplication1Context context , FornecedoresServices fornecedoresServices)
        {
            _context = context;
            _fornecedoresServices = fornecedoresServices;
        }

        // GET: MateriaPrimas
        public async Task<IActionResult> Index()
        {
            return View(await _context.MateriaPrima.ToListAsync());
        }

        // GET: MateriaPrimas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaPrima = await _context.MateriaPrima
                .FirstOrDefaultAsync(m => m.MateriaPrimaId == id);
            if (materiaPrima == null)
            {
                return NotFound();
            }

            return View(materiaPrima);
        }

        // GET: MateriaPrimas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MateriaPrimas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,quantidade,uni,fornecedorId,VlrUnitario")] MateriaPrima materiaPrima)
        {
            if (ModelState.IsValid)
            {
                var list = _context.Add(materiaPrima);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            
            return View(materiaPrima);
        }

        // GET: MateriaPrimas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaPrima = await _context.MateriaPrima.FindAsync(id);
            if (materiaPrima == null)
            {
                return NotFound();
            }
            return View(materiaPrima);
        }

        // POST: MateriaPrimas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,quantidade,uni,fornecedor,vlrUnitario")] MateriaPrima materiaPrima)
        {
            if (id != materiaPrima.MateriaPrimaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materiaPrima);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MateriaPrimaExists(materiaPrima.MateriaPrimaId))
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
            return View(materiaPrima);
        }

        // GET: MateriaPrimas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaPrima = await _context.MateriaPrima
                .FirstOrDefaultAsync(m => m.MateriaPrimaId == id);
            if (materiaPrima == null)
            {
                return NotFound();
            }

            return View(materiaPrima);
        }

        // POST: MateriaPrimas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materiaPrima = await _context.MateriaPrima.FindAsync(id);
            _context.MateriaPrima.Remove(materiaPrima);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MateriaPrimaExists(int id)
        {
            return _context.MateriaPrima.Any(e => e.MateriaPrimaId == id);
        }
    }
}
