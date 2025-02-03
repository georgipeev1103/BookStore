using Microsoft.EntityFrameworkCore;
using BookStore.Models;
using System.Collections.Generic;

namespace BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}

