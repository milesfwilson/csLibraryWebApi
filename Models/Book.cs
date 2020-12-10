using System.ComponentModel.DataAnnotations;

namespace csApiLibrary.Models
{
  public class Book
  {
    public Book(string title, string author, string description, bool isAvailable)
    {

      Title = title;
      Author = author;
      Description = description;
      IsAvailable = isAvailable;

    }


    public string Title { get; set; }



    public string Author { get; set; }


    public string Description { get; set; }


    public bool IsAvailable { get; set; }

  }
}