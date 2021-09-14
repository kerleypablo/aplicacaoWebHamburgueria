using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class MateriaPrima_produtoServices
    {
        private readonly WebApplication1Context _context;

        public MateriaPrima_produtoServices(WebApplication1Context context )
        {
            _context = context;
        }

        public List<MateriaPrima> FindAll()
        {
            return _context.MateriaPrima.OrderBy(x => x.Nome).ToList();

        }

        public void Insert(MateriaPrima mtp,Produto pdt)
        {
            _context.Add(mtp) ;
            _context.SaveChanges();

        }
    }
}
