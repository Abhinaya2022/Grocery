using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace GroceriesProject.Models
{
    public class GroceriesList
    {
        [Key]
        public string? Name { get; set; }
        [Required]
        public DateTime ExpiryDate { get; set; }
        [Required]
        public bool isAvailable { get; set; }
        [Required]
        public int Quantity { get; set; }
    }
}
