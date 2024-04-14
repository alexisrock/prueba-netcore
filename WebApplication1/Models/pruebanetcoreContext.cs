using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class pruebanetcoreContext : DbContext
    {
        public pruebanetcoreContext()
        {
        }

        public pruebanetcoreContext(DbContextOptions<pruebanetcoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Detallefactura> Detallefactura { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Inventario> Inventario { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<Vendedor> Vendedor { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-G58E8B1\\ALEXISDESARROLLA;Initial Catalog=pruebanetcore;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellidos)
                    .HasColumnName("apellidos")
                    .HasMaxLength(50);

                entity.Property(e => e.Direccion)
                    .HasColumnName("direccion")
                    .HasMaxLength(50);

                entity.Property(e => e.Documento)
                    .HasColumnName("documento")
                    .HasMaxLength(50);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .HasColumnName("nombre")
                    .HasMaxLength(50);

                entity.Property(e => e.Telefono)
                    .HasColumnName("telefono")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Detallefactura>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cantidad).HasColumnName("cantidad");

                entity.Property(e => e.CodProducto)
                    .HasColumnName("cod_producto")
                    .HasMaxLength(50);

                entity.Property(e => e.PrecioTotalReg)
                    .HasColumnName("Precio_total_reg")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PrecioUnitario)
                    .HasColumnName("precio_unitario")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CodProductoNavigation)
                    .WithMany(p => p.Detallefactura)
                    .HasForeignKey(d => d.CodProducto)
                    .HasConstraintName("FK__Detallefa__cod_p__1ED998B2");
            });

            modelBuilder.Entity<Factura>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdCliente).HasColumnName("id_cliente");

                entity.Property(e => e.IdVendedor).HasColumnName("id_vendedor");

                entity.Property(e => e.NumFactura).HasColumnName("numFactura");

                entity.Property(e => e.ValorTotal)
                    .HasColumnName("valor_total")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.IdClienteNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.IdCliente)
                    .HasConstraintName("FK__Factura__id_clie__1B0907CE");

                entity.HasOne(d => d.IdVendedorNavigation)
                    .WithMany(p => p.Factura)
                    .HasForeignKey(d => d.IdVendedor)
                    .HasConstraintName("FK__Factura__id_vend__1BFD2C07");
            });

            modelBuilder.Entity<Inventario>(entity =>
            {
                entity.ToTable("inventario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CantInicial)
                    .HasColumnName("cant_inicial")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CantSalida)
                    .HasColumnName("cant_salida")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CodProducto)
                    .HasColumnName("cod_producto")
                    .HasMaxLength(50);

                entity.Property(e => e.PrecioVenta)
                    .HasColumnName("precio_venta")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Stock)
                    .HasColumnName("stock")
                    .HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.CodProductoNavigation)
                    .WithMany(p => p.Inventario)
                    .HasForeignKey(d => d.CodProducto)
                    .HasConstraintName("FK__inventari__cod_p__182C9B23");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.HasKey(e => e.Codigo)
                    .HasName("PK__Producto__40F9A207D3D09BD9");

                entity.Property(e => e.Codigo)
                    .HasColumnName("codigo")
                    .HasMaxLength(50);

                entity.Property(e => e.Descripcion).HasMaxLength(100);
            });

            modelBuilder.Entity<Vendedor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Cargo)
                    .HasColumnName("cargo")
                    .HasMaxLength(50);

                entity.Property(e => e.Estado)
                    .HasColumnName("estado")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombres)
                    .HasColumnName("nombres")
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
