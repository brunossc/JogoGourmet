using JogoGourmet.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Text;

namespace JogoGourmet.Infra.Data
{
    public class MyDbContext : DbContext
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "EF1001:Internal EF Core API usage.", Justification = "<Pending>")]
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options)
        {
            if (!this.Grupo.Any())
            {
                this.Prato.AddRange(new Prato[] { new Prato() { Nome = "lasanha", GrupoId = 1 }, new Prato() { Nome = "bolo chocolate", GrupoId = 2 } });
                this.Grupo.AddRange(new Grupo[] { new Grupo() { Nome = "massa", Id = 1 }, new Grupo() { Nome = "sobremesa", Id = 2 } });
                this.SaveChanges();
            }
        }

        public DbSet<Prato> Prato { get; set; }
        public DbSet<Grupo> Grupo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
