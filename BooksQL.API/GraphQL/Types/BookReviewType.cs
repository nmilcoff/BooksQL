using System;
using BooksQL.Common;
using GraphQL.Types;

namespace BooksQL.API.GraphQL.Types
{
    public class BookReviewType : ObjectGraphType<BookReview>
    {
        public BookReviewType()
        {
            Field(t => t.BookISBN);
            Field(t => t.Id);
            Field(t => t.Review);
        }
    }
}
