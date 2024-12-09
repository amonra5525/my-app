using Example.Api.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Example.Api.Controllers;

// подсказки
// не должно быть одинаковых маршрутов!

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    [HttpGet("GetBooks")]
    public async Task<List<Book>> GetBooks()
    {
        var books = new List<Book>();
        books.Add(new Book
        {
            Name = "Martin Iden",
            Price = 15,
            Author = "Jack London"
        });

        return books;
    }
}