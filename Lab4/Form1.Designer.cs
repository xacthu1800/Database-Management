﻿namespace Lab4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maNhanVienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoTenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diaChiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPhongBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lab4DataSet = new Lab4.Lab4DataSet();
            this.nhanVienTableAdapter = new Lab4.Lab4DataSetTableAdapters.NhanVienTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDTnv = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtManhanvien = new System.Windows.Forms.TextBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaphongban = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnLammoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhanVienDataGridViewTextBoxColumn,
            this.hoTenDataGridViewTextBoxColumn,
            this.diaChiDataGridViewTextBoxColumn,
            this.soDTDataGridViewTextBoxColumn,
            this.maPhongBanDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.nhanVienBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(41, 383);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(885, 249);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maNhanVienDataGridViewTextBoxColumn
            // 
            this.maNhanVienDataGridViewTextBoxColumn.DataPropertyName = "maNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.HeaderText = "maNhanVien";
            this.maNhanVienDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maNhanVienDataGridViewTextBoxColumn.Name = "maNhanVienDataGridViewTextBoxColumn";
            this.maNhanVienDataGridViewTextBoxColumn.Width = 125;
            // 
            // hoTenDataGridViewTextBoxColumn
            // 
            this.hoTenDataGridViewTextBoxColumn.DataPropertyName = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.HeaderText = "hoTen";
            this.hoTenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.hoTenDataGridViewTextBoxColumn.Name = "hoTenDataGridViewTextBoxColumn";
            this.hoTenDataGridViewTextBoxColumn.Width = 125;
            // 
            // diaChiDataGridViewTextBoxColumn
            // 
            this.diaChiDataGridViewTextBoxColumn.DataPropertyName = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.HeaderText = "diaChi";
            this.diaChiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.diaChiDataGridViewTextBoxColumn.Name = "diaChiDataGridViewTextBoxColumn";
            this.diaChiDataGridViewTextBoxColumn.Width = 125;
            // 
            // soDTDataGridViewTextBoxColumn
            // 
            this.soDTDataGridViewTextBoxColumn.DataPropertyName = "soDT";
            this.soDTDataGridViewTextBoxColumn.HeaderText = "soDT";
            this.soDTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soDTDataGridViewTextBoxColumn.Name = "soDTDataGridViewTextBoxColumn";
            this.soDTDataGridViewTextBoxColumn.Width = 125;
            // 
            // maPhongBanDataGridViewTextBoxColumn
            // 
            this.maPhongBanDataGridViewTextBoxColumn.DataPropertyName = "maPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.HeaderText = "maPhongBan";
            this.maPhongBanDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.maPhongBanDataGridViewTextBoxColumn.Name = "maPhongBanDataGridViewTextBoxColumn";
            this.maPhongBanDataGridViewTextBoxColumn.Width = 125;
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.lab4DataSet;
            // 
            // lab4DataSet
            // 
            this.lab4DataSet.DataSetName = "Lab4DataSet";
            this.lab4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaphongban);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSDTnv);
            this.groupBox1.Controls.Add(this.txtDiachi);
            this.groupBox1.Controls.Add(this.txtManhanvien);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(41, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 186);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txtSDTnv
            // 
            this.txtSDTnv.Location = new System.Drawing.Point(644, 38);
            this.txtSDTnv.Name = "txtSDTnv";
            this.txtSDTnv.Size = new System.Drawing.Size(198, 34);
            this.txtSDTnv.TabIndex = 11;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(229, 126);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(198, 34);
            this.txtDiachi.TabIndex = 10;
            // 
            // txtManhanvien
            // 
            this.txtManhanvien.Location = new System.Drawing.Point(229, 84);
            this.txtManhanvien.Name = "txtManhanvien";
            this.txtManhanvien.Size = new System.Drawing.Size(198, 34);
            this.txtManhanvien.TabIndex = 9;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(229, 41);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(198, 34);
            this.txtHoten.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(473, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số ĐT";
            // 
            // txtMaphongban
            // 
            this.txtMaphongban.Location = new System.Drawing.Point(644, 87);
            this.txtMaphongban.Name = "txtMaphongban";
            this.txtMaphongban.Size = new System.Drawing.Size(198, 34);
            this.txtMaphongban.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(473, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Mã phòng ban";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "HỆ THỐNG QUẢN LÝ NHÂN VIÊN";
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(140, 301);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 51);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(297, 301);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(97, 51);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(455, 301);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(94, 51);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(752, 301);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(93, 51);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnLammoi
            // 
            this.btnLammoi.Location = new System.Drawing.Point(606, 301);
            this.btnLammoi.Name = "btnLammoi";
            this.btnLammoi.Size = new System.Drawing.Size(93, 51);
            this.btnLammoi.TabIndex = 8;
            this.btnLammoi.Text = "Làm mới";
            this.btnLammoi.UseVisualStyleBackColor = true;
            this.btnLammoi.Click += new System.EventHandler(this.btnLammoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 655);
            this.Controls.Add(this.btnLammoi);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lab4DataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Lab4DataSet lab4DataSet;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private Lab4DataSetTableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diaChiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDTDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhongBanDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSDTnv;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtManhanvien;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.TextBox txtMaphongban;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnLammoi;
    }
}

