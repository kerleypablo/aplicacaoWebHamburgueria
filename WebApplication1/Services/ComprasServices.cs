using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class ComprasServices
    {

        private readonly WebApplication1Context _context;

        public ComprasServices(WebApplication1Context context)
        {
            _context = context;
        }

        public List<Compra> FindAll()
        {
            return _context.Compra.ToList();
        }

        public void Insert(Compra cps)
        {
            _context.Add(cps);
            _context.SaveChanges();

        }



    }
}
