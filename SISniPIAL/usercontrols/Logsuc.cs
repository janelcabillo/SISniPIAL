using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace SISniPIAL.forms
{
    public partial class Logsuc : UserControl
    {
        public Logsuc()
        {
            InitializeComponent();
        }

        private void Logsuc_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }
        private void LoadLogs()
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
            {
                conn.Open();
                string query = @"
            SELECT 
                l.action_date AS [Date & Time],
                r.role AS [Role],
                u.username AS [Username],
                l.action_type AS [Action],
                l.description AS [Details]
            FROM logs l
            LEFT JOIN user_login u ON l.userId = u.userId
            LEFT JOIN Role r ON u.roleId = r.roleId
            ORDER BY l.action_date DESC";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvLogs.DataSource = dt;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadLogsWithSearch(txtSearch.Text.Trim());
        }
        private void LoadLogsWithSearch(string searchText = "")
        {
            using (SqlConnection conn = new SqlConnection(DatabaseConnection.conString))
            {
                conn.Open();
                string query = @"
                                SELECT 
                                    l.action_date AS [Date & Time],
                                    r.role AS [Role],
                                    u.username AS [Username],
                                    l.action_type AS [Action],
                                    l.description AS [Details]
                                FROM logs l
                                LEFT JOIN user_login u ON l.userId = u.userId
                                LEFT JOIN Role r ON u.roleId = r.roleId
                                WHERE
                                    CONVERT(VARCHAR, l.action_date, 120) LIKE @search OR -- yyyy-mm-dd hh:mm:ss
                                    CONVERT(VARCHAR, l.action_date, 101) LIKE @search OR -- mm/dd/yyyy
                                    CONVERT(VARCHAR, l.action_date, 103) LIKE @search OR -- dd/mm/yyyy
                                    r.role LIKE @search OR
                                    u.username LIKE @search OR
                                    l.action_type LIKE @search OR
                                    l.description LIKE @search
                                ORDER BY l.action_date DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + searchText + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvLogs.DataSource = dt;
                }
            }
        }
    }
}
