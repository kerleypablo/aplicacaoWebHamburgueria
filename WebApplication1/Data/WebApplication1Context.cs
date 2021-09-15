using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class WebApplication1Context : DbContext
    {
        public WebApplication1Context (DbContextOptions<WebApplication1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.MateriaPrima> MateriaPrima { get; set; }
        public DbSet<WebApplication1.Models.Produto> Produto { get; set; }
        public DbSet<WebApplication1.Models.MateriaPrima_Produto> MateriaPrima_Produto { get; set; }
        public DbSet<WebApplication1.Models.Fornecedor> Fornecedor { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MateriaPrima_Produto>().HasKey(al => new { al.MateriaPrimaID, al.ProdutoID });
       }



    }
}
