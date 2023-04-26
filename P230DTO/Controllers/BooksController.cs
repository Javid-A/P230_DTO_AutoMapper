using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using P230DTO.DAL;
using P230DTO.DTOs;
using P230DTO.Entities;

namespace P230DTO.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly LibraryDbContext _context;
        private readonly IMapper _map;

        public BooksController(LibraryDbContext context,IMapper map)
        {
            _context = context;
            _map = map;
        }
        [HttpGet("")]
        public IActionResult GetAll()
        {
            //IEnumerable<BookGetDTO> books = _context.Books.Select(b =>
            //new BookGetDTO
            //{
            //    Id = b.Id,
            //    Name = b.Name,
            //    Desc = b.Desc,
            //    Price = b.Price,
            //    Pages = b.Pages,
            //    ReleaseDate = b.ReleaseDate
            //}).AsEnumerable();
            var books = _context.Books.AsEnumerable();
            IEnumerable<BookGetDTO> bookDto = _map.Map<IEnumerable<BookGetDTO>>(books);
            return Ok(bookDto);
        }
        [HttpGet("get/{id}")]
        public IActionResult Get(int id)
        {
            if (id == 0) return BadRequest();
            Book? book = _context.Books.FirstOrDefault(b => b.Id == id);
            if (book is null) return NotFound();
            BookGetDTO bookDto = _map.Map<BookGetDTO>(book);
            return Ok(bookDto);
        }

        [HttpPost("create")]
        public IActionResult Create(BookPostDTO bookDto)
        {
            Book book = _map.Map<Book>(bookDto);
            _context.Books.Add(book);
            _context.SaveChanges();

            return Ok(new
            {
                Status = "Successfuly created",
                book.Id
            });
        }

        [HttpPut("update/{id}")]
        public IActionResult Update(int id,BookPutDTO bookDto)
        {
            if (id == 0) return BadRequest();
            Book? book = _context.Books.FirstOrDefault(b=>b.Id==id);//Unchanged
            //_context.Books.Attach(book);
            if (book == null) return NotFound();
            Book changedBook = _map.Map<Book>(bookDto);//Detached
            _context.Entry(book).CurrentValues.SetValues(changedBook);//Unchanged ==> Modified
            #region Without Auto Map
            //book.Name = bookDto.Name;
            //book.Price = bookDto.Price;
            //book.Desc = bookDto.Desc;
            //book.Pages = bookDto.Pages;
            //book.AuthorId = bookDto.AuthorId;
            //book.ReleaseDate = bookDto.ReleaseDate; 
            #endregion
            _context.SaveChanges();
            return NoContent();
        }
    }
}
