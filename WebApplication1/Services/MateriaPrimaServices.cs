using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class MateriaPrimaServices
    {
        private readonly WebApplication1Context _context;

        public MateriaPrimaServices(WebApplication1Context context)
        {
            _context = context;
        }

        public List<MateriaPrima> FindAll()
        {
            return _context.MateriaPrima.OrderBy(x => x.Nome).ToList();
               
        }


    }
}
