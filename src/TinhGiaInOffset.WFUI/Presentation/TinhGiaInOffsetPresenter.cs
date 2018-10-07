using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.Common;
using TinhGiaInOffset.Logic;
using TinhGiaInOffset.BDO;
using TinhGiaInOffset.WFUI.DTOContext;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.WFUI.Helpers;

namespace TinhGiaInOffset.WFUI.Presentation
{
   
    public class TinhGiaInOffsetPresenter
    {
        IViewTinhGiaInOffset View;
        public List<BaiInOffsetGiaCongModel> BaiInOffsetGiaCongBaoGom = new List<BaiInOffsetGiaCongModel>();
        public List<GiaBanThanhPhamTaiChoModel> GiaBanThanhPhamTaiChoBaoGom = new List<GiaBanThanhPhamTaiChoModel>();
        public List<GiaBanThanhPhamGiaCongModel> GiaBanThanhPhamGiaCongBaoGom = new List<GiaBanThanhPhamGiaCongModel>();
        public List<ChiPhiOffsetKhacModel> ChiPhiKhacBaoGom = new List<ChiPhiOffsetKhacModel>();
        public HangLoiNhuanOffsetGiaCongContext hangLoiNhuanOffset = new HangLoiNhuanOffsetGiaCongContext();
        public TinhGiaInOffsetPresenter(IViewTinhGiaInOffset view)
        {
            View = view;
        }

        public void KhoiTaoGiaTriBanDau()
        {
            View.MucLoiNhuanInMin = hangLoiNhuanOffset.LayTheoMa(ConstOffsetGiaCong.maMucLaiInOffsetOffsetGiaCongMin).PhanTram;
            View.MucLoiNhuanGiayMin = hangLoiNhuanOffset.LayTheoMa(ConstOffsetGiaCong.maMucLaiGiayInOffsetOffsetGiaCongMin).PhanTram;
        }

        public decimal TongPhiIn()
        {
            decimal kq = 0;
            if (this.BaiInOffsetGiaCongBaoGom.Count > 0)
                foreach (var baiIn in this.BaiInOffsetGiaCongBaoGom)
                {
                    kq += TinhToanIn.PhiInOffset(baiIn.IdGiaInOffsetGiaCong, baiIn.SoMatCanIn, baiIn.SoKemIn);
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
                        kq += TinhToanIn.TienGiayIn(baiIn.DonGiaGiayTheoTo, baiIn.SoLuongToGiay);
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
                        kq += TinhToanIn.TienGiayIn(baiIn.DonGiaGiayTheoTo, baiIn.SoLuongToGiay);
                }

            return kq;
        }

