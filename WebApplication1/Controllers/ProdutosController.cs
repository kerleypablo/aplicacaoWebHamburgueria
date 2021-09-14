using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ProdutosServices _produtosServices;
        private readonly MateriaPrimaServices _materiaPrimaServices;
        private readonly MateriaPrima_produtoServices _materiaPrima_produtoServices;

        public ProdutosController(ProdutosServices proddutosServices, MateriaPrimaServices materiaPrimaServices, MateriaPrima_produtoServices materiaPrima_produtoServices)
        {
            _produtosServices = proddutosServices;
            _materiaPrimaServices = materiaPrimaServices;
            _materiaPrima_produtoServices = materiaPrima_produtoServices;
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

        public IActionResult Construct()
        {

            var list = _materiaPrimaServices.FindAll();
            var viewModel = new MateriaPrima_ProdutoFormViwModel { MateriaPrimas = list };
            return View(viewModel);
        }

        public IActionResult Salvar()
        {
            return View();
        }
 
        [HttpPost]
        [Route("{id}")]
        [ValidateAntiForgeryToken]
        public IActionResult UpdateChecks(IList<int> ListaMateriais,int id)
        {
            foreach(var materiaP in ListaMateriais)
            {
                MateriaPrima_Produto mtp = new MateriaPrima_Produto(materiaP,id);
            _materiaPrima_produtoServices.Insert(mtp);
            }
            return RedirectToAction(nameof(Index));
           
        }


    }
}
