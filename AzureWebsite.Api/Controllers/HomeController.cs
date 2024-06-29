using AzureWebsite.Api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AzureWebsite.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class HomeController : ControllerBase
{
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
