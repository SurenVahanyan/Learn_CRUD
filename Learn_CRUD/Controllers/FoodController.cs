using Learn_CRUD.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Learn_CRUD.Controllers
{
    public class FoodController : Controller
    {
        private readonly DataBase _context;

        public FoodController(DataBase data)
        {
            _context = data;
        }
        public IActionResult Food()
        {
            return View(_context.FoodTable.ToList());
        }

        public IActionResult Delete(int Id)
        {
            var item = _context.FoodTable.Find(Id);
            _context.FoodTable.Remove(item);
            _context.SaveChanges();
            return RedirectToAction("Food");
        }
        public IActionResult Edit(int Id, string Name, string Description, string Type, int Count, int Price)
        {
            var item = _context.FoodTable.Find(Id);
            item.Name = Name;
            item.Price = Price;
            item.Type = Type;
            item.Count = Count;
            item.Description = Description;
            _context.FoodTable.Update(item);
            _context.SaveChanges();
            return RedirectToAction("Food");
        }
    }
}
