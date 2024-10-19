namespace quanlylaptop
{
    partial class Form_KhachHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TimKiemKH_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TimKiemKH_CCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TimKiemKH_HoTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_TimKiem_KhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add_KhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_KhachHang = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoTenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoCCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongSoTienDaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Sua_KhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa_KhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them_KhachHang = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TongSoTienDaGiaoDich = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SoCCCD = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_HoTenKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_LoaiKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaKH = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1272, 860);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.guna2TextBox1);
            this.tabPage1.Controls.Add(this.txt_TimKiemKH_SDT);
            this.tabPage1.Controls.Add(this.txt_TimKiemKH_CCCD);
            this.tabPage1.Controls.Add(this.txt_TimKiemKH_HoTenKH);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btn_TimKiem_KhachHang);
            this.tabPage1.Controls.Add(this.btn_Add_KhachHang);
            this.tabPage1.Controls.Add(this.dgv_KhachHang);
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1264, 831);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label4.Location = new System.Drawing.Point(460, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 38);
            this.label4.TabIndex = 39;
            this.label4.Text = "Thông tin khách hàng";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(809, 76);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(353, 49);
            this.guna2TextBox1.TabIndex = 38;
            // 
            // txt_TimKiemKH_SDT
            // 
            this.txt_TimKiemKH_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemKH_SDT.DefaultText = "";
            this.txt_TimKiemKH_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiemKH_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiemKH_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemKH_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemKH_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemKH_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemKH_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemKH_SDT.Location = new System.Drawing.Point(738, 177);
            this.txt_TimKiemKH_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiemKH_SDT.Name = "txt_TimKiemKH_SDT";
            this.txt_TimKiemKH_SDT.PasswordChar = '\0';
            this.txt_TimKiemKH_SDT.PlaceholderText = "";
            this.txt_TimKiemKH_SDT.SelectedText = "";
            this.txt_TimKiemKH_SDT.Size = new System.Drawing.Size(229, 48);
            this.txt_TimKiemKH_SDT.TabIndex = 35;
            // 
            // txt_TimKiemKH_CCCD
            // 
            this.txt_TimKiemKH_CCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemKH_CCCD.DefaultText = "";
            this.txt_TimKiemKH_CCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiemKH_CCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiemKH_CCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemKH_CCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemKH_CCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemKH_CCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemKH_CCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemKH_CCCD.Location = new System.Drawing.Point(500, 177);
            this.txt_TimKiemKH_CCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiemKH_CCCD.Name = "txt_TimKiemKH_CCCD";
            this.txt_TimKiemKH_CCCD.PasswordChar = '\0';
            this.txt_TimKiemKH_CCCD.PlaceholderText = "";
            this.txt_TimKiemKH_CCCD.SelectedText = "";
            this.txt_TimKiemKH_CCCD.Size = new System.Drawing.Size(229, 48);
            this.txt_TimKiemKH_CCCD.TabIndex = 34;
            // 
            // txt_TimKiemKH_HoTenKH
            // 
            this.txt_TimKiemKH_HoTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TimKiemKH_HoTenKH.DefaultText = "";
            this.txt_TimKiemKH_HoTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TimKiemKH_HoTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TimKiemKH_HoTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemKH_HoTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TimKiemKH_HoTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemKH_HoTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TimKiemKH_HoTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TimKiemKH_HoTenKH.Location = new System.Drawing.Point(262, 177);
            this.txt_TimKiemKH_HoTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TimKiemKH_HoTenKH.Name = "txt_TimKiemKH_HoTenKH";
            this.txt_TimKiemKH_HoTenKH.PasswordChar = '\0';
            this.txt_TimKiemKH_HoTenKH.PlaceholderText = "";
            this.txt_TimKiemKH_HoTenKH.SelectedText = "";
            this.txt_TimKiemKH_HoTenKH.Size = new System.Drawing.Size(229, 48);
            this.txt_TimKiemKH_HoTenKH.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(735, 154);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 18);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nhập SĐT:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(496, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nhập CCCD:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Nhập họ tên KH:";
            // 
            // btn_TimKiem_KhachHang
            // 
            this.btn_TimKiem_KhachHang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_KhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem_KhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem_KhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiem_KhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiem_KhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_TimKiem_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_KhachHang.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_KhachHang.Location = new System.Drawing.Point(1169, 76);
            this.btn_TimKiem_KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_KhachHang.Name = "btn_TimKiem_KhachHang";
            this.btn_TimKiem_KhachHang.Size = new System.Drawing.Size(87, 49);
            this.btn_TimKiem_KhachHang.TabIndex = 20;
            this.btn_TimKiem_KhachHang.Text = "Tìm";
            // 
            // btn_Add_KhachHang
            // 
            this.btn_Add_KhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_KhachHang.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Add_KhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_KhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_KhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add_KhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add_KhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Add_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_Add_KhachHang.Location = new System.Drawing.Point(8, 76);
            this.btn_Add_KhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add_KhachHang.Name = "btn_Add_KhachHang";
            this.btn_Add_KhachHang.Size = new System.Drawing.Size(240, 52);
            this.btn_Add_KhachHang.TabIndex = 18;
            this.btn_Add_KhachHang.Text = "+ Thêm khách hàng";
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowUserToAddRows = false;
            this.dgv_KhachHang.AllowUserToDeleteRows = false;
            this.dgv_KhachHang.AllowUserToResizeColumns = false;
            this.dgv_KhachHang.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_KhachHang.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_KhachHang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_KhachHang.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_KhachHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_KhachHang.ColumnHeadersHeight = 80;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.LoaiKH,
            this.HoTenKH,
            this.SoCCCD,
            this.SDT,
            this.TongSoTienDaGD});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_KhachHang.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_KhachHang.Location = new System.Drawing.Point(16, 250);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersVisible = false;
            this.dgv_KhachHang.RowHeadersWidth = 62;
            this.dgv_KhachHang.RowTemplate.Height = 24;
            this.dgv_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dgv_KhachHang.ShowCellErrors = false;
            this.dgv_KhachHang.ShowCellToolTips = false;
            this.dgv_KhachHang.ShowEditingIcon = false;
            this.dgv_KhachHang.ShowRowErrors = false;
            this.dgv_KhachHang.Size = new System.Drawing.Size(1240, 582);
            this.dgv_KhachHang.TabIndex = 0;
            this.dgv_KhachHang.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_KhachHang.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_KhachHang.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_KhachHang.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_KhachHang.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_KhachHang.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_KhachHang.ThemeStyle.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_KhachHang.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_KhachHang.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_KhachHang.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_KhachHang.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_KhachHang.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_KhachHang.ThemeStyle.HeaderStyle.Height = 80;
            this.dgv_KhachHang.ThemeStyle.ReadOnly = false;
            this.dgv_KhachHang.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_KhachHang.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_KhachHang.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_KhachHang.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_KhachHang.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_KhachHang.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_KhachHang.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaKH
            // 
            this.MaKH.HeaderText = "Mã khách hàng";
            this.MaKH.MinimumWidth = 8;
            this.MaKH.Name = "MaKH";
            // 
            // LoaiKH
            // 
            this.LoaiKH.HeaderText = "Loại khách hàng";
            this.LoaiKH.MinimumWidth = 6;
            this.LoaiKH.Name = "LoaiKH";
            // 
            // HoTenKH
            // 
            this.HoTenKH.HeaderText = "Họ tên khách hàng";
            this.HoTenKH.MinimumWidth = 6;
            this.HoTenKH.Name = "HoTenKH";
            // 
            // SoCCCD
            // 
            this.SoCCCD.HeaderText = "Số CCCD";
            this.SoCCCD.MinimumWidth = 6;
            this.SoCCCD.Name = "SoCCCD";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // TongSoTienDaGD
            // 
            this.TongSoTienDaGD.HeaderText = "Tổng tiền giao dịch";
            this.TongSoTienDaGD.MinimumWidth = 6;
            this.TongSoTienDaGD.Name = "TongSoTienDaGD";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.btn_Sua_KhachHang);
            this.tabPage2.Controls.Add(this.btn_Xoa_KhachHang);
            this.tabPage2.Controls.Add(this.btn_Them_KhachHang);
            this.tabPage2.Controls.Add(this.txt_TongSoTienDaGiaoDich);
            this.tabPage2.Controls.Add(this.txt_SDT);
            this.tabPage2.Controls.Add(this.txt_SoCCCD);
            this.tabPage2.Controls.Add(this.txt_HoTenKH);
            this.tabPage2.Controls.Add(this.txt_LoaiKH);
            this.tabPage2.Controls.Add(this.txt_MaKH);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1264, 831);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label19.Location = new System.Drawing.Point(462, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(455, 32);
            this.label19.TabIndex = 27;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN KHÁCH HÀNG";
            // 
            // btn_Sua_KhachHang
            // 
            this.btn_Sua_KhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua_KhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua_KhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua_KhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua_KhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Sua_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_KhachHang.Location = new System.Drawing.Point(939, 487);
            this.btn_Sua_KhachHang.Name = "btn_Sua_KhachHang";
            this.btn_Sua_KhachHang.Size = new System.Drawing.Size(180, 45);
            this.btn_Sua_KhachHang.TabIndex = 26;
            this.btn_Sua_KhachHang.Text = "Sửa";
            // 
            // btn_Xoa_KhachHang
            // 
            this.btn_Xoa_KhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa_KhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa_KhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa_KhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa_KhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Xoa_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_KhachHang.Location = new System.Drawing.Point(639, 487);
            this.btn_Xoa_KhachHang.Name = "btn_Xoa_KhachHang";
            this.btn_Xoa_KhachHang.Size = new System.Drawing.Size(180, 45);
            this.btn_Xoa_KhachHang.TabIndex = 26;
            this.btn_Xoa_KhachHang.Text = "Xóa";
            // 
            // btn_Them_KhachHang
            // 
            this.btn_Them_KhachHang.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_KhachHang.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_KhachHang.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them_KhachHang.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them_KhachHang.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Them_KhachHang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_KhachHang.ForeColor = System.Drawing.Color.White;
            this.btn_Them_KhachHang.Location = new System.Drawing.Point(339, 487);
            this.btn_Them_KhachHang.Name = "btn_Them_KhachHang";
            this.btn_Them_KhachHang.Size = new System.Drawing.Size(180, 45);
            this.btn_Them_KhachHang.TabIndex = 26;
            this.btn_Them_KhachHang.Text = "Thêm";
            // 
            // txt_TongSoTienDaGiaoDich
            // 
            this.txt_TongSoTienDaGiaoDich.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TongSoTienDaGiaoDich.DefaultText = "";
            this.txt_TongSoTienDaGiaoDich.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TongSoTienDaGiaoDich.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TongSoTienDaGiaoDich.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TongSoTienDaGiaoDich.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TongSoTienDaGiaoDich.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TongSoTienDaGiaoDich.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TongSoTienDaGiaoDich.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TongSoTienDaGiaoDich.Location = new System.Drawing.Point(536, 376);
            this.txt_TongSoTienDaGiaoDich.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TongSoTienDaGiaoDich.Name = "txt_TongSoTienDaGiaoDich";
            this.txt_TongSoTienDaGiaoDich.PasswordChar = '\0';
            this.txt_TongSoTienDaGiaoDich.PlaceholderText = "";
            this.txt_TongSoTienDaGiaoDich.SelectedText = "";
            this.txt_TongSoTienDaGiaoDich.Size = new System.Drawing.Size(459, 42);
            this.txt_TongSoTienDaGiaoDich.TabIndex = 18;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SDT.DefaultText = "";
            this.txt_SDT.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SDT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SDT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SDT.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SDT.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SDT.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SDT.Location = new System.Drawing.Point(536, 326);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.PasswordChar = '\0';
            this.txt_SDT.PlaceholderText = "";
            this.txt_SDT.SelectedText = "";
            this.txt_SDT.Size = new System.Drawing.Size(459, 42);
            this.txt_SDT.TabIndex = 17;
            // 
            // txt_SoCCCD
            // 
            this.txt_SoCCCD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_SoCCCD.DefaultText = "";
            this.txt_SoCCCD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_SoCCCD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_SoCCCD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoCCCD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_SoCCCD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoCCCD.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_SoCCCD.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_SoCCCD.Location = new System.Drawing.Point(536, 276);
            this.txt_SoCCCD.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_SoCCCD.Name = "txt_SoCCCD";
            this.txt_SoCCCD.PasswordChar = '\0';
            this.txt_SoCCCD.PlaceholderText = "";
            this.txt_SoCCCD.SelectedText = "";
            this.txt_SoCCCD.Size = new System.Drawing.Size(459, 42);
            this.txt_SoCCCD.TabIndex = 16;
            // 
            // txt_HoTenKH
            // 
            this.txt_HoTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_HoTenKH.DefaultText = "";
            this.txt_HoTenKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_HoTenKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_HoTenKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HoTenKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_HoTenKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HoTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_HoTenKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_HoTenKH.Location = new System.Drawing.Point(536, 226);
            this.txt_HoTenKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_HoTenKH.Name = "txt_HoTenKH";
            this.txt_HoTenKH.PasswordChar = '\0';
            this.txt_HoTenKH.PlaceholderText = "";
            this.txt_HoTenKH.SelectedText = "";
            this.txt_HoTenKH.Size = new System.Drawing.Size(459, 42);
            this.txt_HoTenKH.TabIndex = 15;
            // 
            // txt_LoaiKH
            // 
            this.txt_LoaiKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_LoaiKH.DefaultText = "";
            this.txt_LoaiKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_LoaiKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_LoaiKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LoaiKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_LoaiKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LoaiKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_LoaiKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_LoaiKH.Location = new System.Drawing.Point(536, 176);
            this.txt_LoaiKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_LoaiKH.Name = "txt_LoaiKH";
            this.txt_LoaiKH.PasswordChar = '\0';
            this.txt_LoaiKH.PlaceholderText = "";
            this.txt_LoaiKH.SelectedText = "";
            this.txt_LoaiKH.Size = new System.Drawing.Size(459, 42);
            this.txt_LoaiKH.TabIndex = 14;
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaKH.DefaultText = "";
            this.txt_MaKH.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaKH.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaKH.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKH.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaKH.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaKH.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaKH.Location = new System.Drawing.Point(536, 126);
            this.txt_MaKH.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.PasswordChar = '\0';
            this.txt_MaKH.PlaceholderText = "";
            this.txt_MaKH.SelectedText = "";
            this.txt_MaKH.Size = new System.Drawing.Size(459, 42);
            this.txt_MaKH.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(281, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(237, 28);
            this.label11.TabIndex = 5;
            this.label11.Text = "Tổng số tiền đã giao dịch:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label10.Location = new System.Drawing.Point(281, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 28);
            this.label10.TabIndex = 4;
            this.label10.Text = "Số điện thoại:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label9.Location = new System.Drawing.Point(281, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Số CCCD:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(281, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(182, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Họ tên khách hàng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(281, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Loại khách hàng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(281, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã khách hàng:";
            // 
            // Form_KhachHang
            // 
            this.ClientSize = new System.Drawing.Size(1385, 892);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_KhachHang";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_KhachHang;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem_KhachHang;
        private Guna.UI2.WinForms.Guna2Button btn_Add_KhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiemKH_HoTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiemKH_SDT;
        private Guna.UI2.WinForms.Guna2TextBox txt_TimKiemKH_CCCD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_TongSoTienDaGiaoDich;
        private Guna.UI2.WinForms.Guna2TextBox txt_SDT;
        private Guna.UI2.WinForms.Guna2TextBox txt_SoCCCD;
        private Guna.UI2.WinForms.Guna2TextBox txt_HoTenKH;
        private Guna.UI2.WinForms.Guna2TextBox txt_LoaiKH;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaKH;
        private Guna.UI2.WinForms.Guna2Button btn_Them_KhachHang;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2Button btn_Sua_KhachHang;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa_KhachHang;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoCCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongSoTienDaGD;
        private System.Windows.Forms.Label label4;
    }
}