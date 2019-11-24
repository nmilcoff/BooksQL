using System;
using System.Collections.Generic;

namespace BooksQL.Common
{
    public class Book
    {
        public string ISBN { get; set; }

        public string Title { get; set; }

        public List<string> Authors { get; set; }

        public DateTime PublishDate { get; set; }

        public Genre Genre { get; set; }
    }
}
