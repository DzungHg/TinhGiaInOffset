using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class GiaBanThanhPhamTaiChoModel: GiaBanThanhPhamModel
    {
        static int lastId = 0;
        public GiaBanThanhPhamTaiChoModel(string ten, int soLuong, string donViTinh, decimal thanhTien, string ghiChu, string loaiThanhPhamSauIn)
        {
            base.Ten = ten;
            base.ThanhTien = thanhTien;
            base.GhiChu = ghiChu;
            base.DonViTinh = donViTinh;
            base.SoLuong = soLuong;
            base.LoaiThanhPham = loaiThanhPhamSauIn;
            //giả lập Id
            lastId += 1;
            this.Id = lastId;
        }

    }
}
