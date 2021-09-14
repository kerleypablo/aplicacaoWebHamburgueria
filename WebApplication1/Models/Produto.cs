using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Produto
    {
        public int ID { get; set; }
        public String nome { get; set; }
        public String  Imagem { get; set; }
        public Double preco { get; set; }

        public ICollection<MateriaPrima> MateriasPrima { get; set; } = new List<MateriaPrima>();
       


        public Produto()
        {
        }

        public Produto(int iD, string nome, string imagem, double preco)
        {
            ID = iD;
            this.nome = nome;
            Imagem = imagem;
            this.preco = preco;
        }

        public void addMetriaPrima (MateriaPrima mt)
        {
            MateriasPrima.Add(mt);
        }

        public void RemoveMateriaPrima(MateriaPrima mt)
        {
            MateriasPrima.Remove(mt);
        }

        public double TotalparaProducao()
        {
            return MateriasPrima.Sum(sr => sr.VlrUnitario);
        }


    }
}
