﻿using Curso.Api.Business.Entities;
using Curso.Api.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Curso.Api.Infra.Data
{
    public class CursoDbContext : DbContext
    {
        public CursoDbContext(DbContextOptions<CursoDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Definir as classes a serem utilizadas como modelo
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new CursoMapping());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public object Usuario { get; internal set; }
    }
}

namespace Curso.Api
{
    class prop
    {
    }
}