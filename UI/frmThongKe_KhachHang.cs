using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Entyti;
using DevExpress.XtraCharts;
using BUS;
using System.Collections;

namespace Home
{
    public partial class frmThongKe_KhachHang : DevExpress.XtraEditors.XtraForm
    {
        frmHome frm;

        public frmThongKe_KhachHang()
        {
            InitializeComponent();
        }

        public frmThongKe_KhachHang(frmHome sql)
        {
            InitializeComponent();
            frm = sql;
        }

        public int khachNam(ArrayList ds)
        {
            ChiTietThuePhongBUS cttpbus = new ChiTietThuePhongBUS();
            KhachHangBUS khbus = new KhachHangBUS();
            int soLuongNam = 0;
            foreach (string item in ds)
            {
                foreach (var cttp in cttpbus.getChiTietThuePhong_By_MaThue(item))
                {
                    if (khbus.kiemTraNamNu(cttp.MaKhach))
                    {
                        soLuongNam++;
                    }
                }
            }
            return soLuongNam;
        }

        public int khachNu(ArrayList ds)
        {
            ChiTietThuePhongBUS cttpbus = new ChiTietThuePhongBUS();
            KhachHangBUS khbus = new KhachHangBUS();
            int soLuongNu = 0;
            foreach (string item in ds)
            {
                foreach (var cttp in cttpbus.getChiTietThuePhong_By_MaThue(item))
                {
                    if (!khbus.kiemTraNamNu(cttp.MaKhach))
                    {
                        soLuongNu++;
                    }
                }
            }
            return soLuongNu;
        }

        private void frmThongKe_KhachHang_Load(object sender, EventArgs e)
        {
            cboLuaChon.SelectedIndex = 0;
            int nam = DateTime.Now.Year - 9;
            for (int i = nam; i <= nam + 9; i++)
            {
                cboNam.Items.Add(i);
            }
            cboNam.SelectedIndex = 9;
        }

        public DateTime FirstDayOfYear(DateTime dt)
        {
            return new DateTime(dt.Year, 1, 1);
        }

        private void cboLuaChon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedIndex == 0)
            {
                eThongKeBindingSource.Clear();
                cboNam.Visible = true;
                HoaDonTienPhongBUS hdtpbus = new HoaDonTienPhongBUS();
                XYDiagram diagram = (XYDiagram)chartLuongKhach.Diagram;
                diagram.AxisX.DateTimeScaleOptions.AutoGrid = true;
                diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month;
                diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Month;
                for (int i = 1; i < 13; i++)
                {
                    eThongKe tk = new eThongKe();
                    tk.slNam = khachNam(hdtpbus.getMaThue_byThang_Nam(i, Convert.ToInt32(cboNam.SelectedItem)));
                    tk.slNu = khachNu(hdtpbus.getMaThue_byThang_Nam(i, Convert.ToInt32(cboNam.SelectedItem)));
                    tk.sl = tk.slNam + tk.slNu;
                    tk.donVi = Convert.ToInt32(i);
                    eThongKeBindingSource.Add(tk);
                }
            }

            if (cboLuaChon.SelectedIndex == 1)
            {
                eThongKeBindingSource.Clear();
                cboNam.Visible = true;
                HoaDonTienPhongBUS hdtpbus = new HoaDonTienPhongBUS();
                XYDiagram diagram = (XYDiagram)chartLuongKhach.Diagram;
                diagram.AxisX.DateTimeScaleOptions.AutoGrid = true;
                diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Quarter;
                diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Quarter;
                for (int i = 1; i <= 4; i++)
                {
                    eThongKe tk = new eThongKe();
                    tk.slNam = khachNam(hdtpbus.getMaThue_byQui_Nam(i, Convert.ToInt32(cboNam.SelectedItem)));
                    tk.slNu = khachNu(hdtpbus.getMaThue_byQui_Nam(i, Convert.ToInt32(cboNam.SelectedItem)));
                    tk.sl = tk.slNam + tk.slNu;
                    tk.donVi = Convert.ToInt32(i);
                    eThongKeBindingSource.Add(tk);
                }
            }

