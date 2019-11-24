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
        public async Task<IEnumerable<Book>> GetBooks()
        {
            var webApiClient = WebApiClientFactory.Get<IBooksApi>("http://localhost:5000");

            var booksResponse = await webApiClient.SendQueryAsync(new Request<BooksResponseModel>());

            return booksResponse.Books;
        }
    }

    public class BooksResponseModel
    {
        public List<Book> Books { get; set; }
    }
}
