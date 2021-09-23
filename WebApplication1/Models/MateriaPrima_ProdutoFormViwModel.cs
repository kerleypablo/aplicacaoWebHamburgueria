using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models
{
    public class MateriaPrima_ProdutoFormViwModel
    {
        public Produto Produto { get; set; }

        public MateriaPrima MateriaPrima { get; set; }

        public int ProdutoId { get; set; }
        public int MateriaPrimaId { get; set; }

      
    }

    


}
