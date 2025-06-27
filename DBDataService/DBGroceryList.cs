using GroceryListDataLogic;
using System.Data.SqlClient;
using SqlConnection = Microsoft.Data.SqlClient.SqlConnection;
using SqlCommand = Microsoft.Data.SqlClient.SqlCommand;
using SqlDataReader = Microsoft.Data.SqlClient.SqlDataReader;




namespace GroceryList.SQLDataService
{
    public class DBGroceryDataLogic : IGroceryDataLogic
    {
        private readonly string connectionString =
            "Data Source=DESKTOP-KHA36IG\\SQLEXPRESS; Initial Catalog=GroceryDB; Integrated Security=True; TrustServerCertificate=True;";

        public List<string> GetGroceryList()
        {
            var groceryItems = new List<string>();
            string query = "SELECT ItemName FROM GroceryItems";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                conn.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        groceryItems.Add(reader["ItemName"].ToString());
                    }
                }
            }

            return groceryItems;
        }

        public bool AddItem(string itemToAdd)
        {
            if (ItemExists(itemToAdd))
                return false;

            string insert = "INSERT INTO GroceryItems (ItemName) VALUES (@ItemName)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(insert, conn))
            {
                cmd.Parameters.AddWithValue("@ItemName", itemToAdd.Trim());

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool RemoveItem(string itemToRemove)
        {
            string delete = "DELETE FROM GroceryItems WHERE ItemName = @ItemName";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(delete, conn))
            {
                cmd.Parameters.AddWithValue("@ItemName", itemToRemove.Trim());

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        private bool ItemExists(string itemName)
        {
            string query = "SELECT COUNT(*) FROM GroceryItems WHERE ItemName = @ItemName";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@ItemName", itemName.Trim());

                conn.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public void ClearList()
        {
            string deleteAll = "DELETE FROM GroceryItems";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(deleteAll, conn))
            {
                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}