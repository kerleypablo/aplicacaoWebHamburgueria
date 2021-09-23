using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class TipoServices
    {

        private readonly WebApplication1Context _context;

        public TipoServices(WebApplication1Context context)
        {
            _context = context;
        }

        public List<Tipo> FindAll()
        {
            return _context.Tipo.ToList();
        }

        public void Insert(Tipo tp)
        {
            _context.Add(tp);
            _context.SaveChanges();

        }



    }
}
