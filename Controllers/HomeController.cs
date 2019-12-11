using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestMvcOfType.Controllers
{
  public class HomeController : Controller
  {
    private readonly ILogger<HomeController> _logger;
    private readonly SchoolContext _context;

    public HomeController(ILogger<HomeController> logger, SchoolContext context)
    {
      _logger = logger;
      _context = context;
    }

    [HttpGet("/persons")]
    public IActionResult Index()
    {
      return Ok(_context.SchoolClasses.SelectMany(x => x.Persons).ToList());
    }



    [HttpGet("/students")]
    public IActionResult Students()
    {
      // if you pass a SchoolClassId you can check if this SchoolClass exists and throw a 404 _anyway_
      return Ok(_context.Students);
    }

    [HttpGet("/teachers")]
    public IActionResult Teachers()
    {
      return Ok(_context.Teachers);
    }
  }
}
