using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MateriaPrima_FornecedorViewModel
    {
        public Fornecedor Fornecedor { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public int FornecedorId { get; set; }
        public int MateriaPrimaId { get; set; }

    }
}
