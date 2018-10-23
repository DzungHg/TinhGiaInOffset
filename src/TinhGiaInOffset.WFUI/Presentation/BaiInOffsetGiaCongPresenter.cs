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
        private GiaInOffsetGiaCongContext giaInGiaCongOffset = new GiaInOffsetGiaCongContext();
       
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
            var bGia = giaInGiaCongOffset.DocTheoId(idBangGia);
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
            var giaModel = giaInGiaCongOffset.DocTheoId(idBangGiaChon);
            //Lay chi tiết máy in
            var modelMayIn = mayInOffsetContext.DocTheoId(giaModel.IdMayIn);
            var kq = "";
            kq += giaModel.DienGiai + '\r' + '\n';
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
            var giaModel = giaInGiaCongOffset.DocTheoId(idGiaInOffsetGiaCong);
            //Lay chi tiết máy in
            var modelMayIn = mayInOffsetContext.DocTheoId(giaModel.IdMayIn);

            output = $"{modelMayIn.KhoGiayToiDaRong} x {modelMayIn.KhoGiayToiDaDai}cm";

            return output;
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

    }
}
