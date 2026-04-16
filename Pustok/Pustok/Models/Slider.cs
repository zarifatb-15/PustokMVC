using Pustok.Models.Common;

namespace Pustok.Models;

public class Slider:BaseEntity
{
   public string ImageUrl { get; set; }
   public string Title { get; set; } 
   public string ButtonUrl { get; set; }
   public string ButtonText { get; set; }
   public string Description { get; set; }
   
}