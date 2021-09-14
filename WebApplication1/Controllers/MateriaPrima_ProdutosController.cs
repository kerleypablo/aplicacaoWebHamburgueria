using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class MateriaPrima_ProdutosController : Controller
    {
       
        private readonly MateriaPrimaServices _materiaPrimaServices;
        private readonly ProdutosServices _produtosServices;
        private readonly MateriaPrima_produtoServices _materiaPrima_produtoServices;

        public MateriaPrima_ProdutosController(ProdutosServices proddutosServices, MateriaPrimaServices materiaPrimaServices)
        {
            _produtosServices = proddutosServices;
            _materiaPrimaServices = materiaPrimaServices;
        }

        public IActionResult Index()
        {
            var list = _materiaPrimaServices.FindAll();
            return View(list);
        }

        public IActionResult Salvar()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Salvar(MateriaPrima mtp, Produto pdt)
        {
            _materiaPrima_produtoServices.Insert(mtp,pdt);
            return RedirectToAction(nameof(Index));
        }

    }
}
