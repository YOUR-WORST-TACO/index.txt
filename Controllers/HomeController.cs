using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Index.txt.Models;
using Microsoft.EntityFrameworkCore;

namespace Index.txt.Controllers
{
    public class HomeController : Controller
    {
        private readonly TodoModelDbContext _context;

        public HomeController(TodoModelDbContext context)
        {
            _context = context;

            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();
            
            var contexts = new[]
            {
                new Context { Tag = "Dev" },
                new Context { Tag = "School" },
                new Context { Tag = "Finance" }
            };

            var projects = new[]
            {
                new Project { Tag = "BuildSQL" },
                new Project { Tag = "PayOffSchool" },
                new Project { Tag = "BuildLegoCar" }
            };

            var toDos = new[]
            {
                new TodoItem {Description = "Buy a new lego set"},
                new TodoItem {Description = "Write SQL connectors for C++"}
            };

            _context.AddRange(
                new TodoItemContext {TodoItem = toDos[0], Context = contexts[0]},
                new TodoItemProject {TodoItem = toDos[0], Project = projects[2]},
                new TodoItemContext {TodoItem = toDos[1], Context = contexts[0]},
                new TodoItemContext {TodoItem = toDos[1], Context = contexts[1]},
                new TodoItemProject {TodoItem = toDos[1], Project = projects[0]}
            );
            _context.SaveChanges();

            var todoItems = _context.TodoItems
                .Include(e => e.TodoItemContexts)
                .ThenInclude(e => e.Context)
                .Include(e => e.TodoItemProjects)
                .ThenInclude(e => e.Project)
                .ToList();
            foreach (var todo in todoItems)
            {
                Console.WriteLine($"Todo {todo.Description};");
                foreach (var todoContext in todo.TodoItemContexts.Select( e => e.Context ))
                {
                    Console.WriteLine($"    Context {todoContext.Tag}");
                }

                foreach (var todoProject in todo.TodoItemProjects.Select(e => e.Project))
                {
                    Console.WriteLine($"    Project {todoProject.Tag}");
                }
            }
        }
        public IActionResult Index()
        {
            
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}