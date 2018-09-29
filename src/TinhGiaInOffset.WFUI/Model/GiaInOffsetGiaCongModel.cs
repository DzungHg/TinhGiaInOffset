using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class GiaInOffsetGiaCongModel
    {
        public int Id { get; set; }
        public string TenGia { get; set; }
        public string DienGiai { get; set; }
        public int IdNhaIn { get; set; }
        public int IdMayIn { get; set; }
        public string DoiMayIn { get; set; }
        public int DonGiaBai { get; set; }
        public int SoToChayBuHaoCoBan { get; set; }
        public int SoLuongBaoIn { get; set; }
        public int DonGiaVuot { get; set; }
        public string DonViTinhSoLuong { get; set; }
        public bool GiaDaBaoKem { get; set; }
        public string ThongTinLienHe { get; set; }
        public string GhiChu { get; set; }
        public bool KhongSuDung { get; set; }
        public int ThuTuSapXep { get; set; }
        //
       
        public GiaInOffsetGiaCongModel()
        {

        }
        public GiaInOffsetGiaCongModel(string tenGia, string dienGiai, int idNhaIn, int idMayIn,
            string doiMayIn, int donGiaBai, int soToChayBuHao, int soLuongBaoIn, int donGiaVuot,
            string donViTinhSoLuong, bool giaBaoKem, string thongTinLienHe, string ghiChu,
            bool khongSuDung, int thuTuSapXep)
        {
            this.TenGia = tenGia;
            this.DienGiai = dienGiai;
            this.IdNhaIn = idNhaIn;
            this.IdMayIn = idMayIn;
            this.DoiMayIn = doiMayIn;
            this.DonGiaBai = donGiaBai;
            this.SoToChayBuHaoCoBan = soToChayBuHao;
            this.SoLuongBaoIn = soLuongBaoIn;
            this.DonGiaVuot = donGiaVuot;
            this.DonViTinhSoLuong = donViTinhSoLuong;
            this.GiaDaBaoKem = giaBaoKem;
            this.ThongTinLienHe = thongTinLienHe;
            this.GhiChu = ghiChu;
            this.KhongSuDung = khongSuDung;
            this.ThuTuSapXep = thuTuSapXep;
        }
    }
}
