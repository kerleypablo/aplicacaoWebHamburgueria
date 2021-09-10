using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MateriaPrima_Produto
    {
        public int IdMateriaPrima { get; set; }
        public int IdProduto { get; set; }

        public MateriaPrima MateriaPrima { get; set; }
        public Produto Produto { get; set; }
    }
}
