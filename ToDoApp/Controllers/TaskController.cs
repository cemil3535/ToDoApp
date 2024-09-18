using Microsoft.AspNetCore.Mvc;
using ToDoApp.Entites;
using ToDoApp.Models;

namespace ToDoApp.Controllers
{
    public class TaskController : Controller
    {
        static List<TaskEntity> _tasks = new List<TaskEntity>()
        {
            new TaskEntity{Id = 1, Title = "Toplantiya Katil", Content = "Musteri Toplantisina Katil"},
            new TaskEntity{Id = 1, Title = "Rapor Hazirla", Content = "Satis Raporunu Tamamla Ve Yoneticilere Gonder"},
            new TaskEntity{Id = 1, Title = "Egzersiz Yap", Content = "30 dakika Yuruyus Yap", IsDone = true}
        };


        public IActionResult List()
        {
            var viewModel = _tasks.Where(x => x.IsDeleted == false).Select(x => new TaskListViewModel
            {
                Id = x.Id,
                Title = x.Title,
                Content = x.Content,
            }).ToList();


            return View(viewModel);
        }
    }
}
