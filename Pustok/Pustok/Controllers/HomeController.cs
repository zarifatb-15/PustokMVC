using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Pustok.Models;

namespace Pustok.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}