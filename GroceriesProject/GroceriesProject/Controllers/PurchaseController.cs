using GroceriesProject.Helper;
using GroceriesProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceriesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        [HttpGet]
        public List<GroveriesPurchase> GetGroveries()
        {
            List<GroveriesPurchase> groceriesLists = GroceryAccess.PurchaseList();
            return groceriesLists;
        }

        [HttpPost]

        public void Purchase(GroveriesPurchase purchase)
        {
            GroceryAccess.PurchaseGrocery(purchase);
        }
    }
}
