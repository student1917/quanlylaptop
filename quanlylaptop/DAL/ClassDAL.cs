using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlylaptop.DAL
{
    internal class ClassDAL
    {
        MyConnect myconn = new MyConnect();
        //Read Items to Table
        public DataTable LoadData(string query)
        {
            DataTable dataTable = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand(query, myconn.getConnectionAdmin))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dataTable;
        }
    }
}
