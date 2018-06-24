using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ViaVarejo.Domain.Entity;

namespace ViaVarejo.Infra.Config
{
    public class ContextBase : DbContext
    {
        public ContextBase(DbContextOptions<ContextBase> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Friend> Friend { get; set; }
        public DbSet<Log> Log { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Friend>(entity =>
           {
               entity.HasKey(k => k.Id);
           });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasKey(k => k.Id_Historico);
            });
        }
    }
}
