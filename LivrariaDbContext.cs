﻿using Microsoft.EntityFrameworkCore;

namespace EF.Exemplo5;

public class LivrariaDbContext : DbContext
{
    public DbSet<Autor> Autores { get; set; }
    public DbSet<Livro> Livros { get; set; }
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql(@"Host=10.140.67.124;" +
                                 "Username=netuser;" +
                                 "Password=123456;" +
                                 "Database=exemplo4");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Autor>().
            Property(t => t.AutorNome).
            IsRequired().
            HasMaxLength(80);
        modelBuilder.Entity<Livro>().
            Property(t => t.LivroTitulo).
            IsRequired().
            HasMaxLength(120);
    }
}