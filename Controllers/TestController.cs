using Microsoft.AspNetCore.Mvc;


namespace TwTodos.Controllers;

public class TestController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Teste2()
    {
        return View();
    }
}
