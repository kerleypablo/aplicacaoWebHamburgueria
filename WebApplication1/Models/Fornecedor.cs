using System;
using System.Collections.Generic;


namespace WebApplication1.Models
{
    public class Fornecedor
    {
        public int FornecedorId { get; set; }
        public String  Nome { get; set; }
        public String Telefone { get; set; }
        public String Contato { get; set; }

        public ICollection<MateriaPrima_FornecedorViewModel> MateriasPrimas { get; set; }

      
       
    }
}
