using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Inventario
    {
        public int Id { get; set; }
        public string CodProducto { get; set; }
        public decimal? CantInicial { get; set; }
        public decimal? CantSalida { get; set; }
        public decimal? Stock { get; set; }
        public decimal? PrecioVenta { get; set; }

        public virtual Producto CodProductoNavigation { get; set; }
    }
}
