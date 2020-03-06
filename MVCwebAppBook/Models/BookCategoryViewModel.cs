using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCwebAppBook.Models
{
    public class BookCategoryViewModel
    {
        public List<Book> Books { get; set; }
        public SelectList Categories { get; set; }
        public SelectList Publishers { get; set; }
        public string BookCategory { get; set; }
        public string Searchstr { get; set; }
        public string Publisherdet { get; set; }
    }
}
