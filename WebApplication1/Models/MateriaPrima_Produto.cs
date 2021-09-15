using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models
{
    public class MateriaPrima_Produto
    {
        public int MateriaPrimaID { get; set; }
        public int ProdutoID { get; set; }

        public double Quantidade { get; set; }
        public Unidade Unidade { get; set; }

        public MateriaPrima MateriaPrima { get; set; }
        public Produto Produto { get; set; }

        public MateriaPrima_Produto(int materiaPrimaID, int produtoID , double quantidade , Unidade unidade)
        {
            MateriaPrimaID = materiaPrimaID;
            ProdutoID = produtoID;
            Quantidade = quantidade;
            Unidade = unidade;
        }
    }
}
