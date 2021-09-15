using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models.ViewModels
{
    public class MateriaPrimaFormViwModel
    {
        public MateriaPrima MateriaPrima { get; set; }
        public Fornecedor fornecedor { get; set; }
        public double  quantidade { get; set; }
        public Unidade uni { get; set; }
    }
}
