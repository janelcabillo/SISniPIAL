using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SISniPIAL.forms
{
    public class Logger
    {
        private static string conString = DatabaseConnection.conString;

        public static void Log(int? userId, string actionType, string description)
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    string insertLog = "INSERT INTO logs (ActionDate, ActionType, Description, userId) " +
                   "VALUES (@date, @action, @description, @user_id)";


                    using (SqlCommand cmd = new SqlCommand(insertLog, con))
                    {
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@action", actionType);
                        cmd.Parameters.AddWithValue("@description", description);

                        if (userId.HasValue)
                            cmd.Parameters.AddWithValue("@user_id", userId.Value);
                        else
                            cmd.Parameters.AddWithValue("@user_id", DBNull.Value);

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
