using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Detallefactura
    {
        public int Id { get; set; }
        public string CodProducto { get; set; }
        public int? Cantidad { get; set; }
        public decimal? PrecioUnitario { get; set; }
        public decimal? PrecioTotalReg { get; set; }

        public virtual Producto CodProductoNavigation { get; set; }
    }
}
