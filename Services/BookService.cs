using System;
using System.Collections.Generic;
using csApiLibrary.DB;
using csApiLibrary.Models;

namespace csApiLibrary.Services
{
  public class BookService
  {
    public BookService()
    {

    }

    public IEnumerable<Book> GetAll()
    {
      return FakeDB.Books;
    }

    public Book Create(Book newBook)
    {
      FakeDB.Books.Add(newBook);
      return newBook;
    }

    public string Delete(int index)
    {
      FakeDB.Books.RemoveAt(index);
      return "Deleted";
    }

    public IEnumerable<Book> Edit(Book editedBook, int index)
    {
      if (index < FakeDB.Books.Count && index > -1)
      {
        FakeDB.Books[index] = editedBook;
        return FakeDB.Books;
      }
      return null;
    }

    public Book GetOne(int index)
    {
      if (index < FakeDB.Books.Count && index > -1)
      {

        return FakeDB.Books[index];
      }
      return null;
    }
  }
}