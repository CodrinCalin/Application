using SomerenModel;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenDAL
{
    public class ActivityDao : BaseDao
    {
        public List<Activity> GetAllActivities()
        {
            string query = "SELECT Id,Name,StartTime,EndTime FROM [Activities] ORDER BY StartTime ASC"; // change names 
            SqlParameter[] sqlParameter = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameter));
        }

        private List<Activity> ReadTables(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();
            
            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity() // change names acording to database
                {
                    Name = dr["Name"].ToString(),
                    StartTime = (DateTime)dr["StartTime"],
                    EndTime = (DateTime)dr["EndTime"],
                };
                activities.Add(activity);
            }
            return activities;
        }

        public void UpdateActivities(Activity activity)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("UPDATE Activities SET StartTime = @StartTime, EndTime = @EndTime WHERE Name = @Name");// add sqll commands for updating drinks 


            sqlCommand.Parameters.AddWithValue("@Name", activity.Name);
            sqlCommand.Parameters.AddWithValue("@StartTime", activity.StartTime);
            sqlCommand.Parameters.AddWithValue("@EndTime", activity.EndTime);

            int nrOfRowsChanged = sqlCommand.ExecuteNonQuery();
            conn.Close();

            if (nrOfRowsChanged == 0)
            {
                throw new Exception("Activities were not updated...");
            }
        }

        public void AddActivities(Activity activity)
        {
            conn.Open();
            SqlCommand sqlCommand = new SqlCommand("INSERT INTO Activities (Name, StartTime, EndTime) VALUES (@Name, @StartTime, @EndTime)");//add sql command to add drinks 

            sqlCommand.Parameters.AddWithValue("@Name", activity.Name);
            sqlCommand.Parameters.AddWithValue("@StartTime", activity.StartTime);
            sqlCommand.Parameters.AddWithValue("@EndTime", activity.EndTime);

            int nrOfRowsChanged = sqlCommand.ExecuteNonQuery();
            conn.Close();

            if (nrOfRowsChanged == 0)
            {
                throw new Exception("Activity was not added...");
            }
        }

        public void DeleteActivity(Activity activity)
        {
            conn.Open();

            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Activities WHERE Name = @Name");

            sqlCommand.Parameters.AddWithValue("@Name", activity.Name);

            int nrOfRowsChanged = sqlCommand.ExecuteNonQuery();
            conn.Close();

            if (nrOfRowsChanged == 0)
            {
                throw new Exception("Activity was not removed...");
            }
        }
    }
}
