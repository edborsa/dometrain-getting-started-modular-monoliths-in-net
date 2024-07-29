using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace RiverBooks.Books;

internal interface IBookService
{
    IEnumerable<BookDto> ListBooks();
}

public record BookDto(Guid Id, string Title, string Author);

internal class BookService : IBookService
{
    public IEnumerable<BookDto> ListBooks()
    {
        return
        [
            new BookDto(Guid.NewGuid(), "The fellowship of the ring", "JRR Tokien"),
            new BookDto(Guid.NewGuid(), "The two towers", "JRR Tokien"),
            new BookDto(Guid.NewGuid(), "The return of the King", "JRR Tokien"),
        ];
    }
}

public static class BookEndpoints
{
    public static void MapBookEndpoints(this WebApplication app)
    {
        app.MapGet("/books", (IBookService bookservice) => { return bookservice.ListBooks(); });
    }
}

public static class BookServicesExtensions
{
    public static IServiceCollection AddBookServices(this IServiceCollection services)
    {
        services.AddScoped<IBookService, BookService>();
        return services;
    }
}