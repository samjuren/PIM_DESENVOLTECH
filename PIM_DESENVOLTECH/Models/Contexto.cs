using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using PIM_DESENVOLTECH.Models;

namespace PIM_DESENVOLTECH.Models
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) 
            : base(options) { }

        public DbSet<Login> Login { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<FolhaPonto> FolhaPonto { get; set; }
        public DbSet<DescontosSalariais> descontosSalariais { get; set; }
        public DbSet<RelacaoFerias> RelacaoFerias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Funcionario>()
                .HasIndex(f => f.DescontosId)
                .IsUnique();

            // Outras configurações do modelo...

            base.OnModelCreating(modelBuilder);
        }
    }
}