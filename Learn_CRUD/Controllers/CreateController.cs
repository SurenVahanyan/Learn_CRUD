using Learn_CRUD.Data;
using Learn_CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Learn_CRUD.Controllers
{
    public class CreateController : Controller
    {
        private readonly DataBase _context;

        public CreateController(DataBase data)
        {
            _context = data;
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int Id, string Name, string Type, string Description, int Price, int Count)
        {

            Food food = new Food();
            food.Id = Id;
            food.Name = Name;
            food.Type = Type;
            food.Description = Description;
            food.Price = Price;
            food.Count = Count;
            if (food != null)
            {
                _context.FoodTable.Add(food);
                _context.SaveChanges();

            }
            return RedirectToAction("Create");
        }
    }
}
