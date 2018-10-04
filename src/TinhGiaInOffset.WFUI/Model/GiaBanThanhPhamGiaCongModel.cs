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
            base.LoaiThanhPham = loaiThanhPhamSauIn;
            base.SoLuong = soLuong;
            base.DonViTinh = donViTinh;
            base.ThanhTien = thanhTien;
            this.MucLoiNhuan = mucLoiNhuan;
            base.GhiChu = ghiChu;
            
            
           
           
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
        public string GiaBanText
        {
            get { return string.Format("{0:0,0.00đ}", this.GiaBan); }
        }
    }
}
