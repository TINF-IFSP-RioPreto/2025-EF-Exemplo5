namespace EF.Exemplo5;

public class Livro
{
    public int LivroID { get; set; }
    public string LivroTitulo { get; set; }
    public Autor Autor { get; set; }

    public Livro() { }
}