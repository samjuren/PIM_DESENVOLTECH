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
    }
}