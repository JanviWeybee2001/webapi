using authentication.Model;
using BookStore.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace authentication.Repository
{
    public class BookRepository : IBookRepository
    {

        private readonly BookStoreContext _context;

        public BookRepository(BookStoreContext context)
        {
            _context = context;
        }
        public async Task<List<Books>> getAllBook()
        {
            return _context.Books.ToList<Books>();
            //var book = new List<BookModel>();
            //var allbooks = await _context.Books.ToListAsync();
            //if (allbooks?.Any() == true)
            //{
            //    foreach (var books in allbooks)
            //    {
            //        book.Add(new BookModel()
            //        {
            //            id = books.id,
            //            Title = books.Title
            //        });
            //    }
            //}
            //return book;
        }

        public async Task<Books> getBookByid(int id)
        {
            return await _context.Books.FindAsync(id);
        }
    }
}
