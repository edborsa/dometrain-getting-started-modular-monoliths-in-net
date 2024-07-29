namespace RiverBooks.Books;

internal class BookService : IBookService
{
    public List<BookDto> ListBooks()
    {
        return
        [
            new BookDto(Guid.NewGuid(), "The fellowship of the ring", "JRR Tokien"),
            new BookDto(Guid.NewGuid(), "The two towers", "JRR Tokien"),
            new BookDto(Guid.NewGuid(), "The return of the King", "JRR Tokien"),
        ];
    }
}