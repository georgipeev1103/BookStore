using BookStore.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BookStore.Business
{
    public interface IBookBusinessService
    {
        Task<BookDto?> GetBookDetailsAsync(int id); 
    }

}

