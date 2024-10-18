using quanlylaptop.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlylaptop
{
    public partial class Form_Laptop : Form
    {

        //MyConnect myconn = new MyConnect();
        public Form_Laptop()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            ClassDAL dal = new ClassDAL();
            DataTable laptopData = dal.LoadData("SELECT * FROM Laptop");
            dgv_Laptop.Rows.Clear();
            foreach (DataRow row in laptopData.Rows)
            {
                dgv_Laptop.Rows.Add(row.ItemArray);
            }
        }
        private void Form_Laptop_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgv_Laptop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng có click vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Laptop.Rows[e.RowIndex];

                // Gán giá trị vào các TextBox tương ứng, thực hiện chuyển đổi kiểu dữ liệu khi cần
                this.txt_MaLT.Text = row.Cells["MaLT"].Value.ToString();
                this.txt_TenLT.Text = row.Cells["TenLT"].Value.ToString();
                this.txt_TenHangLT.Text = row.Cells["TenHangLT"].Value.ToString();

                // Chuyển đổi kiểu dữ liệu cho các trường cần thiết
                this.txt_SoLuong.Text = Convert.ToInt32(row.Cells["SoLuong"].Value).ToString();
                this.txt_KhoiLuong.Text = Convert.ToDecimal(row.Cells["KhoiLuong"].Value).ToString("F2"); // Định dạng số thập phân
                this.txt_ThoiGianBaoHanh.Text = Convert.ToInt32(row.Cells["ThoiGianBaoHanh"].Value).ToString();

                this.txt_GiaBanGoc.Text = row.Cells["GiaBanGoc"].Value.ToString();
                this.txt_MauSac.Text = row.Cells["MauSac"].Value.ToString();
                this.txt_DungLuongBoNho.Text = row.Cells["DungLuongBoNho"].Value.ToString();
                this.txt_ManHinh.Text = row.Cells["ManHinh"].Value.ToString();
                this.txt_CPU.Text = row.Cells["CPU"].Value.ToString();
                this.txt_QuaTangKem.Text = row.Cells["QuaTangKem"].Value.ToString();
                this.txt_Pin.Text = row.Cells["Pin"].Value.ToString();
                // Chuyển sang tab Options
                this.tabControl1.SelectedTab = this.tabPage2;
            }
        }
    }
}
