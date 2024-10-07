using System.Collections.Generic;
using System.Linq;
using TodoApp.Models;

namespace TodoApp.Services
{
    public class TodoService
    {
        private List<TodoItem> _tasks = new List<TodoItem>();

        public IEnumerable<TodoItem> GetTasks()
        {
            return _tasks;
        }

        public void AddTask(string task)
        {
            var newTask = new TodoItem { Id = _tasks.Count + 1, Task = task, IsCompleted = false };
            _tasks.Add(newTask);
        }
    }
}
