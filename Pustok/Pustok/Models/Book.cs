namespace Pustok.Models;

public class Book
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;
    
    public string Title { get; set; } = null!;
    
    public string AuthorId { get; set; } = null!;
    
    public Author Author { get; set; } = null!;
    
}