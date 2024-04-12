using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using testDeploy.BLL.Services;
using testDeploy.Domain.Models;

namespace testDeploy2.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly BookService _bookService;

        public BookController(BookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Book> books = _bookService.GetAll();
            return Ok(books);
        }

        [HttpGet("{isbn}")]
        public IActionResult GetByISBN([FromRoute] string isbn)
        {
            try
            {
                Book book = _bookService.GetByISBN(isbn);
                return Ok(book);
            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] Book book)
        {
            _bookService.Add(book);
            return NoContent();
        }

        [HttpPatch("{isbn}")]
        public IActionResult Update([FromRoute] string isbn, [FromBody] Book book)
        {
            try
            {
                _bookService.Update(isbn, book);
                return NoContent();
            }
            catch (KeyNotFoundException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //[HttpDelete("{isbn}")]
        //public IActionResult Delete([FromRoute] string isbn)
        //{
        //    try
        //    {
        //        _bookService.Delete(isbn);
        //        return NoContent();
        //    }
        //    catch (KeyNotFoundException ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }
        //}
    }
}
