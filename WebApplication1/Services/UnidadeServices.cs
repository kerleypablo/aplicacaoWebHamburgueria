using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class UnidadeServices
    {

        private readonly WebApplication1Context _context;

        public UnidadeServices(WebApplication1Context context)
        {
            _context = context;
        }

        public List<Unidade> FindAll()
        {
            return _context.Unidade.ToList();
        }

        public void Insert(Unidade und)
        {
            _context.Add(und);
            _context.SaveChanges();

        }

    }
}
