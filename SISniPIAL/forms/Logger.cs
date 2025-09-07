using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SISniPIAL.forms
{
    internal class Logger
    {
        private static string conString = DatabaseConnection.conString;

        public static void Logs(int user_id, string actionType, string description)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    conn.Open();

                    string insertLog = "INSERT INTO logs (action_date, action_type, description, userId) " +
                                       "VALUES (@date, @action, @description, @user_id)";

                    using (SqlCommand cmd = new SqlCommand(insertLog, conn))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@action", actionType);
                        cmd.Parameters.AddWithValue("@description", description);
                        cmd.Parameters.AddWithValue("@user_id", (object)user_id ?? DBNull.Value);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving log: " + ex.Message);
            }
        }
    }
}
