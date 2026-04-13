using System.ComponentModel.DataAnnotations;

namespace Pustok.Models;

public class Book
{
    public int Id { get; set; }

    [MaxLength(150)]
    public string Name { get; set; } = null!;

    [MaxLength(500)]
    public string Description { get; set; } = null!;
    
    public decimal DiscountPercent { get; set; }
    
    public decimal Price { get; set; }

    [MaxLength(50)]
    public string Code { get; set; } = null!;
    
    public bool InStock { get; set; }
    
    public bool IsFeatured {get;set;}
    
    public bool IsNew {get;set;}

    [MaxLength(256)]
    public string MainImageUrl { get; set; } = null!;
    
    [MaxLength(256)]
    public string HoverImageUrl { get; set; } = null!;
    
    public int AuthorId { get; set; }

    public Author Author { get; set; } = null!;

    public ICollection<BookImage> BookImages { get; set; } = new List<BookImage>();
}