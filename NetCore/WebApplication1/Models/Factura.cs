using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Factura
    {
        public int Id { get; set; }
        public DateTime? FecCreacion { get; set; }
        public int? IdCliente { get; set; }
        public int? IdVendedor { get; set; }
        public decimal? ValorTotal { get; set; }

        public virtual Cliente IdClienteNavigation { get; set; }
        public virtual Vendedor IdVendedorNavigation { get; set; }
    }
}
