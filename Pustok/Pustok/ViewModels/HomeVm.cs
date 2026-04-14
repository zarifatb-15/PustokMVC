using System.Collections;
using Pustok.Models;
namespace Pustok.ViewModels;

public class HomeVm : IEnumerable
{
    public List<Slider>Sliders { get; set; }
    
    public List<Book>FeaturedBooks { get; set; }
    
    public List<Book> NewBooks{ get; set; }
    
    public List<Book> DiscountedBooks { get; set; }
    public IEnumerator GetEnumerator()
    {
        throw new NotImplementedException();
    }
}