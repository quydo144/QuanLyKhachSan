﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entyti;

namespace DAL
{
    public class LoaiPhongDAL
    {
        //dbQLKhachSanDataContext db = new dbQLKhachSanDataContext();
        Connect cn = new Connect();
        dbQLKhachSanDataContext db;
        public LoaiPhongDAL()
        {
            db = cn.connection();
        }


        public List<eLoaiPhong> getalllp()
        {
            var ls = (from x in db.LoaiPhongs select x).ToList();
            List<eLoaiPhong> list = new List<eLoaiPhong>();
            foreach (var item in ls)
            {
                eLoaiPhong lp = new eLoaiPhong();
                lp.MaLoaiPhong = item.maLoaiPhong.Trim();
                lp.TenLoaiPhong = item.tenLoaiPhong.Trim();
                lp.DonGia = Convert.ToDouble(item.donGia);
                lp.SoNguoi = Convert.ToInt32(item.soNguoiToiDa);
                list.Add(lp);
            }
            return list;
        }

        public double donGia(string maLoaiPhong)
        {
            LoaiPhong lp = db.LoaiPhongs.Where(n => n.maLoaiPhong.Trim().Equals(maLoaiPhong)).SingleOrDefault();
            return Convert.ToDouble(lp.donGia);
        }

        public string getma_ByTen(string tenLoaiPhong)
        {
            LoaiPhong lp = db.LoaiPhongs.Where(n => n.tenLoaiPhong.Trim().Equals(tenLoaiPhong.Trim())).SingleOrDefault();
            return lp.maLoaiPhong;
        }

        public string getTen_Byma(string ma)
        {
            LoaiPhong lp = db.LoaiPhongs.Where(n => n.maLoaiPhong.Trim().Equals(ma.Trim())).SingleOrDefault();
            return lp.tenLoaiPhong;
        }

        public List<eLoaiPhong> getDOnGia(double min, double max)
        {
            var ls = (from x in db.LoaiPhongs where Convert.ToDecimal(min) < x.donGia  && x.donGia <= Convert.ToDecimal(max) select x).ToList();
            List<eLoaiPhong> list = new List<eLoaiPhong>();
            foreach (var item in ls)
            {
                eLoaiPhong lp = new eLoaiPhong();
                lp.MaLoaiPhong = item.maLoaiPhong.Trim();
                lp.TenLoaiPhong = item.tenLoaiPhong.Trim();
                lp.DonGia = Convert.ToDouble(item.donGia);
                lp.SoNguoi = Convert.ToInt32(item.soNguoiToiDa);
                list.Add(lp);
            }
            return list;
        }

        public int getsoNguoi_ByID(string id)
        {
            LoaiPhong lp = db.LoaiPhongs.Where(n => n.maLoaiPhong.Equals(id.Trim())).SingleOrDefault();
            return (int)lp.soNguoiToiDa;
        }
    }
}
