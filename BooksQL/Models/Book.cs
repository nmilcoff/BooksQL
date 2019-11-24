using System;
using System.Collections.Generic;

namespace BooksQL.Models
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public List<string> Authors { get; set; }
    }
}
