using System.Collections.Generic;
using csApiLibrary.Models;
using csApiLibrary.Services;
using Microsoft.AspNetCore.Mvc;

namespace csApiLibrary.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class BookController : ControllerBase
  {
    private readonly BookService _bs;
    public BookController(BookService bs)
    {
      _bs = bs;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Book>> Get()
    {
      try
      {
        return Ok(_bs.GetAll());
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }
    [HttpGet("{index}")]
    public ActionResult<Book> GetOne(int index)
    {
      try
      {
        return Ok(_bs.GetOne(index));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    [HttpPost]
    public ActionResult<Book> Create([FromBody] Book newBook)
    {
      try
      {
        return Ok(_bs.Create(newBook));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    [HttpDelete("{index}")]
    public ActionResult<string> Delete(int index)
    {
      try
      {
        return Ok(_bs.Delete(index));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }

    [HttpPut("{index}")]
    public ActionResult<IEnumerable<Book>> Edit([FromBody] Book editedBook, int index)
    {
      try
      {
        return Ok(_bs.Edit(editedBook, index));
      }
      catch (System.Exception error)
      {
        return BadRequest(error.Message);
      }
    }
  }
}