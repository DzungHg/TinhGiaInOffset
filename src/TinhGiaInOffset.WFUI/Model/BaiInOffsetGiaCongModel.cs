using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.Common.Enum;
using TinhGiaInOffset.WFUI.Helpers;


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
        public string TenNhaInOffset { get; set; }
        public int SoMatIn { get; set; }
        public bool BaiNhanBan { get; set; }
        public int SoKemIn { get; set; }        
 
        public int SoBaiNhanBan { get; set; }
        public int SoToChayBuHao { get; set; }
        public KieuInOffset KieuIn { get; set; }
        public string TenGiay { get; set; }
        public string KhoGiayChay { get; set; }
        public int DonGiaGiayTheoTo { get; set; }
        public int SoToChayLyThuyet { get; set; }
        public bool GiayDaCoLoiNhuan { get; set; }
        

        public BaiInOffsetGiaCongModel(string tenBaiIn, string dienGiai, int idGiaInOffsetGiaCong, string tenGiaInOffsetGiaCong,
            string tenNhaInOffset, int soMatCanIn, int soKem, int soToBuHao, KieuInOffset kieuInOffset, string tenGiay, string khoGiay, int donGiaGiayTheoTo, 
            int soToChayLyThuyet, bool giayDaCoLoiNhuan, bool baiNhanBan, int soBaiNhanBan)
        {
            //Tăng lên id
            lastId += 1;
            this.Id = lastId;

            this.TenBaiIn = tenBaiIn;
            this.DienGiai = dienGiai;
            this.IdGiaInOffsetGiaCong = idGiaInOffsetGiaCong;
            this.TenGiaInOffsetGiaCong = tenGiaInOffsetGiaCong;
            this.TenNhaInOffset = tenNhaInOffset;
            this.SoMatIn = soMatCanIn;
            this.SoKemIn = soKem;
            this.SoToChayBuHao = soToBuHao;
            this.KieuIn = kieuInOffset;
            this.TenGiay = tenGiay;
            this.KhoGiayChay = khoGiay;
            this.DonGiaGiayTheoTo = donGiaGiayTheoTo;
            this.SoToChayLyThuyet = soToChayLyThuyet;
            this.GiayDaCoLoiNhuan = giayDaCoLoiNhuan;
            this.BaiNhanBan = baiNhanBan;
            this.SoBaiNhanBan = soBaiNhanBan;
        }
       //Procedure
       
       public decimal PhiInOffsetGiaCong()
       {
            decimal kq = 0;
            int tongSoMatIn = 0;
            
            switch (this.KieuIn)
            {
                case KieuInOffset.InMotMat:
                    tongSoMatIn = (this.SoToChayLyThuyet + this.SoToChayBuHao) * this.SoMatIn;
                    kq = TinhToanIn.PhiInOffsetMotKem(this.IdGiaInOffsetGiaCong, tongSoMatIn);
                    break;
                case KieuInOffset.InTuTroNhip:
                case KieuInOffset.InTuTroTayKe:
                    tongSoMatIn = (this.SoToChayLyThuyet + this.SoToChayBuHao) * this.SoMatIn;
                    kq = TinhToanIn.PhiInOffsetMotKem(this.IdGiaInOffsetGiaCong, tongSoMatIn);
                    break;
                case KieuInOffset.InAB:
                    tongSoMatIn = (this.SoToChayLyThuyet + this.SoToChayBuHao) / this.SoMatIn;
                    kq = TinhToanIn.PhiInOffsetMotKem(this.IdGiaInOffsetGiaCong, tongSoMatIn) * this.SoKemIn;
                    break;
            }
            //Kiểm tra vụ nhân bản
            if (this.BaiNhanBan)
            {
                kq *= this.SoBaiNhanBan;
            }
            return kq;
        }
        
        public decimal PhiGiayTheoBai()
        {
            decimal kq = 0;

            kq = (this.SoToChayLyThuyet + this.SoToChayBuHao) * this.DonGiaGiayTheoTo;
            return kq;
        }
      

    }
}
