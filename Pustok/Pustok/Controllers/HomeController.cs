using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok.Data;
using Pustok.Models;
using Pustok.ViewModels;

namespace Pustok.Controllers;

public class HomeController(PustokDbContext dbContext) : Controller
{
    public IActionResult Index()
    {
        HomeVm homeVm = new HomeVm
        {
            Sliders = dbContext.Sliders.ToList(),
            FeaturedBooks = dbContext.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(x => x.IsFeatured).ToList(),

            NewBooks = dbContext.Books
                .Include(x => x.Author)
                .Include(x => x.BookImages)
                .Where(x => x.IsNew).ToList(),

            DiscountedBooks = dbContext.Books
                .Include(x => x.Author)
                .Include(x=>x.BookImages)
                .Where(x=>x.DiscountPercentage>0).ToList()
        };
        return View(homeVm);
    }
    
}