using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Producto
    {
        public Producto()
        {
            Detallefactura = new HashSet<Detallefactura>();
            Inventario = new HashSet<Inventario>();
        }

        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Detallefactura> Detallefactura { get; set; }
        public virtual ICollection<Inventario> Inventario { get; set; }
    }
}
