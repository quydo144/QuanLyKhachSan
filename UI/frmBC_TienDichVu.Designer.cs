namespace Home
{
    partial class frmBC_TienDichVu
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.cboNgayThang = new System.Windows.Forms.ComboBox();
            this.gdvBC_TienDV = new DevExpress.XtraGrid.GridControl();
            this.gridViewTienDV = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenKhach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tienDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ngayLap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBC_TienDV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTienDV)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Chọn nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Lựa chọn";
            // 
            // cboNhanVien
            // 
            this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNhanVien.FormattingEnabled = true;
            this.cboNhanVien.Location = new System.Drawing.Point(162, 12);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(288, 32);
            this.cboNhanVien.TabIndex = 9;
            this.cboNhanVien.SelectedIndexChanged += new System.EventHandler(this.cboNhanVien_SelectedIndexChanged);
            // 
            // cboNgayThang
            // 
            this.cboNgayThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNgayThang.FormattingEnabled = true;
            this.cboNgayThang.Items.AddRange(new object[] {
            "Trong ngày",
            "Trong tuần",
            "Trong tháng",
            "Trong năm",
            "Tất cả",
            "Tuỳ chọn"});
            this.cboNgayThang.Location = new System.Drawing.Point(610, 12);
            this.cboNgayThang.Name = "cboNgayThang";
            this.cboNgayThang.Size = new System.Drawing.Size(169, 32);
            this.cboNgayThang.TabIndex = 8;
            this.cboNgayThang.SelectedIndexChanged += new System.EventHandler(this.cboNgayThang_SelectedIndexChanged);
            // 
            // gdvBC_TienDV
            // 
            this.gdvBC_TienDV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gdvBC_TienDV.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gdvBC_TienDV.Location = new System.Drawing.Point(12, 141);
            this.gdvBC_TienDV.MainView = this.gridViewTienDV;
            this.gdvBC_TienDV.Name = "gdvBC_TienDV";
            this.gdvBC_TienDV.Size = new System.Drawing.Size(1440, 588);
            this.gdvBC_TienDV.TabIndex = 12;
            this.gdvBC_TienDV.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTienDV});
            // 
            // gridViewTienDV
            // 
            this.gridViewTienDV.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tenPhong,
            this.tenKhach,
            this.tienDV,
            this.ngayLap});
            this.gridViewTienDV.GridControl = this.gdvBC_TienDV;
            this.gridViewTienDV.Name = "gridViewTienDV";
            this.gridViewTienDV.OptionsView.ShowGroupPanel = false;
            // 
            // tenPhong
            // 
            this.tenPhong.Caption = "Phòng";
            this.tenPhong.FieldName = "Phòng";
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.OptionsColumn.AllowEdit = false;
            this.tenPhong.OptionsColumn.AllowFocus = false;
            this.tenPhong.Visible = true;
            this.tenPhong.VisibleIndex = 0;
            // 
            // tenKhach
            // 
            this.tenKhach.Caption = "Khách hàng";
            this.tenKhach.FieldName = "Khách hàng";
            this.tenKhach.Name = "tenKhach";
            this.tenKhach.OptionsColumn.AllowEdit = false;
            this.tenKhach.OptionsColumn.AllowFocus = false;
            this.tenKhach.Visible = true;
            this.tenKhach.VisibleIndex = 1;
            // 
            // tienDV
            // 
            this.tienDV.Caption = "Tiền DV";
            this.tienDV.DisplayFormat.FormatString = "{0:#,##0}";
            this.tienDV.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.tienDV.FieldName = "Tiền DV";
            this.tienDV.Name = "tienDV";
            this.tienDV.OptionsColumn.AllowEdit = false;
            this.tienDV.OptionsColumn.AllowFocus = false;
            this.tienDV.Visible = true;
            this.tienDV.VisibleIndex = 2;
            // 
            // ngayLap
            // 
            this.ngayLap.Caption = "Ngày Lập";
            this.ngayLap.FieldName = "Ngày Lập";
            this.ngayLap.Name = "ngayLap";
            this.ngayLap.OptionsColumn.AllowEdit = false;
            this.ngayLap.OptionsColumn.AllowFocus = false;
            this.ngayLap.Visible = true;
            this.ngayLap.VisibleIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(851, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Từ ngày";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(940, 15);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(180, 32);
            this.dtpStart.TabIndex = 14;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpStart_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1126, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Đến ngày";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(1227, 9);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(180, 32);
            this.dtpEnd.TabIndex = 16;
            this.dtpEnd.ValueChanged += new System.EventHandler(this.dtpEnd_ValueChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(329, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tổng tiền";
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTongTien.Location = new System.Drawing.Point(495, 86);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(97, 26);
            this.lblTongTien.TabIndex = 17;
            this.lblTongTien.Text = "Tổng tiền";
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            this.btnIn.Location = new System.Drawing.Point(802, 79);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(132, 38);
            this.btnIn.TabIndex = 18;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmBC_TienDichVu
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(209)))), ((int)(((byte)(237)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1464, 741);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gdvBC_TienDV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboNhanVien);
            this.Controls.Add(this.cboNgayThang);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBC_TienDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo tiền dịch vụ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBC_TienDichVu_FormClosing);
            this.Load += new System.EventHandler(this.frmBC_TienDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gdvBC_TienDV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTienDV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboNgayThang;
        private DevExpress.XtraGrid.GridControl gdvBC_TienDV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTienDV;
        private DevExpress.XtraGrid.Columns.GridColumn tenPhong;
        private DevExpress.XtraGrid.Columns.GridColumn tenKhach;
        private DevExpress.XtraGrid.Columns.GridColumn tienDV;
        private DevExpress.XtraGrid.Columns.GridColumn ngayLap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.Button btnIn;
    }
}