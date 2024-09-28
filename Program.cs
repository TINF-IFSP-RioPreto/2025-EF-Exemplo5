using EF.Exemplo5;

using (var db = new LivrariaDbContext())
{
    // var autor = new Autor();
    // autor.AutorNome = "Le Guin, U. K.";
    //
    // var livro = new Livro();
    // livro.LivroTitulo = "O Feitiço de terramar";
    // livro.Autor = autor;
    //
    // db.Livros.Add(livro);
    // db.Autores.Add(autor);
    // db.SaveChanges();

    var livro = db.Livros.First();
    Console.WriteLine($"O primeiro livro é {livro.LivroTitulo}");

}