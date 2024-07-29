using Ardalis.GuardClauses;

namespace RiverBooks.Books;

internal class Book
{
    public Guid Id { get; private set; } = Guid.NewGuid();
    public  string Title { get; private set; } = String.Empty;
    public string Author { get; set; } = String.Empty;
    public decimal Price { get; set; }
    
    internal Book(Guid id, string title, string author, decimal price)
    {
        Id = Guard.Against.Default(id);
        Title = Guard.Against.NullOrEmpty(title);
        Author = Guard.Against.NullOrEmpty(author);
        Price = Guard.Against.Negative(price);
    }
    
    internal void UpdatePrice(decimal price)
    {
        Price = Guard.Against.Negative(price);
    }
}