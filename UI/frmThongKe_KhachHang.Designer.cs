namespace Home
{
    partial class frmThongKe_KhachHang
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
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.LineSeriesView lineSeriesView1 = new DevExpress.XtraCharts.LineSeriesView();
            this.chartLuongKhach = new DevExpress.XtraCharts.ChartControl();
            this.eThongKeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboNam = new System.Windows.Forms.ComboBox();
            this.cboLuaChon = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuongKhach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eThongKeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // chartLuongKhach
            // 
            this.chartLuongKhach.DataSource = this.eThongKeBindingSource;
            xyDiagram1.AxisX.MinorCount = 10;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartLuongKhach.Diagram = xyDiagram1;
            this.chartLuongKhach.Legend.Name = "Default Legend";
            this.chartLuongKhach.Location = new System.Drawing.Point(23, 75);
            this.chartLuongKhach.Name = "chartLuongKhach";
            series1.ArgumentDataMember = "donVi";
            series1.Name = "Lượng khách";
            series1.ValueDataMembersSerializable = "sl";
            series1.View = lineSeriesView1;
            this.chartLuongKhach.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartLuongKhach.Size = new System.Drawing.Size(1435, 629);
            this.chartLuongKhach.TabIndex = 0;
            // 
            // eThongKeBindingSource
            // 
            this.eThongKeBindingSource.DataSource = typeof(Entyti.eThongKe);
            // 
            // cboNam
            // 
            this.cboNam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNam.FormattingEnabled = true;
            this.cboNam.Location = new System.Drawing.Point(916, 22);
            this.cboNam.Name = "cboNam";
            this.cboNam.Size = new System.Drawing.Size(218, 32);
            this.cboNam.TabIndex = 2;
            this.cboNam.SelectedIndexChanged += new System.EventHandler(this.cboNam_SelectedIndexChanged);
            // 
            // cboLuaChon
            // 
            this.cboLuaChon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLuaChon.FormattingEnabled = true;
            this.cboLuaChon.Items.AddRange(new object[] {
            "Tháng",
            "Quý",
            "Năm"});
            this.cboLuaChon.Location = new System.Drawing.Point(328, 22);
            this.cboLuaChon.Name = "cboLuaChon";
            this.cboLuaChon.Size = new System.Drawing.Size(218, 32);
            this.cboLuaChon.TabIndex = 3;
            this.cboLuaChon.SelectedIndexChanged += new System.EventHandler(this.cboLuaChon_SelectedIndexChanged);
            // 
            // frmThongKe_KhachHang
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1477, 742);
            this.Controls.Add(this.cboNam);
            this.Controls.Add(this.cboLuaChon);
            this.Controls.Add(this.chartLuongKhach);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmThongKe_KhachHang";
            this.Text = "Lượng khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThongKe_KhachHang_FormClosing);
            this.Load += new System.EventHandler(this.frmThongKe_KhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(lineSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartLuongKhach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eThongKeBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartLuongKhach;
        private System.Windows.Forms.ComboBox cboNam;
        private System.Windows.Forms.ComboBox cboLuaChon;
        private System.Windows.Forms.BindingSource eThongKeBindingSource;
    }
}