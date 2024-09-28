using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EF.Exemplo5;

public class Autor
{
    public int AutorID { get; set; }
    public string AutorNome { get; set; }
    public ICollection<Livro> Livros { get; set; }

    public Autor() { }
}

public class AutorConfiguration : IEntityTypeConfiguration<Autor>
{
    public void Configure(EntityTypeBuilder<Autor> builder)
    {
        builder.Property(t => t.AutorNome).HasMaxLength(80).IsRequired();
    }
}