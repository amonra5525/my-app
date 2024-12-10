using Example.Api.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Example.Api.Controllers;

// подсказки
// не должно быть одинаковых маршрутов!
// задание:
// напиши по аналогии функции для всех методов rest api с любым функционалом на тематику book и сделай название как у моего метода, по аналогии

[ApiController]
[Route("api/books")]
public class BooksController : ControllerBase
{
    [HttpGet("GetBooks")] // Http GET
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

    [HttpDelete("DeleteBooks/{Price}")]
    public async Task<List<Book>> DeleteBooks(int price)
    {
        var books = new List<Book>();
        books.Add(new Book()
        {
            Name = "Martin Iden",
            Price = 15,
            Author = "Jack London"
        });
        return books;
    }
}