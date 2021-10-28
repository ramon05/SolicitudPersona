using Microsoft.EntityFrameworkCore;
using SolicitudApi.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SolicitudApi.Model.DataContext
{
    public partial class SolicitudDbContext : BaseDbContext
    {
        public SolicitudDbContext(DbContextOptions<SolicitudDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public DbSet<Solicitude> Solicitudes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("Persona");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.Name)
                      .HasColumnName("Nombre");

                entity.Property(e => e.LastName)
                      .HasColumnName("Apellido");

                entity.Property(e => e.Bob)
                      .HasColumnName("FechaNacimiento");

                entity.Property(e => e.Passport)
                      .HasColumnName("Pasaporte");

                entity.Property(e => e.Direction)
                      .HasColumnName("Direccion");

                entity.Property(e => e.Gender)
                      .HasColumnName("Genero");

                entity.Property(e => e.PhotoId)
                      .HasColumnName("Foto");

                entity.Property(e => e.SolicitudeId)
                      .HasColumnName("SolicitudId");
            });

            modelBuilder.Entity<Solicitude>(entity =>
            {
                entity.ToTable("Solicitud");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.StatusName)
                      .HasColumnName("NombreEstado");

                entity.Property(e => e.CreadDate)
                      .HasColumnName("FechaCreacion");

            });

            modelBuilder.Entity<Team>(entity =>
            {
                entity.ToTable("Equipo");

                entity.HasKey(e => e.Id);

                entity.Property(e => e.PersonId)
                      .HasColumnName("PersonaId");

                entity.Property(e => e.Status)
                      .HasColumnName("Estado");

                entity.Property(e => e.CreadDate)
                      .HasColumnName("FechaCreacion");

            });


            base.OnModelCreating(modelBuilder);
        }

    }
}
