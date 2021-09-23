using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime Datacompra { get; set; }
        public ICollection<MateriaPrima_ComprasViewModel> MateriasPrimas { get; set; }
    }
}
