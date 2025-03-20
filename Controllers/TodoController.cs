using Microsoft.AspNetCore.Mvc;
using TwTodos.Contexts;
using TwTodos.Models;

namespace TwTodos.Controllers;
public class TodoController : Controller
{
    private readonly TwTodosContext _context;

    public TodoController(TwTodosContext context)
    {
        _context = context;
    }
    public IActionResult Index()
    {
        //passe apenas valores simples (como strings!) para a ViewData
        //para valores complexos (como objetos), passe como parâmetro da View
        ViewData["Title"] = "Lista de tarefas";
        var todos = _context.Todos.ToList();
        return View(todos);
    }

    public IActionResult Create()
    {
        ViewData["Title"] = "Nova tarefa";
        return View("Form");
    }

    [HttpPost]
    public IActionResult Create(Todo todo)
    {
        todo.CreatedAt = DateTime.Now;
        _context.Todos.Add(todo);
        _context.SaveChanges();
        //ou return RedirectToAction("Index");
        return RedirectToAction(nameof(Index));
    }

    public IActionResult Edit(int id)
    {
        Todo? todo = _context.Todos.Find(id);
        ViewData["Title"] = "Editar tarefa";

        if (todo == null)
        {
            return NotFound();
        }

        return View("Form", todo);
    }
    [HttpPost]
    public IActionResult Edit(Todo todo)
    {
        _context.Todos.Update(todo);
        _context.SaveChanges();
        return RedirectToAction(nameof(Index));
    }
}
