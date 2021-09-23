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
        public DbSet<WebApplication1.Models.Fornecedor> Fornecedor { get; set; }
        public DbSet<WebApplication1.Models.Unidade> Unidade { get; set; }
        public DbSet<WebApplication1.Models.Tipo> Tipo { get; set; }
        public DbSet<WebApplication1.Models.Compra> Compra { get; set; }
        public DbSet<WebApplication1.Models.MateriaPrima_ProdutoFormViwModel> Materia_Prooduto { get; set; }
        public DbSet<WebApplication1.Models.MateriaPrima_FornecedorViewModel> Materia_Fornecedor { get; set; }
        public DbSet<WebApplication1.Models.MateriaPrima_ComprasViewModel> Materia_Compras { get; set; }



        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<MateriaPrima_ProdutoFormViwModel>().HasKey(mp => new { mp.MateriaPrimaId, mp.ProdutoId });

            mb.Entity<MateriaPrima_ProdutoFormViwModel>()
               .HasOne(x => x.Produto)
               .WithMany(x => x.MateriasPrimas)
               .HasForeignKey(x => x.MateriaPrimaId);

            mb.Entity<MateriaPrima_FornecedorViewModel>().HasKey(mf => new { mf.MateriaPrimaId, mf.FornecedorId });

            mb.Entity<MateriaPrima_FornecedorViewModel>()
               .HasOne(x => x.MateriaPrima)
               .WithMany(x => x.Fornecedores)
               .HasForeignKey(x => x.FornecedorId);

            mb.Entity<MateriaPrima_ComprasViewModel>().HasKey(mc => new { mc.MateriaPrimaId, mc.CompraId });

            mb.Entity<MateriaPrima_ComprasViewModel>()
               .HasOne(x => x.MateriaPrima)
               .WithMany(x => x.Compras)
               .HasForeignKey(x => x.CompraId);

        }



    }
}
