
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ProdutosServices
    {
        private readonly WebApplication1Context _context;

        public ProdutosServices(WebApplication1Context context)
        {
            _context = context;
        }

        public List<Produto> FindAll()
        {
            return _context.Produto.ToList();
        }

        public void Insert(Produto prd)
        {
            _context.Add(prd);
            _context.SaveChanges();

        }
      
      
    }
}
