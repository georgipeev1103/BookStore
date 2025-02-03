using BookStore.Models;
using BookStore.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Business
{
    public class BookBusinessService : IBookBusinessService
    {
        private readonly IBookService _service;

        public BookBusinessService(IBookService service)
        {
            _service = service;
        }

        public async Task<BookDto?> GetBookDetailsAsync(int id)
        {
            var book = await _service.GetBookByIdAsync(id);
            return book is null ? null : new BookDto { Id = book.Id, Title = book.Title };
        }


        public async Task<IEnumerable<BookDto>> GetAllBookDetailsAsync()
        {
            var books = await _service.GetAllBooksAsync();
            return books.Select(b => new BookDto { Id = b.Id, Title = b.Title });
        }
    }
}

