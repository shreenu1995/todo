    using Microsoft.AspNetCore.Mvc;
using TodoApp.Services;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoService _todoService;

        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        public IActionResult Index()
        {
            var tasks = _todoService.GetTasks();
            return View(tasks);
        }

        [HttpPost]
        public IActionResult AddTask(string task)
        {
            _todoService.AddTask(task);
            return RedirectToAction("Index");
        }
    }
}
