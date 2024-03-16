using Learn_CRUD.Models;
using Microsoft.EntityFrameworkCore;
 
namespace Learn_CRUD.Data
{
    public class DataBase : DbContext
    {
        public DataBase (DbContextOptions<DataBase> options) : base(options) { }
        public DbSet<Food> FoodTable { get; set; }
    }
}
