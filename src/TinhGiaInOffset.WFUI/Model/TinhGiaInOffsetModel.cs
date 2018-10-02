using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.Helpers;

namespace TinhGiaInOffset.WFUI.Model
{
    public class TinhGiaInOffsetModel
    {
        public string TieuDe { get; set; }
        public DateTime NgayTinhGia { get; set; }
        public string YeuCau { get; set; }
        public string TenNguoiTinhGia { get; set; }
        public List<BaiInOffsetGiaCongModel> BaiInOffsetGiaCongBaoGom { get; set; }
        public List<GiaBanThanhPhamModel> GiaBanThanhPhamSauInBaoGom { get; set; }
      
        
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
                kq = this.TongPhiIn() / (1 - (decimal)this.MucLoiNhuanBaiIn/100);
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
                phanChuaLoiNhuan = this.TongPhiGiayChuaLoiNhuan() / (1 - (decimal)this.MucLoiNhuanGiay/100);
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
       
        public decimal TongGiaThanhPham_Ban()
        {
            decimal kq = 0;
            if (this.GiaBanThanhPhamSauInBaoGom.Count > 0)
            {
                kq = this.GiaBanThanhPhamSauInBaoGom.Sum(x => x.ThanhTien);
            }

            return kq;
        }
       
        public string CacLoaiThanhPham()
        {
            var kq = "";
            if (this.GiaBanThanhPhamSauInBaoGom.Count > 0)
                foreach (var baiTP in this.GiaBanThanhPhamSauInBaoGom)
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
            kq += $"Chào giá: {this.TieuDe}" + '\r' + '\n';
            kq += $"Ngày: {this.NgayTinhGia.ToString()}" + '\r' + '\n';
            kq += "-IN---" + '\r' + '\n';
            kq += $"---Số bài in bao gồm: {this.BaiInOffsetGiaCongBaoGom.Count}" + '\r' + '\n';
            kq += string.Format("---Tổng tiền in: {0:0,0.00đ}" + '\r' + '\n', this.GiaTienIn_Ban());

            kq += "-GIẤY---" + '\r' + '\n';
            kq += $"---Các loại giấy: {this.CacLoaiGiaySuDung()}" + '\r' + '\n';
            kq += string.Format("---Tổng tiền giấy: {0:0,0.00đ}" + '\r' + '\n', this.GiaTienGiay_Ban());
           
            if (this.GiaBanThanhPhamSauInBaoGom.Count > 0)
            {
                kq += "-THÀNH PHẨM SU IN---" + '\r' + '\n';
                kq += $"---Thành phẩm: {this.CacLoaiThanhPham()}" + '\r' + '\n';
                kq += string.Format("---Tổng tiền cán phủ: {0:0,0.00đ}" + '\r' + '\n', this.TongGiaThanhPham_Ban());
            }
            kq += "-TỔNG ---" + '\r' + '\n';
            kq += string.Format("---Giá tổng cộng: {0:0,0.00đ}", this.GiaTienIn_Ban() + this.GiaTienGiay_Ban() + 
                        this.TongGiaThanhPham_Ban());
            return kq;
        }
    }
}