        public decimal GiaTienIn_Ban()
        {
            decimal kq = 0;
            if (View.MucLoiNhuanBaiIn > 0 && View.MucLoiNhuanBaiIn < 100)
            {
                kq = this.TongPhiIn() / (1 - (decimal)View.MucLoiNhuanBaiIn / 100);
            }
            return kq;
        }
        public decimal GiaTienGiay_Ban()
        {
            decimal kq = 0;

            decimal phanGomLoiNhuan = this.TongTienGiayDaCoLoiNhuan();

            decimal phanChuaLoiNhuan = 0;
            if (View.MucLoiNhuanGiay > 0 && View.MucLoiNhuanGiay < 100)
            {
                phanChuaLoiNhuan = this.TongPhiGiayChuaLoiNhuan() / (1 - (decimal)View.MucLoiNhuanGiay / 100);
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

     
        #region Thành phẩm  gia công ngoài
        public decimal GiaThanhPhamGiaCongNgoai_Ban()
        {
            decimal kq = 0;
            if (this.GiaBanThanhPhamGiaCongBaoGom.Count > 0)
            {
                kq = this.GiaBanThanhPhamGiaCongBaoGom.Sum(x => x.GiaBan);
            }

            return kq;
        }
        public string CacLoaiThanhPhamGiaCongNgoai()
        {
            var kq = "";
            if (this.GiaBanThanhPhamGiaCongBaoGom.Count > 0)
                foreach (var baiTP in this.GiaBanThanhPhamGiaCongBaoGom)
                {
                    kq += baiTP.Ten + ",";
                }
            if (kq.Trim().Length > 0)
                kq = kq.Trim().Substring(0, kq.Length - 1);//cái cuối 

            return kq;
        }
        #endregion
        #region các loại thành phẩm tại chỗ
        public decimal GiaThanhPhamTai123_Ban()
        {
            decimal kq = 0;
            if (this.GiaBanThanhPhamTaiChoBaoGom.Count > 0)
            {
                kq = this.GiaBanThanhPhamTaiChoBaoGom.Sum(x => x.ThanhTien);
            }

            return kq;
        }
        public string CacLoaiThanhPhamTai123in()
        {
            var kq = "";
            if (this.GiaBanThanhPhamTaiChoBaoGom.Count > 0)
                foreach (var baiTP in this.GiaBanThanhPhamTaiChoBaoGom)
                {
                    kq += baiTP.Ten + ",";
                }
            if (kq.Trim().Length > 0)
                kq = kq.Trim().Substring(0, kq.Length - 1);//cái cuối 

            return kq;
        }
        #endregion
        public string CacLoaiThanhPhamTongHop()
        {
            var kq = "";
            kq = $"{this.CacLoaiThanhPhamTai123in()};{this.CacLoaiThanhPhamGiaCongNgoai()}";
            return kq;
        }
        public decimal TongGiaBanCacLoaiThanhPham()
        {
            decimal kq = 0;
            kq = this.GiaThanhPhamTai123_Ban() + this.GiaThanhPhamGiaCongNgoai_Ban();
            return kq;
        }
        #region các loại chi phí khác
        public decimal TongChiPhiKhac()
        {
            decimal kq = 0;
            if (this.ChiPhiKhacBaoGom.Count > 0)
            {
                kq = this.ChiPhiKhacBaoGom.Sum(x => x.TienPhi);
            }

            return kq;
        }
        public string CacLoaiChiPhiKhac()
        {
            var kq = "";
            if (this.ChiPhiKhacBaoGom.Count > 0)
                foreach (var baiTP in this.ChiPhiKhacBaoGom)
                {
                    kq += baiTP.Ten + ",";
                }
            if (kq.Trim().Length > 0)
                kq = kq.Trim().Substring(0, kq.Length - 1);//cái cuối 

            return kq;
        }
        #endregion
        #region Tóm tắt
        public string TaoTomTat_ChaoGia()
        {
            var kq = "";
            kq += $"Chào giá: {View.TieuDe}" + '\r' + '\n';
            kq += $"Ngày: {View.NgayTinhGia.ToString()}" + '\r' + '\n';
            kq += "-IN---" + '\r' + '\n';
            kq += $"---Số bài in bao gồm: {this.BaiInOffsetGiaCongBaoGom.Count}" + '\r' + '\n';
            kq += string.Format("---Tổng tiền in: {0:0,0.00đ}" + '\r' + '\n', this.GiaTienIn_Ban());

            kq += "-GIẤY---" + '\r' + '\n';
            kq += $"---Các loại giấy: {this.CacLoaiGiaySuDung()}" + '\r' + '\n';
            kq += string.Format("---Tổng tiền giấy: {0:0,0.00đ}" + '\r' + '\n', this.GiaTienGiay_Ban());
            //Thành phẩm 
            if (this.CacLoaiThanhPhamTongHop() != "")
            {
                kq += "-THÀNH PHẨM---" + '\r' + '\n';
                kq += $"---Thành phẩm: {this.CacLoaiThanhPhamTongHop()}" + '\r' + '\n';
                kq += string.Format("---Tổng tiền: {0:0,0.00đ}" + '\r' + '\n', this.TongGiaBanCacLoaiThanhPham());
            }
            //Thành phẩm gia công
            /*if (this.GiaBanThanhPhamTaiChoBaoGom.Count > 0)
            {
                kq += "-THÀNH PHẨM ĐI GIA CÔNG---" + '\r' + '\n';
                kq += $"---Thành phẩm: {this.CacLoaiThanhPhamTai123in()}" + '\r' + '\n';
                kq += string.Format("---Tổng tiền cán phủ: {0:0,0.00đ}" + '\r' + '\n', this.TongGiaThanhPham_Ban());
            }*/
            //Các chi phí khác 

            kq += "-TỔNG ---" + '\r' + '\n';
            decimal tongTien = this.GiaTienIn_Ban() + this.GiaTienGiay_Ban() +
                        this.TongGiaBanCacLoaiThanhPham() + this.TongChiPhiKhac();
            kq += string.Format("---Giá tổng cộng: {0:0,0.00đ}", tongTien );
            return kq;
        }
        public string TaoTomTat_QuanLy()
        {
            var kq = "";
            kq += $"Chào giá: {View.TieuDe}" + '\r' + '\n';
            kq += $"Ngày: {View.NgayTinhGia.ToString()}, Tính bởi: View{View.TenNguoiTinhGia}" + '\r' + '\n';
            kq += $"Lợi nhuận cài đặt: " + '\r' + '\n';
            kq += $"--In:{View.MucLoiNhuanBaiIn}%" + '\r' + '\n';
            kq += $"--Giấy:{View.MucLoiNhuanGiay}%" + '\r' + '\n';
            kq += "-IN---" + '\r' + '\n';
            kq += $"---Số bài in bao gồm: {this.BaiInOffsetGiaCongBaoGom.Count}" + '\r' + '\n';
            var strTam = "";
            foreach (var baiIn in this.BaiInOffsetGiaCongBaoGom)
            {
                strTam += $"----{baiIn.TenBaiIn}; Số mặt in: {baiIn.SoMatCanIn}; Số kẽm: {baiIn.SoKemIn}; Bảng giá in:{baiIn.TenGiaInOffsetGiaCong};" +
                    $"Nhà in offset: {baiIn.TenGiaInOffsetGiaCong}" + '\r' + '\n';
                strTam += $"-----Giấy: {baiIn.TenGiay}; Đơn giá: {baiIn.DonGiaGiayTheoTo} Số Tờ: {baiIn.SoLuongToGiay} tờ;" + '\r' + '\n';
            }
            kq += strTam;
            kq += string.Format("---Tổng tiền in: {0:0,0.00đ}" + '\r' + '\n', this.GiaTienIn_Ban());
            kq += string.Format("---Tổng tiền giấy: {0:0,0.00đ}" + '\r' + '\n', this.GiaTienGiay_Ban());

            //Thành phẩm làm tại 123in
            if (this.GiaBanThanhPhamTaiChoBaoGom.Count > 0)
            {
                kq += "-THÀNH PHẨM TẠI 123IN---" + '\r' + '\n';
                var str = "";
                foreach (var model in this.GiaBanThanhPhamTaiChoBaoGom)
                {
                    str += $"---{model.Ten}, phí: {Math.Round(model.ThanhTien)}" + '\r' + '\n';
                }
                kq += str;
                kq += string.Format("---Tổng tiền bán: {0:0,0.00đ}" + '\r' + '\n', this.GiaThanhPhamTai123_Ban());
            }
            //Gia công ngoài
            if (this.GiaBanThanhPhamGiaCongBaoGom.Count > 0)
            {
                kq += "-THÀNH PHẨM GIA CÔNG---" + '\r' + '\n';
                var str = "";
                foreach(var model in this.GiaBanThanhPhamGiaCongBaoGom)
                {
                    str += $"---{model.Ten}, phí: {Math.Round(model.ThanhTien)}, mức lãi: {model.MucLoiNhuan}%, giá bán: {model.GiaBanText}" + '\r' + '\n';
                }
                kq += str;
                kq += string.Format("---Tổng tiền bán: {0:0,0.00đ}" + '\r' + '\n', this.GiaThanhPhamGiaCongNgoai_Ban());
            }
            //Chi phí
            if (this.ChiPhiKhacBaoGom.Count > 0)
            {
                kq += "-CHI PHÍ KHÁC KÈM THEO---" + '\r' + '\n';
                var str = "";
                foreach (var model in this.ChiPhiKhacBaoGom)
                {
                    str += $"---{model.Ten}, tiền phí: {Math.Round(model.TienPhi)}" + '\r' + '\n';
                }
                kq += str;
                kq += string.Format("---Tổng tiền phí: {0:0,0.00đ}" + '\r' + '\n', this.TongChiPhiKhac());
            }
            kq += "-TỔNG GIÁ BÁN VÀ...---" + '\r' + '\n';
            kq += string.Format("---Giá tổng cộng: {0:0,0.00đ}", this.GiaTienIn_Ban() + this.GiaTienGiay_Ban() +
                        this.GiaThanhPhamTai123_Ban());
            return kq;
        }
        #endregion
    }
}
