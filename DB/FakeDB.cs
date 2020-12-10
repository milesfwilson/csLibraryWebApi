using System.Collections.Generic;
using csApiLibrary.Models;

namespace csApiLibrary.DB
{
  public static class FakeDB
  {

    public static List<Book> Books { get; set; } = new List<Book>() {
new Book("Dune", "Frank Herbert", "Science Fiction", true),
new Book("Harry Potter", "J.K. Rowling", "Whimsical Fantasy", true),
new Book("Garden City", "John Mark Comer", "Christian Theology", true),
new Book("Fellowship of the Ring", "J.R.R. Tolkien", "Fantasy", true)
    };

  }
}