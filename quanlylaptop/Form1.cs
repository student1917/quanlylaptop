using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlylaptop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_TrangChu_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_Laptop_Click(object sender, EventArgs e)
        {
            container(new Form_Laptop());
        }

        private void btn_NhaCungCap_Click(object sender, EventArgs e)
        {
            container(new Form_NhaCungCap());
        }

        private void btn_PhieuNhapKho_Click(object sender, EventArgs e)
        {
            container(new Form_PhieuNhapKho());
        }

        private void btn_HoaDon_Click(object sender, EventArgs e)
        {
            container(new Form_HoaDon());
        }

        private void btn_KhachHang_Click(object sender, EventArgs e)
        {
            container(new Form_KhachHang());
        }


        //
        private void container(object _form)
        {
            if (panelContent.Controls.Count > 0)
                panelContent.Controls.Clear();
            Form form = _form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelContent.Controls.Add(form);
            panelContent.Tag = form;
            form.Show();
        }
        private void btn_Thoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
