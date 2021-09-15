

using System;
using System.Collections.Generic;
using WebApplication1.Models.Enums;

namespace WebApplication1.Models
{
    public class MateriaPrima
    {
        public int Id { get; set; }
        public String Nome  { get; set; }

        public double  quantidade { get; set; }
        public double VlrUnitario { get; set; }

        public Unidade uni { get; set; }

        public Fornecedor FornecedorId { get; set; }

        public MateriaPrima()
        {
        }

        public MateriaPrima(int id, string nome, double quantidade, Unidade uni,double vlrUnitario,Fornecedor fornecedorId)
        {
            Id = id;
            Nome = nome;
            this.quantidade = quantidade;
            this.uni = uni;
            this.VlrUnitario = vlrUnitario;
            this.FornecedorId = fornecedorId;
        }
    }
}
