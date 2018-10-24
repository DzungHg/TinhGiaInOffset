using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.Common.Enum;
using TinhGiaInOffset.WFUI.DTOContext;
using TinhGiaInOffset.WFUI.Model;

namespace TinhGiaInOffset.WFUI.Presentation
{
    public class BaiInOffsetGiaCongPresenter
    {
        private IViewBaiInOffsetGiaCong View;
        private NhaInOffsetContext nhaInOffsetContext = new NhaInOffsetContext();
        private MayInOffsetContext mayInOffsetContext = new MayInOffsetContext();
        private GiaInOffsetGiaCongContext giaInGiaCongOffsetCont = new GiaInOffsetGiaCongContext();
     
       
        public BaiInOffsetGiaCongPresenter(IViewBaiInOffsetGiaCong view)
        {
            this.View = view;

        }
        public List<GiaInOffsetGiaCongModel>GiaInOffsetS()
        {
            return new GiaInOffsetGiaCongContext().DocGiaConSuDung();
        }
        public string LayTenNhaInOffset (int idBangGia)
        {
            var kq = "";
            var bGia = giaInGiaCongOffsetCont.DocTheoId(idBangGia);
            kq = nhaInOffsetContext.DocTheoId(bGia.IdNhaIn).TenNhaIn;
            return kq;
        }
        public BaiInOffsetGiaCongModel ThemBaiIn(string tenBaiIn, string dienGiai, int idGiaInOffsetGiaCong, string tenGiaInOffsetGiaCong,
            int soMatCanIn, int soKem, int soToBuHaoThucCan, KieuInOffset kieuInOffset, string tenGiay, string khoGiay, int donGiaGiayTheoTo,
            int soLuongToGiay, bool giayDaCoLoiNhuan, bool baiInNhanBan, int soLuongBaiNhanBan)
        {
            var model = new BaiInOffsetGiaCongModel(tenBaiIn,dienGiai,  idGiaInOffsetGiaCong, tenGiaInOffsetGiaCong, this.LayTenNhaInOffset(View.IdGiaInOffsetGiaCong),
             soMatCanIn,  soKem, soToBuHaoThucCan,  kieuInOffset,  tenGiay,  khoGiay,  donGiaGiayTheoTo,
             soLuongToGiay,  giayDaCoLoiNhuan, baiInNhanBan, soLuongBaiNhanBan);

            return model;
        }
        public string ChiTietGiaInGiaCong(int idBangGiaChon)
        {
            //Lấy bảng giá
            var giaModel = giaInGiaCongOffsetCont.DocTheoId(idBangGiaChon);
            //Lay chi tiết máy in
            var modelMayIn = mayInOffsetContext.DocTheoId(giaModel.IdMayIn);
            var kq = "";
            kq += giaModel.DienGiai + '\r' + '\n';
            kq += "-----------" + '\r' + '\n';
            kq += $"Khổ chạy: {giaModel.ToChayDai} x {giaModel.ToChayRong}cm" + '\r' + '\n';
            kq += "-----------" + '\r' + '\n';
            kq += modelMayIn.ChiTietMayIn + '\r' + '\n';
            kq += giaModel.DoiMayIn + '\r' + '\n';
            kq += string.Format("{0:0,0.00} đ/bài" + '\r' + '\n', giaModel.DonGiaBai);

            return kq;
        }
        public string KhoMayInLonNhat(int idGiaInOffsetGiaCong)
        {
            var output = "";
            //Lấy bảng giá
            var giaModel = giaInGiaCongOffsetCont.DocTheoId(idGiaInOffsetGiaCong);
            //Lay chi tiết máy in
            var modelMayIn = mayInOffsetContext.DocTheoId(giaModel.IdMayIn);

            output = $"{modelMayIn.KhoGiayToiDaRong} x {modelMayIn.KhoGiayToiDaDai}cm";

            return output;
        }
        public void DisplayWhenSelectGiaInOffset()
        {
            if (View.IdGiaInOffsetGiaCong <= 0)
                return;
            //
            var model = giaInGiaCongOffsetCont.DocTheoId(View.IdGiaInOffsetGiaCong);
            View.KhoToChayIn = $"{model.ToChayRong} x {model.ToChayDai}cm ";
            View.KhoGiayChay = $"{model.ToChayRong} x {model.ToChayDai}cm ";
        }
        public void ResetViewData()
        {
            View.TenBaiIn = "";
            View.DienGiai = "";
            View.TenGiay = "Couche";
            View.DonGiaGiayTheoTo = 1;
            View.SoToChayLyThuyet = 500;
            View.KieuIn = KieuInOffset.InMotMat;
            View.SoToChayBuHao = 50;
            View.KhoGiayChay = this.KhoMayInLonNhat(View.IdGiaInOffsetGiaCong);
            View.BaiNhanBan = false;
            View.SoBaiNhanBan = 1;
        }

        /// <summary>
        /// Khi lưu database mình làm sau
        /// </summary>
        public void DisplayBaiInOffsetGiaCong()
        {
            /*
            if (View.IdBaiIn <= 0)
                return;
            //Chỉ display khi sửa
            var model = baiIn
            
            View.TenBaiIn TenBaiIn 
            View.DienGia DienGiai 
            View.IdGiaInOffsetGiaCong IdGiaInOffsetGiaCong 
            View.TenGiaInOffsetGiaCong TenGiaInOffsetGiaCong 
            View.KhoToChayIn KhoToChayIn { get; set; }
            View.SoLuotIn SoLuotIn { get; set; }
            View.SoBaiNhanBan SoBaiNhanBan { get; set; }
            View.SoMatIn SoMatIn { get; set; }
            View.SoKemIn SoKemIn { get; set; }
            View.SoToChayBuHao SoToChayBuHao { get; set; }
            View.KieuIn KieuInOffset KieuIn { get; set; }
            View.TenGiay TenGiay { get; set; }
            View.KhoGiayChay KhoGiayChay { get; set; }
            View.DonGiaGiayTheoTo DonGiaGiayTheoTo { get; set; }
            View.SoToChayLyThuyet SoToChayLyThuyet { get; set; }
            View.GiayDaCoLoiNhuan GiayDaCoLoiNhuan { get; set; }
            */
        }
    }
}
