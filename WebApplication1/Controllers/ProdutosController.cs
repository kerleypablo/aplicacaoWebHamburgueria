using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutosServices _produtosServices;

        public ProdutosController(ProdutosServices proddutosServices)
        {
            _produtosServices = proddutosServices;
        }

        public IActionResult Index()
        {
            var list = _produtosServices.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produto prodduto)
        {
            _produtosServices.Insert(prodduto);
            return RedirectToAction(nameof(Index));
        }
    }
}
