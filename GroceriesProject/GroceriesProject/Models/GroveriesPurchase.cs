using System.ComponentModel.DataAnnotations;

namespace GroceriesProject.Models
{
    public class GroveriesPurchase
    {
        [Key]
        public string GroceryName { get; set; }
        
        public  int  GroceryQuantity { get; set; }
    }
}
