using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.TinhToan;

namespace TinhGiaInOffset.WFUI.Model
{
    public class TinhGiaInOffsetModel
    {
        public string TieuDe { get; set; }
        public DateTime NgayTinhGia { get; set; }
        public string YeuCau { get; set; }
        public List<BaiInOffsetGiaCongModel> BaiInOffsetGiaCongBaoGom { get; set; }
        public List<GiaBanThanhPhamModel> GiaBanThanhPhamBaoGom { get; set; }
        public List<GiaBanThanhPhamModel> GiaBanCanPhuBaoGom { get; set; }
        
        public int MucLoiNhuanBaiIn { get; set; }
        public int MucLoiNhuanGiay { get; set; }
        //Các procedure
        public decimal TongPhiIn ()
        {
            decimal kq = 0;
            if (this.BaiInOffsetGiaCongBaoGom.Count > 0)
                foreach (var baiIn in this.BaiInOffsetGiaCongBaoGom)
                {
                    kq += PhiBaiInOffset.PhiInOffset(baiIn.IdGiaInOffsetGiaCong, baiIn.SoMatCanIn, baiIn.SoKemIn);
                }

            return kq;
        }
        public decimal TongPhiGiayChuaLoiNhuan()
        {
            decimal kq = 0;
            if (this.BaiInOffsetGiaCongBaoGom.Count > 0)
                foreach (var baiIn in this.BaiInOffsetGiaCongBaoGom)
                {
                    if (!baiIn.GiayDaCoLoiNhuan)
                        kq += PhiBaiInOffset.TienGiayIn(baiIn.DonGiayTheoTo, baiIn.SoLuongToGiay);
                }

            return kq;
        }
        public decimal TongTienGiayDaCoLoiNhuan()
        {
            decimal kq = 0;
            if (this.BaiInOffsetGiaCongBaoGom.Count > 0)
                foreach (var baiIn in this.BaiInOffsetGiaCongBaoGom)
                {
                    if (baiIn.GiayDaCoLoiNhuan)
                        kq += PhiBaiInOffset.TienGiayIn(baiIn.DonGiayTheoTo, baiIn.SoLuongToGiay);
                }

            return kq;
        }

        public decimal GiaTienIn_Ban()
        {
            decimal kq = 0;
            if (this.MucLoiNhuanBaiIn > 0 && this.MucLoiNhuanBaiIn <100)
            {
                kq = this.TongPhiIn() / (1 - this.MucLoiNhuanBaiIn);
            }
            return kq;
        }
        public decimal GiaTienGiay_Ban()
        {
            decimal kq = 0;

            decimal phanGomLoiNhuan = this.TongTienGiayDaCoLoiNhuan();

            decimal phanChuaLoiNhuan = 0;
            if(this.MucLoiNhuanGiay > 0 && this.MucLoiNhuanGiay <100)
                {
                phanChuaLoiNhuan = this.TongPhiGiayChuaLoiNhuan() / (1 - this.MucLoiNhuanGiay);
            }

            kq = phanGomLoiNhuan + phanChuaLoiNhuan;
            return kq;
        }
    }
}
