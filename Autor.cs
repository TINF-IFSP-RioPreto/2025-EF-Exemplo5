namespace EF.Exemplo5;

public class Autor
{
    public int AutorID { get; set; }
    public string AutorNome { get; set; }
    public ICollection<Livro> Livros { get; set; }

    public Autor() { }
}