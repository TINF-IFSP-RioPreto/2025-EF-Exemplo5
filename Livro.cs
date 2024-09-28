using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Exemplo5;

public class Livro
{
    public int LivroID { get; set; }
    public string LivroTitulo { get; set; }
    public Autor Autor { get; set; }

    public Livro() { }
}

public class LivroConfiguration : IEntityTypeConfiguration<Livro>
{
    public void Configure(EntityTypeBuilder<Livro> builder)
    {
        builder.Property(t => t.LivroTitulo).HasMaxLength(120).IsRequired();
    }
}