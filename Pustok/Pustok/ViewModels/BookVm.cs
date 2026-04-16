namespace Pustok.ViewModels;
using Pustok.Models;

public class BookVm
{
    public Book Book { get; set; }
     public List<Book>RelatedBooks { get; set; }
}