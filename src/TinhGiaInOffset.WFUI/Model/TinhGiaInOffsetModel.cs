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
        public string CacLoaiGiaySuDung()
        {
            var kq = "";
            if (this.BaiInOffsetGiaCongBaoGom.Count > 0)
                foreach (var baiIn in this.BaiInOffsetGiaCongBaoGom)
                {
                    kq += baiIn.TenGiay + ",";
                }
            if (kq.Trim().Length > 0)
                kq = kq.Trim().Substring(0, kq.Length - 1);//cái cuối 

            return kq;
        }
        public decimal TongGiaCanPhu_Ban()
        {
            decimal kq = 0;
            if (this.GiaBanCanPhuBaoGom.Count > 0)
            {
                kq = this.GiaBanCanPhuBaoGom.Sum(x => x.ThanhTien);
            }

            return kq;
        }
        public decimal TongGiaThanhPham_Ban()
        {
            decimal kq = 0;
            if (this.GiaBanThanhPhamBaoGom.Count > 0)
            {
                kq = this.GiaBanThanhPhamBaoGom.Sum(x => x.ThanhTien);
            }

            return kq;
        }
        public string CacLoaiCanPhu()
        {
            var kq = "";
            if (this.GiaBanCanPhuBaoGom.Count > 0)
                foreach (var baiTP in this.GiaBanCanPhuBaoGom)
                {
                    kq += baiTP.Ten + ",";
                }
            if (kq.Trim().Length > 0)
                kq = kq.Trim().Substring(0, kq.Length - 1);//cái cuối 

            return kq;
        }
        public string CacLoaiThanhPham()
        {
            var kq = "";
            if (this.GiaBanThanhPhamBaoGom.Count > 0)
                foreach (var baiTP in this.GiaBanCanPhuBaoGom)
                {
                    kq += baiTP.Ten + ",";
                }
            if (kq.Trim().Length > 0)
                kq = kq.Trim().Substring(0, kq.Length - 1);//cái cuối 

            return kq;
        }
        public string TomTatTinhToan()
        {
            var kq = "";
            kq += this.TieuDe + '\r' + '\n';
            kq += this.NgayTinhGia.ToString() + '\r' + '\n';
            kq += "---IN---" + '\r' + '\n';
            kq += $"---Số bài in bao gồm: {this.BaiInOffsetGiaCongBaoGom.Count}";
            kq += string.Format("---Tổng tiền in: {0:0,0.00đ}" + '\r' + '\n', this.GiaTienIn_Ban());

            kq += "---GIẤY---" + '\r' + '\n';
            kq += $"---Các loại giấy: {this.CacLoaiGiaySuDung()}";
            kq += string.Format("---Tổng tiền giấy: {0:0,0.00đ}" + '\r' + '\n', this.GiaTienGiay_Ban());

            kq += "---CÁN PHỦ---" + '\r' + '\n';
            kq += $"---Cán phủ: {this.CacLoaiCanPhu()}";
            kq += string.Format("---Tổng tiền cán phủ: {0:0,0.00đ}" + '\r' + '\n', this.TongGiaCanPhu_Ban());

            kq += "---THÀNH PHẨM---" + '\r' + '\n';
            kq += $"---Thành phẩm: {this.CacLoaiThanhPham()}";
            kq += string.Format("---Tổng tiền cán phủ: {0:0,0.00đ}" + '\r' + '\n', this.TongGiaThanhPham_Ban());

            return kq;
        }
    }
}