            if (cboLuaChon.SelectedIndex == 2)
            {
                eThongKeBindingSource.Clear();
                DateTime dt = DateTime.Now.AddYears(-10);
                cboNam.Visible = false;
                HoaDonTienPhongBUS hdtpbus = new HoaDonTienPhongBUS();
                XYDiagram diagram = (XYDiagram)chartLuongKhach.Diagram;
                diagram.AxisX.DateTimeScaleOptions.AutoGrid = true;
                diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Year;
                diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Year;
                for (int i = 1; i < 11; i++)
                {
                    eThongKe tk = new eThongKe();
                    tk.slNam = khachNam(hdtpbus.getMaThue_byNam(FirstDayOfYear(dt).AddYears(i).Year));
                    tk.slNu = khachNu(hdtpbus.getMaThue_byNam(FirstDayOfYear(dt).AddYears(i).Year));
                    tk.sl = tk.slNam + tk.slNu;
                    tk.donVi = (FirstDayOfYear(dt).AddYears(i).Year);
                    eThongKeBindingSource.Add(tk);
                }
            }
        }

        private void cboNam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLuaChon.SelectedIndex == 0)
            {
                eThongKeBindingSource.Clear();
                cboNam.Visible = true;
                HoaDonTienPhongBUS hdtpbus = new HoaDonTienPhongBUS();
                XYDiagram diagram = (XYDiagram)chartLuongKhach.Diagram;
                diagram.AxisX.DateTimeScaleOptions.AutoGrid = true;
                diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Month;
                diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Month;
                for (int i = 1; i < 13; i++)
                {
                    eThongKe tk = new eThongKe();
                    tk.slNam = khachNam(hdtpbus.getMaThue_byThang_Nam(i, Convert.ToInt32(cboNam.SelectedItem)));
                    tk.slNu = khachNu(hdtpbus.getMaThue_byThang_Nam(i, Convert.ToInt32(cboNam.SelectedItem)));
                    tk.sl = tk.slNam + tk.slNu;
                    tk.donVi = Convert.ToInt32(i);
                    eThongKeBindingSource.Add(tk);
                }
            }

            if (cboLuaChon.SelectedIndex == 1)
            {
                eThongKeBindingSource.Clear();
                cboNam.Visible = true;
                HoaDonTienPhongBUS hdtpbus = new HoaDonTienPhongBUS();
                XYDiagram diagram = (XYDiagram)chartLuongKhach.Diagram;
                diagram.AxisX.DateTimeScaleOptions.AutoGrid = true;
                diagram.AxisX.DateTimeScaleOptions.MeasureUnit = DateTimeMeasureUnit.Quarter;
                diagram.AxisX.DateTimeScaleOptions.GridAlignment = DateTimeGridAlignment.Quarter;
                for (int i = 1; i <= 4; i++)
                {
                    eThongKe tk = new eThongKe();
                    tk.slNam = khachNam(hdtpbus.getMaThue_byQui_Nam(i, Convert.ToInt32(cboNam.SelectedItem)));
                    tk.slNu = khachNu(hdtpbus.getMaThue_byQui_Nam(i, Convert.ToInt32(cboNam.SelectedItem)));
                    tk.sl = tk.slNam + tk.slNu;
                    tk.donVi = Convert.ToInt32(i);
                    eThongKeBindingSource.Add(tk);
                }
            }
        }

        private void frmThongKe_KhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            PhongBUS pbus = new PhongBUS();
            if (frm.ExitAllForm())
            {
                frm.AnflowLayoutPanel();
                frm.TaoGiaoDienPhong(pbus.getallphong(), pbus.gettinhtrangp(false), pbus.gettinhtrangp(true), "Phòng");
            }
        }
    }
}