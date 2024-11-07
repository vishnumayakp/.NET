using System.ComponentModel.DataAnnotations;

namespace MyWebApi.Models
{
    public class Product
    {
        [Required(ErrorMessage ="The Product id is must")]
        public int Id { get; set; }

        [StringLength(10, ErrorMessage = "The name cannot be more than 10 characters.")]
        public string Name { get; set; }

        [Range(0.01, 10000, ErrorMessage = "Price must be between 0.01 and 10,000.")]
        public decimal Price { get; set; }
    }
}
