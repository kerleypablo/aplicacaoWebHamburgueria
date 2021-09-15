using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class FornecedoresServices
    {
        private readonly WebApplication1Context _context;

        public FornecedoresServices(WebApplication1Context context)
        {
            _context = context;
        }

        public List<Fornecedor> FindAll()
        {
            return _context.Fornecedor.ToList();
        }

        public void Insert(Fornecedor frd)
        {
            _context.Add(frd);
            _context.SaveChanges();


        }
    }
}
