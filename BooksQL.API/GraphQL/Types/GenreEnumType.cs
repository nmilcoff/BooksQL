using System;
using BooksQL.Common;
using GraphQL.Types;

namespace BooksQL.API.GraphQL.Types
{
    public class GenreEnumType : EnumerationGraphType<Genre>
    {
        public GenreEnumType()
        {
            Name = "Genre";
            Description = "Genre of book";
        }
    }
}
