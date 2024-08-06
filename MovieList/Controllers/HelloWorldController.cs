using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MovieList.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    public IActionResult Welcome(string name, int numTimes = 1, int age = 0)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        ViewData["Age"] = age;
        return View();
    }
}