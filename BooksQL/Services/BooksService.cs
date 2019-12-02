using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BooksQL.ApiEndpoints;
using BooksQL.Models;
using Xablu.WebApiClient;
using Xablu.WebApiClient.Services.GraphQL;

namespace BooksQL.Services
{
    public class BooksService
    {
        private readonly IWebApiClient<IBooksApi> _webApiClient;

        public BooksService()
        {
            _webApiClient = WebApiClientFactory.Get<IBooksApi>("http://localhost:5000");
        }

        public async Task<IEnumerable<Book>> GetBooks()
        { 
            var booksResponse = await _webApiClient.SendQueryAsync(new Request<BooksResponseModel>());

            return booksResponse.Books;
        }

        //public async Task CreateReview()
        //{
        //   var result = await _webApiClient.SendMutationAsync<BookReview>(
        //       "mutation ($review: reviewInput!) { createReview(review: $review) { id review } }",
        //       new { review = new { bookISBN = "0544272994", review = "This is a mutation test" } });
        //}
    }

    public class BooksResponseModel
    {
        public List<Book> Books { get; set; }
    }
}
