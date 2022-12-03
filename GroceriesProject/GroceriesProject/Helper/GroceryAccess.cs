using GroceriesProject.Models;

namespace GroceriesProject.Helper
{
    public class GroceryAccess
    {
        public static List<GroceriesList> GetGroceriesLists()
        {
            try
            {
                GroceriesContext context = new GroceriesContext();
                List<GroceriesList> groceries = context.Groceries.ToList();
                return groceries;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static GroceriesList AddGroceries(GroceriesList groceries)
        {
            try
            {
                GroceriesContext context = new GroceriesContext();
                context.Groceries.Add(groceries);
                context.SaveChanges();
                GroveriesPurchase purchare = new()
                {
                    GroceryName = groceries.Name,
                    GroceryQuantity = groceries.Quantity
                };
                context.GroveriesPurchases.Add(purchare);
                context.SaveChanges();
                return groceries;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public static int UpdateGroceries(GroceriesList grocery)
        {
            try
            {
                GroceriesContext context = new GroceriesContext();
                GroceriesList presentgrocery = context.Groceries.FirstOrDefault(groceries => groceries.Name == grocery.Name);
                presentgrocery.Quantity = grocery.Quantity;
                context.Update(presentgrocery);
                context.SaveChanges();
                return grocery.Quantity;
            }
            catch (Exception)
            {

                throw;
            }

        }

        internal static string Delete(string name)
        {
            try
            {
                GroceriesContext context = new GroceriesContext();
                GroceriesList presentgrocery = context.Groceries.FirstOrDefault(groceries => groceries.Name == name);
                context.Groceries.Remove(presentgrocery);
                return presentgrocery.Name;
            }
            catch (Exception)
            {

                throw;
            }

        }


        public static List<GroveriesPurchase> PurchaseList()
        {
            try
            {
                GroceriesContext context = new GroceriesContext();
                List<GroveriesPurchase> groceries = context.GroveriesPurchases.ToList();
                return groceries;
            }
            catch (Exception)
            {

                throw;
            }

        }

        internal static void PurchaseGrocery(GroveriesPurchase purchase)
        {
            GroceriesContext context = new GroceriesContext();
            GroveriesPurchase result = context.GroveriesPurchases.FirstOrDefault(s => s.GroceryName == purchase.GroceryName);          
            
            result.GroceryQuantity = result.GroceryQuantity - purchase.GroceryQuantity;         

            context.GroveriesPurchases.Update(result);
            context.SaveChanges();

        }
    }
}
