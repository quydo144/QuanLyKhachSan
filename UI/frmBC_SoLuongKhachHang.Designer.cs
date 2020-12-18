﻿namespace Home
{
    partial class frmBC_SoLuongKhachHang
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
            this.btnIn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongKhach = new System.Windows.Forms.Label();
            this.tgNhanPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tenPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridViewLuongKhach = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tenKhach = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.soDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gdvBC_LuongKhach = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLuongKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBC_LuongKhach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(210)))), ((int)(((byte)(242)))));
            this.btnIn.Location = new System.Drawing.Point(1068, 6);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(143, 40);
            this.btnIn.TabIndex = 30;
            this.btnIn.Text = "In báo cáo";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(199, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tổng khách";
            // 
            // lblTongKhach
            // 
            this.lblTongKhach.AutoSize = true;
            this.lblTongKhach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTongKhach.Location = new System.Drawing.Point(321, 14);
            this.lblTongKhach.Name = "lblTongKhach";
            this.lblTongKhach.Size = new System.Drawing.Size(97, 26);
            this.lblTongKhach.TabIndex = 29;
            this.lblTongKhach.Text = "Tổng tiền";
            // 
            // tgNhanPhong
            // 
            this.tgNhanPhong.Caption = "Thời gian nhận phòng";
            this.tgNhanPhong.FieldName = "Thời gian nhận phòng";
            this.tgNhanPhong.Name = "tgNhanPhong";
            this.tgNhanPhong.OptionsColumn.AllowEdit = false;
            this.tgNhanPhong.OptionsColumn.AllowFocus = false;
            this.tgNhanPhong.Visible = true;
            this.tgNhanPhong.VisibleIndex = 4;
            // 
            // tenPhong
            // 
            this.tenPhong.Caption = "Tên phòng";
            this.tenPhong.FieldName = "Tên phòng";
            this.tenPhong.Name = "tenPhong";
            this.tenPhong.OptionsColumn.AllowEdit = false;
            this.tenPhong.OptionsColumn.AllowFocus = false;
            this.tenPhong.Visible = true;
            this.tenPhong.VisibleIndex = 0;
            // 
            // gridViewLuongKhach
            // 
            this.gridViewLuongKhach.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.tenPhong,
            this.tenKhach,
            this.soCMND,
            this.soDT,
            this.tgNhanPhong});
            this.gridViewLuongKhach.GridControl = this.gdvBC_LuongKhach;
            this.gridViewLuongKhach.Name = "gridViewLuongKhach";
            this.gridViewLuongKhach.OptionsView.ShowGroupPanel = false;
            // 
            // tenKhach
            // 
            this.tenKhach.Caption = "Tên khách hàng";
            this.tenKhach.FieldName = "Tên khách hàng";
            this.tenKhach.Name = "tenKhach";
            this.tenKhach.OptionsColumn.AllowEdit = false;
            this.tenKhach.OptionsColumn.AllowFocus = false;
            this.tenKhach.Visible = true;
            this.tenKhach.VisibleIndex = 1;
            // 
            // soCMND
            // 
            this.soCMND.Caption = "Số CMND";
            this.soCMND.FieldName = "Số CMND";
            this.soCMND.MinWidth = 25;
            this.soCMND.Name = "soCMND";
            this.soCMND.Visible = true;
            this.soCMND.VisibleIndex = 2;
            this.soCMND.Width = 94;
            // 
            // soDT
            // 
            this.soDT.Caption = "Số điện thoại";
            this.soDT.FieldName = "Số điện thoại";
            this.soDT.MinWidth = 25;
            this.soDT.Name = "soDT";
            this.soDT.Visible = true;
            this.soDT.VisibleIndex = 3;
            this.soDT.Width = 94;
            // 
            // gdvBC_LuongKhach
            // 
            this.gdvBC_LuongKhach.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(1);
            this.gdvBC_LuongKhach.Location = new System.Drawing.Point(12, 64);
            this.gdvBC_LuongKhach.MainView = this.gridViewLuongKhach;
            this.gdvBC_LuongKhach.Name = "gdvBC_LuongKhach";
            this.gdvBC_LuongKhach.Size = new System.Drawing.Size(1437, 653);
            this.gdvBC_LuongKhach.TabIndex = 23;
            this.gdvBC_LuongKhach.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLuongKhach});
            // 
            // frmBC_SoLuongKhachHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(209)))), ((int)(((byte)(237)))));
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1461, 729);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblTongKhach);
            this.Controls.Add(this.gdvBC_LuongKhach);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmBC_SoLuongKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Số lượng khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBC_SoLuongKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmBC_SoLuongKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLuongKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gdvBC_LuongKhach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongKhach;
        private DevExpress.XtraGrid.Columns.GridColumn tgNhanPhong;
        private DevExpress.XtraGrid.Columns.GridColumn tenPhong;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLuongKhach;
        private DevExpress.XtraGrid.Columns.GridColumn tenKhach;
        private DevExpress.XtraGrid.GridControl gdvBC_LuongKhach;
        private DevExpress.XtraGrid.Columns.GridColumn soCMND;
        private DevExpress.XtraGrid.Columns.GridColumn soDT;
    }
}