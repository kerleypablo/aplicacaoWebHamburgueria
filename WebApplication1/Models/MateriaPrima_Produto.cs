using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MateriaPrima_Produto
    {
        public int MateriaPrimaID { get; set; }
        public int ProdutoID { get; set; }

        public MateriaPrima MateriaPrima { get; set; }
        public Produto Produto { get; set; }

        public MateriaPrima_Produto(int materiaPrimaID, int produtoID)
        {
            MateriaPrimaID = materiaPrimaID;
            ProdutoID = produtoID;
        }
    }
}
