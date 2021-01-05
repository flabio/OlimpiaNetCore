using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Olimpia.Datas.Models
{
    public partial class OlimpiaDBContext : DbContext
    {
        public OlimpiaDBContext()
        {
        }

        public OlimpiaDBContext(DbContextOptions<OlimpiaDBContext> options)
            : base(options)
        {
        }

     
        public virtual DbSet<ControlAcceso> ControlAccesos { get; set; }
        public virtual DbSet<Estadio> Estadios { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=OlimpiaDB;Integrated Security = true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Latin1_General_CI_AI");

            modelBuilder.Entity<ControlAcceso>(entity =>
            {
                entity.HasKey(e => e.IdControlAcceso);

                entity.ToTable("ControlAcceso");

                entity.Property(e => e.EstadoAcceso).HasMaxLength(50);

                entity.Property(e => e.Fecha).HasColumnType("date");

                entity.HasOne(d => d.IdEstadioNavigation)
                    .WithMany(p => p.ControlAcceso)
                    .HasForeignKey(d => d.IdEstadio)
                    .HasConstraintName("FK_ControlAcceso_Capacidad");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.ControlAccesos)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK_ControlAcceso_Usuario");
            });

            modelBuilder.Entity<Estadio>(entity =>
            {
                entity.HasKey(e => e.IdEstadio);

                entity.ToTable("Estadio");

                entity.Property(e => e.CapacidadMaxima).HasColumnType("numeric(18, 0)");
                entity.Property(e => e.CapacidadPermitida).HasColumnType("numeric(18, 0)");

                entity.Property(e => e.Nombre).HasMaxLength(250);
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.Apellidos).HasMaxLength(250);

                entity.Property(e => e.Celular).HasMaxLength(250);

                entity.Property(e => e.Direccion).HasMaxLength(250);

                entity.Property(e => e.Documento).HasMaxLength(250);

                entity.Property(e => e.Nombre).HasMaxLength(250);

                entity.Property(e => e.TipoDocumento).HasMaxLength(4);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
