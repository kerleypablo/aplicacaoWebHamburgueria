using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models.ViewModels
{
    public class MateriaPrima_ProdutoFormViwModel
    {
        public Produto Produto { get; set; }
        public ICollection<MateriaPrima> MateriaPrimas { get; set; }

        public int[] ListaMateriais { get; set; } = new int[10];
    }

    


}
