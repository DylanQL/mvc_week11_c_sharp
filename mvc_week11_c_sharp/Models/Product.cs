namespace mvc_week11_c_sharp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Foreign Key
        public Category Category { get; set; }
        public int CategoryId { get; set; }

    }
}
