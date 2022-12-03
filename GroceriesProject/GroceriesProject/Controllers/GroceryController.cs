using GroceriesProject.Helper;
using GroceriesProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GroceriesProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GroceryController : ControllerBase
    {
        [HttpGet]
        [Route("GetGroveryList")]

        public List<GroceriesList> Groceries()
        {
            return GroceryAccess.GetGroceriesLists();
        }

        [HttpPost]
        [Route("AddGrocery")]
        public GroceriesList CreateGrocery(GroceriesList groceries)
        {
            GroceriesList groceriesList = GroceryAccess.AddGroceries(groceries);
            return groceriesList;
        }
       
        [HttpPut]
        [Route("UpdateQuantiry")]
        public int UpdateGrocery(GroceriesList groceries)
        {
            int availabelQuantiy = GroceryAccess.UpdateGroceries(groceries);
            return availabelQuantiy;
        }


        [HttpDelete]
        [Route("DeleteGrocery")]
        public string DeleteGrocry(string name)
        {
            return GroceryAccess.Delete(name);
        }


    }
}
