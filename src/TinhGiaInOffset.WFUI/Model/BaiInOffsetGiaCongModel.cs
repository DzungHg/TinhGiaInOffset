using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TinhGiaInOffset.WFUI.Model
{
    public class BaiInOffsetGiaCongModel
    {
        private static int lastId = 0;
        public int Id { get; set; }
        public string TenBaiIn { get; set; }
        public int IdGiaInOffsetGiaCong { get; set; }
        public string TenGiaInOffsetGiaCong { get; set; }
        public int SoMatCanIn { get; set; }
        public string TenGiay { get; set; }
        public string KhoGiay { get; set; }
        public int DonGiayTheoTo { get; set; }
        public int SoLuongToGiay { get; set; }
        public bool GiayDaCoLoiNhuan { get; set; }

        public BaiInOffsetGiaCongModel(string tenBaiIn, int idGiaInOffsetGiaCong, string tenGiaInOffsetGiaCong,
            int soMatCanIn, string tenGiay, string khoGiay, int donGiaGiayTheoTo, 
            int soLuongToGiay, bool giayDaCoLoiNhuan)
        {
            //Tăng lên id
            lastId += 1;
            this.Id = lastId;

            this.TenBaiIn = tenBaiIn;
            this.IdGiaInOffsetGiaCong = idGiaInOffsetGiaCong;
            this.TenGiaInOffsetGiaCong = tenGiaInOffsetGiaCong;
            this.SoMatCanIn = soMatCanIn;
            this.TenGiay = tenGiay;
            this.KhoGiay = khoGiay;
            this.DonGiayTheoTo = donGiaGiayTheoTo;
            this.SoLuongToGiay = soLuongToGiay;
            this.GiayDaCoLoiNhuan = giayDaCoLoiNhuan;

        }
       
       
      

    }
}
