using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class GiaBanThanhPhamGiaCongModel: GiaBanThanhPhamModel
    {

        static int lastId = 0;
        public int MucLoiNhuan { get; set; }
        public GiaBanThanhPhamGiaCongModel(string ten, int soLuong, string donViTinh, decimal thanhTien, string ghiChu, string loaiThanhPhamSauIn, int mucLoiNhuan)
        {
            base.Ten = ten;
            base.ThanhTien = thanhTien;
            base.GhiChu = ghiChu;
            base.DonViTinh = donViTinh;
            base.SoLuong = soLuong;
            base.LoaiThanhPham = loaiThanhPhamSauIn;
            this.MucLoiNhuan = mucLoiNhuan;
            //giả lập Id
            lastId += 1;
            this.Id = lastId;
        }
        public decimal GiaBan 
        {

            get
            {
                decimal kq = 0;
                if (this.MucLoiNhuan >0 && this.MucLoiNhuan <100)
                {
                    kq = ThanhTien / (1 - (decimal)MucLoiNhuan / 100);
                }
                    return kq;
            }
        }

    }
}
