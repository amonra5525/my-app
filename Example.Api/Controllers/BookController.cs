﻿using Example.Api.Dto;
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

    [HttpDelete("DeleteBooks")]
    public async Task<List<Book>> DeleteBooks()
    {
        var books = new List<Book>
        {

            new Book { Name = "Shine", Price = 7, Author = "Stephen King" },
            new Book { Name = "Pet Sematary", Price = 4, Author = "Leo Tolstoy" },
            new Book { Name = "The Count of Monte Cristo", Price = 5, Author = "Alexandre Dumas" }

        };
        if (books.Any())
        {

            books.RemoveAt(2);
        }

        return books;
    }

    [HttpPost("AddBook")]
    public async Task<Book> AddBook()
    {
        var books = new List<Book>
        {
            new Book { Name = "Shine", Price = 15, Author = "Jack London" },
            new Book { Name = "Pet Sematary", Price = 4, Author = "Leo Tolstoy" },
            new Book { Name = "The Count of Monte Cristo", Price = 5, Author = "Leo Tolstoy" }
        };
        var newbook = new Book {Name = "Warcraft", Price = 7, Author = "Blizzard" };
        books.Add(newbook);
        return newbook;
    }

    [HttpPut("UpdateBook")]
    public async Task<List<Book>> UpdateBook()
    {
        var books = new List<Book>
        {
            new Book { Name = "Shine", Price = 15, Author = "Jack London" },
            new Book { Name = "Pet Sematary", Price = 4, Author = "Leo Tolstoy" }
        };
        var updatedBooks = books.Where(b => !(b.Name == "Shine" && b.Price == 15 && b.Author == "Jack London")).ToList();
        return updatedBooks;
    }
}   
        
        
    


      
        
    
        
        
        
        
    
        
        
    
