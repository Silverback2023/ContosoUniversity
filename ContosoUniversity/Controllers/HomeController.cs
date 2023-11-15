using Microsoft.AspNetCore.Mvc;
using ContosoUniversity.Data;

public class HomeController : Controller
{
    private readonly SchoolContext _context;

    public HomeController(SchoolContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        
        return View();
    }
}
