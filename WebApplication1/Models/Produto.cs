using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public String nome { get; set; }
        public String  Imagem { get; set; }
        public Double preco { get; set; }

        public ICollection<MateriaPrima_ProdutoFormViwModel> MateriasPrimas { get; set; } 
       


       
        

     

       


    }
}
