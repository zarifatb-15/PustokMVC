using Pustok.Models.Common;

namespace Pustok.Models;

public class BookImage:BaseEntity
{

    public string Image{ get; set; }
    
    public Guid BookId { get; set; }

    public Book Book { get; set; } = null!;
}