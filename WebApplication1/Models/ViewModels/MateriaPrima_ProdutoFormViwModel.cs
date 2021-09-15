using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models.ViewModels
{
    public class MateriaPrima_ProdutoFormViwModel
    {
        public Produto Produto { get; set; }
        public ICollection<MateriaPrima> MateriaPrimas { get; set; }
        public Unidade unidade { get; set; }
        public double quantidade { get; set; }
        
        public Fornecedor fornecedor { get; set; }
        

        public int[] ListaMateriais { get; set; } = new int[10];
    }

    


}
