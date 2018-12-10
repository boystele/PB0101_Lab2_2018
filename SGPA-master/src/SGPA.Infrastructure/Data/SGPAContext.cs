using Microsoft.EntityFrameworkCore;
using SGPA.ApplicationCore;
using SGPA.ApplicationCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGPA.Infrastructure.Data
{
    public class SGPAContext : DbContext
    {

        public SGPAContext()
        {


        }

        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Passagem> Passagens { get; set; }
        public DbSet<Voo> Voos { get; set; }
        public DbSet<PassagemAerea> PassagensAereas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=BdSGPA;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            // Configurando a entidade Endereco com Fluent API
            modelBuilder.Entity<Endereco>()
               .Property(x => x.Logradouro)
               .HasColumnType("varchar(100)");

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Bairro)
                .HasColumnType("varchar(100)");

            modelBuilder.Entity<Endereco>()
                .Property(x => x.CEP)
                .HasColumnType("varchar(9)");

            modelBuilder.Entity<Endereco>()
                .Property(x => x.Numero)
                .HasColumnType("varchar(4)");



            // Configurando a entidade Grupo com Fluent API
            modelBuilder.Entity<Grupo>()
               .Property(x => x.Descricao)
               .HasColumnType("varchar(100)");



            // Configurando a entidade Voo com Fluent API
            modelBuilder.Entity<Voo>()
               .Property(x => x.Descricao)
               .HasColumnType("varchar(100)");
        }
    }
}