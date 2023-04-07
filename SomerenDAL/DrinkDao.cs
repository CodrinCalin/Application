using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SomerenDAL
{
    public class DrinkDao : BaseDao
    {
        public List<Drink> GetAllDrinks()
        {
            string query = "SELECT Name,Price,IsAlcoholic,AmountInStock FROM [Drinks] ORDER BY name ASC"; // change names 
            SqlParameter[] sqlParameter = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameter));
        }

        private List<Drink> ReadTables(DataTable dataTable)
        {
            List<Drink> drinks = new List<Drink>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Drink drink = new Drink() // change names acording to database
                {
                    Name = dr["Name"].ToString(),
                    Price = (decimal)dr["Price"],
                    IsAlcoholic = dr["IsAlcoholic"].ToString(),
                    Amount = (int)dr["AmountInStock"],

                };
                drinks.Add(drink);
            }
            return drinks;
        }

        public void UpdateDrink(Drink drink)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Drinks SET Price = @Price, Amount = @Amount, IsAlcoholic = @IsAlcoholic WHERE Name = @Name");

            sqlCommand.Parameters.AddWithValue("@Price", drink.Price);
            sqlCommand.Parameters.AddWithValue("@Amount", drink.Amount);
            sqlCommand.Parameters.AddWithValue("@IsAlcoholic", drink.IsAlcoholic);
            sqlCommand.Parameters.AddWithValue("@Name", drink.Name);

            int nrOfRowsChanged = sqlCommand.ExecuteNonQuery(); 
            conn.Close();

            if (nrOfRowsChanged == 0)
            {
                throw new Exception("Drinks were not updated...");
            }
        }

        public void AddDrinks(Drink drink)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Drink(Name, Price, Amount, IsAlcoholic) VALUES(@Name, @Price, @Amount, @IsAlcoholic)");

            sqlCommand.Parameters.AddWithValue("@Price", drink.Price);
            sqlCommand.Parameters.AddWithValue("@Amount", drink.Amount);
            sqlCommand.Parameters.AddWithValue("@IsAlcoholic", drink.IsAlcoholic);
            sqlCommand.Parameters.AddWithValue("@Name", drink.Name);

            int nrOfRowsChanged = sqlCommand.ExecuteNonQuery();
            conn.Close();

            if (nrOfRowsChanged == 0)
            {
                throw new Exception("Drink was not added...");
            }
        }

        public void DeleteDrink(Drink drink)
        {
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Drinks WHERE Name = @Name"); // addSqlCommand for deleting drinks DELETE FROM Drinks WHERE Name = @Name

            sqlCommand.Parameters.AddWithValue("@name", drink.Name);

            int nrOfRowsChanged = sqlCommand.ExecuteNonQuery();
            conn.Close();

            if (nrOfRowsChanged == 0)
            {
                throw new Exception("Drink was not removed...");
            }
        }
    } 
}
