using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using MVCwebAppBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCwebAppBook.Models
{
    public class Seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookContext(
                serviceProvider.GetRequiredService<DbContextOptions<BookContext>>()))
            {
                if(context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book { BTitle = "INdian short  stories",
                        Category = "fiction",
                        Price=600,
                        AuthorName="Narayan",
                        Publisher="Pengwin",
                        Releasedate=Convert.ToDateTime("02-15-2019")
                    },
                    new Book
                    {
                        BTitle = " short  stories",
                        Category = "crime",
                        Price = 600,
                        AuthorName = "Ravi",
                        Publisher = "Pengwin",
                        Releasedate = Convert.ToDateTime("02-19-2014")
                    });
                context.SaveChanges();
                   
            }
        }
    }
}
