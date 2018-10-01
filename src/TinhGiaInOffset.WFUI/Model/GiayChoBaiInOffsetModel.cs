using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class GiayChoBaiInOffsetModel
    {
        public string TenGiay { get; set; }
        public string KhoGiay { get; set; }
        public int DonGia { get; set; }
        public int SoLuongTo { get; set; }
        public bool GiayDaCoLoiNhuan { get; set; }
        public GiayChoBaiInOffsetModel(string tenGiay, string khoGiay, int donGia, int soTo, bool giayDaCoLoiNhuan)
        {
            this.TenGiay = tenGiay;
            this.KhoGiay = khoGiay;
            this.DonGia = donGia;
            this.SoLuongTo = soTo;
            this.GiayDaCoLoiNhuan = giayDaCoLoiNhuan;

        }
        public decimal TienGiay
        {
            get { return this.DonGia * SoLuongTo; }
        }
    }
}
