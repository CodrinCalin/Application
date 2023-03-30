using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenService
{
    public class DrinkService
    {
        private DrinkDao drinksdb;

        public DrinkService()
        {
            drinksdb = new DrinkDao();
        }

        public List<Drink> GetDrinks()
        {
            List<Drink> drinks = drinksdb.GetAllDrinks();
            return drinks;
        }

        public void UpdateDrink(Drink drink)
        {
            drinksdb.UpdateDrink(drink);
        }

        public void AddDrink(Drink drink)
        {
            drinksdb.AddDrinks(drink);
        }

        public void DeleteDrink(Drink drink)
        {
            drinksdb.DeleteDrink(drink);
        }
    }
}
