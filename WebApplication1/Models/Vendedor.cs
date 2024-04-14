using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Vendedor
    {
        public Vendedor()
        {
            Factura = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public string Nombres { get; set; }
        public string Cargo { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
