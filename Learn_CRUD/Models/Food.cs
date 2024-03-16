using Learn_CRUD.Data;
namespace Learn_CRUD.Models

{
    public class Food
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }
        public int Count { get; set; }
        public int Price { get; set; }
    }
}
