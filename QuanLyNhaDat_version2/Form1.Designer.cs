namespace QuanLyNhaDat_version2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.btnSapXep = new System.Windows.Forms.Button();
            this.btnXuatExcel = new System.Windows.Forms.Button();
            this.btnMerge = new System.Windows.Forms.Button();
            this.btnNapDuLieu = new System.Windows.Forms.Button();
            this.cbPhuong = new System.Windows.Forms.ComboBox();
            this.cbQuan = new System.Windows.Forms.ComboBox();
            this.btnMoFileMerge = new System.Windows.Forms.Button();
            this.btnMoFile = new System.Windows.Forms.Button();
            this.cbLoaiNha = new System.Windows.Forms.ComboBox();
            this.cbMucDichSuDung = new System.Windows.Forms.ComboBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtFileNameMerge = new System.Windows.Forms.TextBox();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.txtGiaTien = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.txtChuSoHuu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.dgvDanhSachNhaDat = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dienTich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuSoHuu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiNha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucDichSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhaDat)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.btnSapXep);
            this.groupBox1.Controls.Add(this.btnXoaTatCa);
            this.groupBox1.Controls.Add(this.btnXuatExcel);
            this.groupBox1.Controls.Add(this.btnNapDuLieu);
            this.groupBox1.Controls.Add(this.cbPhuong);
            this.groupBox1.Controls.Add(this.cbQuan);
            this.groupBox1.Controls.Add(this.btnMoFile);
            this.groupBox1.Controls.Add(this.cbLoaiNha);
            this.groupBox1.Controls.Add(this.cbMucDichSuDung);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtFilename);
            this.groupBox1.Controls.Add(this.txtGiaTien);
            this.groupBox1.Controls.Add(this.txtDienTich);
            this.groupBox1.Controls.Add(this.txtChuSoHuu);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(7, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1061, 173);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin thửa đất";
            // 
            // btnXoaTatCa
            // 
            this.btnXoaTatCa.BackColor = System.Drawing.Color.Red;
            this.btnXoaTatCa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaTatCa.ForeColor = System.Drawing.Color.White;
            this.btnXoaTatCa.Location = new System.Drawing.Point(962, 135);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(95, 28);
            this.btnXoaTatCa.TabIndex = 11;
            this.btnXoaTatCa.Text = "Xóa tất cả";
            this.btnXoaTatCa.UseVisualStyleBackColor = false;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            // 
            // btnSapXep
            // 
            this.btnSapXep.ForeColor = System.Drawing.Color.Black;
            this.btnSapXep.Location = new System.Drawing.Point(855, 135);
            this.btnSapXep.Name = "btnSapXep";
            this.btnSapXep.Size = new System.Drawing.Size(95, 28);
            this.btnSapXep.TabIndex = 10;
            this.btnSapXep.Text = "Heap sort";
            this.btnSapXep.UseVisualStyleBackColor = true;
            this.btnSapXep.Click += new System.EventHandler(this.btnSapXep_Click);
            // 
            // btnXuatExcel
            // 
            this.btnXuatExcel.ForeColor = System.Drawing.Color.Black;
            this.btnXuatExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExcel.Image")));
            this.btnXuatExcel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatExcel.Location = new System.Drawing.Point(749, 135);
            this.btnXuatExcel.Name = "btnXuatExcel";
            this.btnXuatExcel.Size = new System.Drawing.Size(95, 28);
            this.btnXuatExcel.TabIndex = 9;
            this.btnXuatExcel.Text = "Xuất excel";
            this.btnXuatExcel.UseVisualStyleBackColor = true;
            this.btnXuatExcel.Click += new System.EventHandler(this.btnXuatExcel_Click);
            // 
            // btnMerge
            // 
            this.btnMerge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnMerge.ForeColor = System.Drawing.Color.Black;
            this.btnMerge.Location = new System.Drawing.Point(205, 80);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(110, 28);
            this.btnMerge.TabIndex = 9;
            this.btnMerge.Text = "Merge";
            this.btnMerge.UseVisualStyleBackColor = false;
            this.btnMerge.Click += new System.EventHandler(this.btnMerge_Click);
            // 
            // btnNapDuLieu
            // 
            this.btnNapDuLieu.ForeColor = System.Drawing.Color.Black;
            this.btnNapDuLieu.Location = new System.Drawing.Point(643, 135);
            this.btnNapDuLieu.Name = "btnNapDuLieu";
            this.btnNapDuLieu.Size = new System.Drawing.Size(95, 28);
            this.btnNapDuLieu.TabIndex = 9;
            this.btnNapDuLieu.Text = "Nạp dữ liệu";
            this.btnNapDuLieu.UseVisualStyleBackColor = true;
            this.btnNapDuLieu.Click += new System.EventHandler(this.btnNapDuLieu_Click);
            // 
            // cbPhuong
            // 
            this.cbPhuong.FormattingEnabled = true;
            this.cbPhuong.Location = new System.Drawing.Point(453, 140);
            this.cbPhuong.Name = "cbPhuong";
            this.cbPhuong.Size = new System.Drawing.Size(184, 23);
            this.cbPhuong.TabIndex = 8;
            // 
            // cbQuan
            // 
            this.cbQuan.FormattingEnabled = true;
            this.cbQuan.Location = new System.Drawing.Point(283, 140);
            this.cbQuan.Name = "cbQuan";
            this.cbQuan.Size = new System.Drawing.Size(164, 23);
            this.cbQuan.TabIndex = 8;
            this.cbQuan.SelectedIndexChanged += new System.EventHandler(this.cbQuan_SelectedIndexChanged);
            // 
            // btnMoFileMerge
            // 
            this.btnMoFileMerge.ForeColor = System.Drawing.Color.Black;
            this.btnMoFileMerge.Location = new System.Drawing.Point(255, 40);
            this.btnMoFileMerge.Name = "btnMoFileMerge";
            this.btnMoFileMerge.Size = new System.Drawing.Size(53, 23);
            this.btnMoFileMerge.TabIndex = 1;
            this.btnMoFileMerge.Text = "Mở file";
            this.btnMoFileMerge.UseVisualStyleBackColor = true;
            this.btnMoFileMerge.Click += new System.EventHandler(this.btnMoFileMerge_Click);
            // 
            // btnMoFile
            // 
            this.btnMoFile.ForeColor = System.Drawing.Color.Black;
            this.btnMoFile.Location = new System.Drawing.Point(643, 26);
            this.btnMoFile.Name = "btnMoFile";
            this.btnMoFile.Size = new System.Drawing.Size(66, 23);
            this.btnMoFile.TabIndex = 1;
            this.btnMoFile.Text = "Mở file";
            this.btnMoFile.UseVisualStyleBackColor = true;
            this.btnMoFile.Click += new System.EventHandler(this.btnMoFile_Click);
            // 
            // cbLoaiNha
            // 
            this.cbLoaiNha.FormattingEnabled = true;
            this.cbLoaiNha.Items.AddRange(new object[] {
            "Nhà cấp 1",
            "Nhà cấp 2",
            "Nhà cấp 3",
            "Nhà cấp 4"});
            this.cbLoaiNha.Location = new System.Drawing.Point(453, 108);
            this.cbLoaiNha.Name = "cbLoaiNha";
            this.cbLoaiNha.Size = new System.Drawing.Size(184, 23);
            this.cbLoaiNha.TabIndex = 7;
            // 
            // cbMucDichSuDung
            // 
            this.cbMucDichSuDung.FormattingEnabled = true;
            this.cbMucDichSuDung.Items.AddRange(new object[] {
            "Kinh doanh",
            "Nhà ở"});
            this.cbMucDichSuDung.Location = new System.Drawing.Point(453, 66);
            this.cbMucDichSuDung.Name = "cbMucDichSuDung";
            this.cbMucDichSuDung.Size = new System.Drawing.Size(184, 23);
            this.cbMucDichSuDung.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(93, 141);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(184, 22);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtFileNameMerge
            // 
            this.txtFileNameMerge.Location = new System.Drawing.Point(23, 41);
            this.txtFileNameMerge.Name = "txtFileNameMerge";
            this.txtFileNameMerge.ReadOnly = true;
            this.txtFileNameMerge.Size = new System.Drawing.Size(226, 22);
            this.txtFileNameMerge.TabIndex = 6;
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(453, 27);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(184, 22);
            this.txtFilename.TabIndex = 6;
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.Location = new System.Drawing.Point(93, 102);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.Size = new System.Drawing.Size(184, 22);
            this.txtGiaTien.TabIndex = 6;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(93, 66);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(184, 22);
            this.txtDienTich.TabIndex = 6;
            // 
            // txtChuSoHuu
            // 
            this.txtChuSoHuu.Location = new System.Drawing.Point(93, 29);
            this.txtChuSoHuu.Name = "txtChuSoHuu";
            this.txtChuSoHuu.Size = new System.Drawing.Size(184, 22);
            this.txtChuSoHuu.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giá tiền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(339, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mục đích sử dụng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Diện tích(m2):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(339, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "File name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(339, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loại nhà:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chủ sở hữu:";
            // 
            // btnThem
            // 
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(7, 217);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 29);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(114, 217);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 29);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(219, 217);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 29);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgvDanhSachNhaDat
            // 
            this.dgvDanhSachNhaDat.AllowUserToAddRows = false;
            this.dgvDanhSachNhaDat.BackgroundColor = System.Drawing.Color.White;
            this.dgvDanhSachNhaDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachNhaDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.diaChi,
            this.dienTich,
            this.chuSoHuu,
            this.loaiNha,
            this.mucDichSuDung,
            this.giaTien});
            this.dgvDanhSachNhaDat.Location = new System.Drawing.Point(7, 252);
            this.dgvDanhSachNhaDat.Name = "dgvDanhSachNhaDat";
            this.dgvDanhSachNhaDat.Size = new System.Drawing.Size(1061, 330);
            this.dgvDanhSachNhaDat.TabIndex = 2;
            this.dgvDanhSachNhaDat.SelectionChanged += new System.EventHandler(this.dgvDanhSachNhaDat_SelectionChanged);
            // 
            // STT
            // 
            this.STT.DataPropertyName = "stt";
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.Width = 40;
            // 
            // diaChi
            // 
            this.diaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.diaChi.DataPropertyName = "diaChi";
            this.diaChi.HeaderText = "Địa chỉ";
            this.diaChi.Name = "diaChi";
            this.diaChi.Width = 310;
            // 
            // dienTich
            // 
            this.dienTich.DataPropertyName = "dienTich";
            this.dienTich.HeaderText = "Diện tích";
            this.dienTich.Name = "dienTich";
            this.dienTich.Width = 85;
            // 
            // chuSoHuu
            // 
            this.chuSoHuu.DataPropertyName = "chuSoHuu";
            this.chuSoHuu.HeaderText = "Chủ sở hữu";
            this.chuSoHuu.Name = "chuSoHuu";
            this.chuSoHuu.Width = 160;
            // 
            // loaiNha
            // 
            this.loaiNha.DataPropertyName = "loaiNha";
            this.loaiNha.HeaderText = "Loại nhà";
            this.loaiNha.Name = "loaiNha";
            this.loaiNha.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.loaiNha.Width = 120;
            // 
            // mucDichSuDung
            // 
            this.mucDichSuDung.DataPropertyName = "mucDichSuDung";
            this.mucDichSuDung.HeaderText = "Mục đích sử dụng";
            this.mucDichSuDung.Name = "mucDichSuDung";
            this.mucDichSuDung.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.mucDichSuDung.Width = 150;
            // 
            // giaTien
            // 
            this.giaTien.DataPropertyName = "giaTien";
            this.giaTien.HeaderText = "Giá tiền";
            this.giaTien.Name = "giaTien";
            this.giaTien.Width = 152;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(460, 217);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(76, 29);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(554, 217);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(90, 29);
            this.btnHuy.TabIndex = 1;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(861, 224);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(207, 22);
            this.txtTimKiem.TabIndex = 6;
            this.txtTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTimKiem_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(798, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tìm kiếm:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(390, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(312, 26);
            this.label9.TabIndex = 9;
            this.label9.Text = "CHƯƠNG TRÌNH QUẢN LÝ NHÀ ĐẤT";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnMerge);
            this.panel1.Controls.Add(this.txtFileNameMerge);
            this.panel1.Controls.Add(this.btnMoFileMerge);
            this.panel1.Location = new System.Drawing.Point(732, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 112);
            this.panel1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(4, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(171, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Merge danh sách nhà đất khác";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1070, 586);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvDanhSachNhaDat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachNhaDat)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.TextBox txtChuSoHuu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaTien;
        private System.Windows.Forms.ComboBox cbLoaiNha;
        private System.Windows.Forms.ComboBox cbMucDichSuDung;
        private System.Windows.Forms.ComboBox cbPhuong;
        private System.Windows.Forms.ComboBox cbQuan;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXuatExcel;
        private System.Windows.Forms.Button btnNapDuLieu;
        private System.Windows.Forms.DataGridView dgvDanhSachNhaDat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnMoFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSapXep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dienTich;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuSoHuu;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiNha;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucDichSuDung;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTien;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.Button btnMoFileMerge;
        private System.Windows.Forms.TextBox txtFileNameMerge;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
    }
}

