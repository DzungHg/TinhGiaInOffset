using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.Common.Enum;


namespace TinhGiaInOffset.WFUI.Model
{
    public class BaiInOffsetGiaCongModel
    {
        private static int lastId = 0;
        public int Id { get; set; }
        public string TenBaiIn { get; set; }
        public string DienGiai { get; set; }
        public int IdGiaInOffsetGiaCong { get; set; }
        public string TenGiaInOffsetGiaCong { get; set; }
        public int SoMatCanIn { get; set; }
        public int SoKemIn { get; set; }        
        public int SoToChayBuHaoThucCan { get; set; }
        public string KieuInOffset { get; set; }
        public string TenGiay { get; set; }
        public string KhoGiayChay { get; set; }
        public int DonGiayTheoTo { get; set; }
        public int SoLuongToGiay { get; set; }
        public bool GiayDaCoLoiNhuan { get; set; }

        public BaiInOffsetGiaCongModel(string tenBaiIn, string dienGiai, int idGiaInOffsetGiaCong, string tenGiaInOffsetGiaCong,
            int soMatCanIn, int soKem, int soToBuHaoThucCan, string kieuInOffset, string tenGiay, string khoGiay, int donGiaGiayTheoTo, 
            int soLuongToGiay, bool giayDaCoLoiNhuan)
        {
            //Tăng lên id
            lastId += 1;
            this.Id = lastId;

            this.TenBaiIn = tenBaiIn;
            this.DienGiai = dienGiai;
            this.IdGiaInOffsetGiaCong = idGiaInOffsetGiaCong;
            this.TenGiaInOffsetGiaCong = tenGiaInOffsetGiaCong;
            this.SoMatCanIn = soMatCanIn;
            this.SoKemIn = soKem;
            this.SoToChayBuHaoThucCan = soToBuHaoThucCan;
            this.KieuInOffset = kieuInOffset;
            this.TenGiay = tenGiay;
            this.KhoGiayChay = khoGiay;
            this.DonGiayTheoTo = donGiaGiayTheoTo;
            this.SoLuongToGiay = soLuongToGiay;
            this.GiayDaCoLoiNhuan = giayDaCoLoiNhuan;

        }
       
       
      

    }
}
