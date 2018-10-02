using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class GiaBanThanhPhamModel
    {
        private static int lastId = 0;
        public int Id { get; set; }
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public decimal ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public int IdTinhGia { get; set; }
        public string LoaiThanhPham { get; set; }
        public GiaBanThanhPhamModel(string ten, int soLuong, string donViTinh, decimal thanhTien, string ghiChu, string loaiThanhPhamSauIn)
        {
            this.Ten = ten;
            this.ThanhTien = thanhTien;
            this.GhiChu = ghiChu;
            this.DonViTinh = donViTinh;
            this.SoLuong = soLuong;
            this.LoaiThanhPham = loaiThanhPhamSauIn;
            //giả lập Id
            lastId += 1;
            this.Id = lastId;

        }
    }
}
