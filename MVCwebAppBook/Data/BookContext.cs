using Microsoft.EntityFrameworkCore;
using MVCwebAppBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCwebAppBook.Data
{
    public class BookContext:DbContext
    {
        public BookContext(DbContextOptions<BookContext> options):base( options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
