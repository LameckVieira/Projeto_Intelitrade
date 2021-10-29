using Flunt.Notifications;
using Intelitrader.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelitrader.Infa.Data.Contexts
{
    public class IntelitraderContext : DbContext
    {

        // Passamos o argumento do options que será definido posteriormente la na minha Startup da API
        public IntelitraderContext(DbContextOptions<IntelitraderContext> options) : base(options)
        {

        }

        // Declarar quais são as tabelas que nós vamos criar, com dbset
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Vaga> Vaga { get; set; }
        public DbSet<TipoVaga> TipoVaga { get; set; }

        // Modelamos como que as tabelas devem ficar

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<Notification>();

            #region mapeamento da tabela de Usuario

            modelBuilder.Entity<Usuario>().ToTable("Usuario");

            // Determinar chaves

            modelBuilder.Entity<Usuario>().Property(x => x.Id);

            // Nome

            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasMaxLength(40);
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).HasColumnType("Varchar(40)");
            modelBuilder.Entity<Usuario>().Property(x => x.Nome).IsRequired();

            // Email

            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasMaxLength(60);
            modelBuilder.Entity<Usuario>().Property(x => x.Email).HasColumnType("Varchar(60)");
            modelBuilder.Entity<Usuario>().Property(x => x.Email).IsRequired();

            // Senha

            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasMaxLength(200);
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).HasColumnType("Varchar(200)");
            modelBuilder.Entity<Usuario>().Property(x => x.Senha).IsRequired();

            // DataCriação

            modelBuilder.Entity<Usuario>().Property(x => x.DataCriacao).HasColumnType("DateTime");

            // Telefone

            modelBuilder.Entity<Usuario>().Property(x => x.Telefone).HasMaxLength(18);
            modelBuilder.Entity<Usuario>().Property(x => x.Telefone).HasColumnType("Varchar(18)");
            modelBuilder.Entity<Usuario>().Property(x => x.Telefone).IsRequired();

            // CPF

            modelBuilder.Entity<Usuario>().Property(x => x.CPF).HasMaxLength(18);
            modelBuilder.Entity<Usuario>().Property(x => x.CPF).HasColumnType("Varchar(18)");
            modelBuilder.Entity<Usuario>().Property(x => x.CPF).IsRequired();
            #endregion
           
            base.OnModelCreating(modelBuilder);
        }
    }
}
