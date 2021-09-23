using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace _1911194_voaiquoc_lab04
{
    public class SinhVien
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Lop { get; set; }
        public string Hinh { get; set; }
        public bool GioiTinh { get; set; }
        
        public string Email { get; set; }
        public string SoDT { get; set; }

        public SinhVien()
        {

        }
        public SinhVien(string ms, string ht, DateTime ngay, string dc, string lop, string hinh, bool gt, string email,string sdt)
        {
            this.MSSV = ms;
            this.HoTen = ht;
            this.NgaySinh = ngay;
            this.DiaChi = dc;
            this.Lop = lop;
            this.Hinh = hinh;
            this.GioiTinh = gt;
            this.Email = email;
            this.SoDT = sdt;
        }

      
    }
}
