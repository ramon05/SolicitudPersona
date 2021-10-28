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
            base.OnModelCreating(modelBuilder);
        }

    }
}
