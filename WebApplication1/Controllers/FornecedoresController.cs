using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class FornecedoresController : Controller
    {
        private readonly FornecedoresServices _fornecedoresServices;

        public FornecedoresController(FornecedoresServices fornecedoresServices)
        {
            _fornecedoresServices = fornecedoresServices;
        }



        public IActionResult Index()
        {
            var list = _fornecedoresServices.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Fornecedor fornecedor)
        {
            _fornecedoresServices.Insert(fornecedor);
            return RedirectToAction(nameof(Index));
        }

    }
}
