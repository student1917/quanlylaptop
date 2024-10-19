namespace quanlylaptop
{
    partial class Form_NhaCungCap
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
            this.btn_TimKiem_NCC = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Add_NhaCungCap = new Guna.UI2.WinForms.Guna2Button();
            this.dgv_NhaCungCap = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThaiHopTac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.btn_Sua_NCC = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Xoa_NCC = new Guna.UI2.WinForms.Guna2Button();
            this.btn_Them_NCC = new Guna.UI2.WinForms.Guna2Button();
            this.txt_TrangThaiHopTac = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_SDT = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_DiaChi = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_TenNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_MaNCC = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).BeginInit();
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
            this.tabPage1.Controls.Add(this.btn_TimKiem_NCC);
            this.tabPage1.Controls.Add(this.btn_Add_NhaCungCap);
            this.tabPage1.Controls.Add(this.dgv_NhaCungCap);
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
            this.label4.Size = new System.Drawing.Size(327, 38);
            this.label4.TabIndex = 40;
            this.label4.Text = "Thông tin nhà cung cấp";
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
            this.guna2TextBox1.Location = new System.Drawing.Point(813, 79);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(353, 49);
            this.guna2TextBox1.TabIndex = 38;
            // 
            // btn_TimKiem_NCC
            // 
            this.btn_TimKiem_NCC.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(67)))), ((int)(((byte)(108)))));
            this.btn_TimKiem_NCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem_NCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_TimKiem_NCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_TimKiem_NCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_TimKiem_NCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_TimKiem_NCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_TimKiem_NCC.ForeColor = System.Drawing.Color.White;
            this.btn_TimKiem_NCC.ImageSize = new System.Drawing.Size(52, 52);
            this.btn_TimKiem_NCC.Location = new System.Drawing.Point(1173, 79);
            this.btn_TimKiem_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.btn_TimKiem_NCC.Name = "btn_TimKiem_NCC";
            this.btn_TimKiem_NCC.Size = new System.Drawing.Size(87, 49);
            this.btn_TimKiem_NCC.TabIndex = 20;
            this.btn_TimKiem_NCC.Text = "Tìm";
            // 
            // btn_Add_NhaCungCap
            // 
            this.btn_Add_NhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.btn_Add_NhaCungCap.BorderColor = System.Drawing.Color.IndianRed;
            this.btn_Add_NhaCungCap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_NhaCungCap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Add_NhaCungCap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Add_NhaCungCap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Add_NhaCungCap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Add_NhaCungCap.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add_NhaCungCap.ForeColor = System.Drawing.Color.White;
            this.btn_Add_NhaCungCap.Location = new System.Drawing.Point(8, 76);
            this.btn_Add_NhaCungCap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Add_NhaCungCap.Name = "btn_Add_NhaCungCap";
            this.btn_Add_NhaCungCap.Size = new System.Drawing.Size(240, 52);
            this.btn_Add_NhaCungCap.TabIndex = 18;
            this.btn_Add_NhaCungCap.Text = "+ Thêm nhà cung cấp";
            // 
            // dgv_NhaCungCap
            // 
            this.dgv_NhaCungCap.AllowUserToAddRows = false;
            this.dgv_NhaCungCap.AllowUserToDeleteRows = false;
            this.dgv_NhaCungCap.AllowUserToResizeColumns = false;
            this.dgv_NhaCungCap.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_NhaCungCap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_NhaCungCap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_NhaCungCap.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_NhaCungCap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_NhaCungCap.ColumnHeadersHeight = 80;
            this.dgv_NhaCungCap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_NhaCungCap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNCC,
            this.TenNCC,
            this.Email,
            this.DiaChi,
            this.SDT,
            this.TrangThaiHopTac});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_NhaCungCap.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_NhaCungCap.Location = new System.Drawing.Point(16, 199);
            this.dgv_NhaCungCap.Name = "dgv_NhaCungCap";
            this.dgv_NhaCungCap.RowHeadersVisible = false;
            this.dgv_NhaCungCap.RowHeadersWidth = 62;
            this.dgv_NhaCungCap.RowTemplate.Height = 24;
            this.dgv_NhaCungCap.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.RowHeaderSelect;
            this.dgv_NhaCungCap.ShowCellErrors = false;
            this.dgv_NhaCungCap.ShowCellToolTips = false;
            this.dgv_NhaCungCap.ShowEditingIcon = false;
            this.dgv_NhaCungCap.ShowRowErrors = false;
            this.dgv_NhaCungCap.Size = new System.Drawing.Size(1240, 633);
            this.dgv_NhaCungCap.TabIndex = 0;
            this.dgv_NhaCungCap.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_NhaCungCap.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_NhaCungCap.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_NhaCungCap.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_NhaCungCap.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_NhaCungCap.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_NhaCungCap.ThemeStyle.GridColor = System.Drawing.SystemColors.ControlDark;
            this.dgv_NhaCungCap.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_NhaCungCap.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_NhaCungCap.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_NhaCungCap.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_NhaCungCap.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_NhaCungCap.ThemeStyle.HeaderStyle.Height = 80;
            this.dgv_NhaCungCap.ThemeStyle.ReadOnly = false;
            this.dgv_NhaCungCap.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_NhaCungCap.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_NhaCungCap.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_NhaCungCap.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_NhaCungCap.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_NhaCungCap.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_NhaCungCap.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaNCC
            // 
            this.MaNCC.HeaderText = "Mã nhà cung cấp";
            this.MaNCC.MinimumWidth = 8;
            this.MaNCC.Name = "MaNCC";
            // 
            // TenNCC
            // 
            this.TenNCC.HeaderText = "Tên nhà cung cấp";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // DiaChi
            // 
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            // 
            // SDT
            // 
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            // 
            // TrangThaiHopTac
            // 
            this.TrangThaiHopTac.HeaderText = "Trạng thái hợp tác";
            this.TrangThaiHopTac.MinimumWidth = 6;
            this.TrangThaiHopTac.Name = "TrangThaiHopTac";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.btn_Sua_NCC);
            this.tabPage2.Controls.Add(this.btn_Xoa_NCC);
            this.tabPage2.Controls.Add(this.btn_Them_NCC);
            this.tabPage2.Controls.Add(this.txt_TrangThaiHopTac);
            this.tabPage2.Controls.Add(this.txt_SDT);
            this.tabPage2.Controls.Add(this.txt_DiaChi);
            this.tabPage2.Controls.Add(this.txt_Email);
            this.tabPage2.Controls.Add(this.txt_TenNCC);
            this.tabPage2.Controls.Add(this.txt_MaNCC);
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
            this.label19.Size = new System.Drawing.Size(476, 32);
            this.label19.TabIndex = 27;
            this.label19.Text = "TÙY CHỈNH THÔNG TIN NHÀ CUNG CẤP";
            // 
            // btn_Sua_NCC
            // 
            this.btn_Sua_NCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua_NCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Sua_NCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Sua_NCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Sua_NCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Sua_NCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua_NCC.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_NCC.Location = new System.Drawing.Point(868, 490);
            this.btn_Sua_NCC.Name = "btn_Sua_NCC";
            this.btn_Sua_NCC.Size = new System.Drawing.Size(180, 45);
            this.btn_Sua_NCC.TabIndex = 26;
            this.btn_Sua_NCC.Text = "Sửa";
            // 
            // btn_Xoa_NCC
            // 
            this.btn_Xoa_NCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa_NCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Xoa_NCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Xoa_NCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Xoa_NCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Xoa_NCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa_NCC.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_NCC.Location = new System.Drawing.Point(570, 490);
            this.btn_Xoa_NCC.Name = "btn_Xoa_NCC";
            this.btn_Xoa_NCC.Size = new System.Drawing.Size(180, 45);
            this.btn_Xoa_NCC.TabIndex = 26;
            this.btn_Xoa_NCC.Text = "Xóa";
            // 
            // btn_Them_NCC
            // 
            this.btn_Them_NCC.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_NCC.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_Them_NCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_Them_NCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_Them_NCC.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(81)))), ((int)(((byte)(68)))));
            this.btn_Them_NCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_NCC.ForeColor = System.Drawing.Color.White;
            this.btn_Them_NCC.Location = new System.Drawing.Point(268, 490);
            this.btn_Them_NCC.Name = "btn_Them_NCC";
            this.btn_Them_NCC.Size = new System.Drawing.Size(180, 45);
            this.btn_Them_NCC.TabIndex = 26;
            this.btn_Them_NCC.Text = "Thêm";
            // 
            // txt_TrangThaiHopTac
            // 
            this.txt_TrangThaiHopTac.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TrangThaiHopTac.DefaultText = "";
            this.txt_TrangThaiHopTac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TrangThaiHopTac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TrangThaiHopTac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TrangThaiHopTac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TrangThaiHopTac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TrangThaiHopTac.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TrangThaiHopTac.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TrangThaiHopTac.Location = new System.Drawing.Point(536, 376);
            this.txt_TrangThaiHopTac.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TrangThaiHopTac.Name = "txt_TrangThaiHopTac";
            this.txt_TrangThaiHopTac.PasswordChar = '\0';
            this.txt_TrangThaiHopTac.PlaceholderText = "";
            this.txt_TrangThaiHopTac.SelectedText = "";
            this.txt_TrangThaiHopTac.Size = new System.Drawing.Size(459, 42);
            this.txt_TrangThaiHopTac.TabIndex = 18;
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
            // txt_DiaChi
            // 
            this.txt_DiaChi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_DiaChi.DefaultText = "";
            this.txt_DiaChi.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_DiaChi.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_DiaChi.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_DiaChi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_DiaChi.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_DiaChi.Location = new System.Drawing.Point(536, 276);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.PasswordChar = '\0';
            this.txt_DiaChi.PlaceholderText = "";
            this.txt_DiaChi.SelectedText = "";
            this.txt_DiaChi.Size = new System.Drawing.Size(459, 42);
            this.txt_DiaChi.TabIndex = 16;
            // 
            // txt_Email
            // 
            this.txt_Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Email.DefaultText = "";
            this.txt_Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_Email.Location = new System.Drawing.Point(536, 226);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.PasswordChar = '\0';
            this.txt_Email.PlaceholderText = "";
            this.txt_Email.SelectedText = "";
            this.txt_Email.Size = new System.Drawing.Size(459, 42);
            this.txt_Email.TabIndex = 15;
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_TenNCC.DefaultText = "";
            this.txt_TenNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_TenNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_TenNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_TenNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_TenNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_TenNCC.Location = new System.Drawing.Point(536, 176);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.PasswordChar = '\0';
            this.txt_TenNCC.PlaceholderText = "";
            this.txt_TenNCC.SelectedText = "";
            this.txt_TenNCC.Size = new System.Drawing.Size(459, 42);
            this.txt_TenNCC.TabIndex = 14;
            // 
            // txt_MaNCC
            // 
            this.txt_MaNCC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaNCC.DefaultText = "";
            this.txt_MaNCC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_MaNCC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_MaNCC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNCC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_MaNCC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNCC.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaNCC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_MaNCC.Location = new System.Drawing.Point(536, 126);
            this.txt_MaNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt_MaNCC.Name = "txt_MaNCC";
            this.txt_MaNCC.PasswordChar = '\0';
            this.txt_MaNCC.PlaceholderText = "";
            this.txt_MaNCC.SelectedText = "";
            this.txt_MaNCC.Size = new System.Drawing.Size(459, 42);
            this.txt_MaNCC.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label11.Location = new System.Drawing.Point(281, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(177, 28);
            this.label11.TabIndex = 5;
            this.label11.Text = "Trạng thái hợp tác:";
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
            this.label9.Size = new System.Drawing.Size(77, 28);
            this.label9.TabIndex = 3;
            this.label9.Text = "Địa chỉ:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label8.Location = new System.Drawing.Point(281, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label7.Location = new System.Drawing.Point(281, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 28);
            this.label7.TabIndex = 1;
            this.label7.Text = "Tên nhà cung cấp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic);
            this.label6.Location = new System.Drawing.Point(281, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã nhà cung cấp:";
            // 
            // Form_NhaCungCap
            // 
            this.ClientSize = new System.Drawing.Size(1385, 892);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_NhaCungCap";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_NhaCungCap)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_NhaCungCap;
        private Guna.UI2.WinForms.Guna2Button btn_TimKiem_NCC;
        private Guna.UI2.WinForms.Guna2Button btn_Add_NhaCungCap;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txt_TrangThaiHopTac;
        private Guna.UI2.WinForms.Guna2TextBox txt_SDT;
        private Guna.UI2.WinForms.Guna2TextBox txt_DiaChi;
        private Guna.UI2.WinForms.Guna2TextBox txt_Email;
        private Guna.UI2.WinForms.Guna2TextBox txt_TenNCC;
        private Guna.UI2.WinForms.Guna2TextBox txt_MaNCC;
        private Guna.UI2.WinForms.Guna2Button btn_Them_NCC;
        private System.Windows.Forms.Label label19;
        private Guna.UI2.WinForms.Guna2Button btn_Sua_NCC;
        private Guna.UI2.WinForms.Guna2Button btn_Xoa_NCC;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThaiHopTac;
    }
}