using System.ComponentModel.DataAnnotations.Schema;

namespace RVAProdavnica.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public DateTime DateCreatedAt { get; set; }

        public DateTime DateUpdatedAt { get; set; }

        public bool Active { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }




    }
}