using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public String  Nome { get; set; }
        public String Telefone { get; set; }
        public String Contato { get; set; }

        public Fornecedor()
        {
        }

        public Fornecedor(int id, string nome, String telefone, String contato)
        {
            Id = id;
            Nome = nome;
            Telefone = telefone;
            Contato = contato;
        }
    }
}
