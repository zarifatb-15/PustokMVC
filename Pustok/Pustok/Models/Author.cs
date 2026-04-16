using System.ComponentModel.DataAnnotations;
using Pustok.Models.Common;

namespace Pustok.Models;

public class Author:BaseEntity
{
    [Required]
    [MaxLength(25)]
    public string FullName { get; set; } = null!;
     
    public List<Book> Books { get; set; }
   
}