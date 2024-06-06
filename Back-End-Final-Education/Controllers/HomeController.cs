using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Back_End_Final_Education.Models;

namespace Back_End_Final_Education.Controllers;

public class HomeController : Controller
{
  
    public IActionResult Index()
    {
        return View();
    }

  
}

