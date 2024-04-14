using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Cliente
    {
        public Cliente()
        {
            Factura = new HashSet<Factura>();
        }

        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public bool? Estado { get; set; }

        public virtual ICollection<Factura> Factura { get; set; }
    }
}
