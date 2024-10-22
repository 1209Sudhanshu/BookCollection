using BookCollection.Data;
using BookCollection.Model;
using BookCollection.Model.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace BookCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly Application_DbContext dbContext;

        public BookController(Application_DbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        [HttpGet]
        public IActionResult GetAllBook()
        {
            var allBooks = dbContext.Books.ToList();

            return Ok(allBooks);
        }

        [HttpGet]
        [Route("{id:guid}")]

        public IActionResult GetBookById(Guid id)
        {
            var book = dbContext.Books.Find(id);

            if(book is null)
            {
                return NotFound();
            }

            return Ok(book);
        }

        [HttpPost]

        public IActionResult AddBooks(Add_Book_Dto addBookdto)
        {
            var bookEntity = new Book()
            {
                Title = addBookdto.Title,
                Author = addBookdto.Author,
                PublishedDate = addBookdto.PublishedDate,
                Genre = addBookdto.Genre
            };

            dbContext.Books.Add(bookEntity);
            dbContext.SaveChanges();

            return Ok(bookEntity);

        }

        [HttpPut]
        [Route("{id:guid}")]

        public IActionResult UpdateBook(Guid id, UpdateBookDto updateBookDto)
        {
            var Book = dbContext.Books.Find(id);
            if(Book is null)
            {
                return NotFound();
            }


            Book.Title = updateBookDto.Title;
            Book.Author = updateBookDto.Author;
            Book.PublishedDate = updateBookDto.PublishedDate;
            Book.Genre = updateBookDto.Genre;

            dbContext.SaveChanges();
            return Ok(Book);
        }

        [HttpDelete]
        [Route("{id:guid}")]

        public IActionResult DeleteBook(Guid id)
        {
            var book = dbContext.Books.Find(id);
            if (book is null)
            {
                return NotFound();
            }

            dbContext.Books.Remove(book);
            dbContext.SaveChanges();
            return Ok(book);
        }

        
    }
}