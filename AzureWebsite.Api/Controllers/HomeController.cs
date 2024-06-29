using AzureWebsite.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureWebsite.Api.Controllers;

//[ApiController]
//[Route("[controller]")]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger){
        _logger = logger;
    }

    public IActionResult Index(IndexVm vm){
        return View(wm);
    }

    /*[HttpGet]
    public IActionResult People(){

    }

    [HttpPost]
    public IActionResult People(){

    }

    public IActionResult Privacy(){
        return View();
    }*/

    /*[ResponceCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error(){
        return View(new ErrorViewModel { Request = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }*/

    /*private readonly ILogger<HomeController> logger;
    private readonly AOrtmanDB db;

    public HomeController(ILogger<HomeController> logger, AOrtmanDB db)
    {
        this.logger = logger;
        this.db = db;
    }

    [HttpGet(Name = "GetPeople")]
    public async Task<IEnumerable<Person>> Get()
    {
        var people = await db.People.ToListAsync();
        return people;
    }*/
}
