

using System;
using System.Collections.Generic;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models
{
    public class MateriaPrima
    {
        public int MateriaPrimaId { get; set; }
        public String Nome  { get; set; }

        public double  quantidade { get; set; }
        public double VlrUnitario { get; set; }

        public Unidade uni { get; set; }

        public ICollection<MateriaPrima_FornecedorViewModel> Fornecedores { get; set; }
        public ICollection<MateriaPrima_ProdutoFormViwModel> produtos { get; set; }
        public ICollection<MateriaPrima_ComprasViewModel> Compras { get; set; }
        public Tipo TipoId { get; set; }


      
    
    }
}
