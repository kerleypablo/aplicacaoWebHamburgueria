using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class MateriasPrimaController : Controller
    {
        public IActionResult Index()
        {
            List<MateriaPrima> list = new List<MateriaPrima>();
            list.Add(new MateriaPrima { Id = 1, Nome = "Pao", quantidade = 5, Unidade = "UN" });
            list.Add(new MateriaPrima { Id = 1, Nome = "hamburguer", quantidade = 5, Unidade = "UN" });
            list.Add(new MateriaPrima { Id = 1, Nome = "bacon", quantidade = 5.5, Unidade = "kg" });
            return View(list);
        }
    }
}
