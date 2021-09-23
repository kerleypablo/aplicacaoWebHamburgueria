using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MateriaPrima_ComprasViewModel
    {
        public Compra Compra { get; set; }
        public MateriaPrima MateriaPrima { get; set; }
        public int MateriaPrimaId { get; set; }
        public int CompraId { get; set; }



    }
}
