using authentication.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authentication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository; 
        }

        [HttpGet("/books")]
        public async Task<IActionResult> getAllBook()
        {
            var books = await _bookRepository.getAllBook();
            return Ok(books);
        }

        [HttpGet("getbook/{id}")]
        public async Task<IActionResult> getBookById([FromRoute] int id)
        {
            var book = await _bookRepository.getBookByid(id);
            if(book==null)
            {
                return NotFound();
            }
            return Ok(book);
        }
    }
}
