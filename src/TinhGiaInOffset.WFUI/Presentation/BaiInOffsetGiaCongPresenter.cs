using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.Common.Enum;
using TinhGiaInOffset.Logic;
using TinhGiaInOffset.BDO;
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
        public BaiInOffsetGiaCongModel ThemBaiIn(string tenBaiIn, string dienGiai, int idGiaInOffsetGiaCong, string tenGiaInOffsetGiaCong,
            int soMatCanIn, int soKem, int soToBuHaoThucCan, string kieuInOffset, string tenGiay, string khoGiay, int donGiaGiayTheoTo,
            int soLuongToGiay, bool giayDaCoLoiNhuan, bool inTheoLo)
        {
            var model = new BaiInOffsetGiaCongModel(tenBaiIn,dienGiai,  idGiaInOffsetGiaCong, tenGiaInOffsetGiaCong,
             soMatCanIn,  soKem, soToBuHaoThucCan,  kieuInOffset,  tenGiay,  khoGiay,  donGiaGiayTheoTo,
             soLuongToGiay,  giayDaCoLoiNhuan, inTheoLo);

            return model;
        }
        public string ChiTietGiaInGiaCong(int idBangGiaChon)
        {
            //Lấy bảng giá
            var giaModel = giaInGiaCongOffset.DocTheoId(idBangGiaChon);
            //Lay chi tiết máy in
            var modelMayIn = mayInOffsetContext.DocTheoId(giaModel.IdMayIn);

            var line01 = modelMayIn.ChiTietMayIn + '\r' + '\n';
            var line02 = giaModel.DoiMayIn + '\r' + '\n';
            var line03 = string.Format("{0:0,0.00} đ/bài" + '\r' + '\n', giaModel.DonGiaBai);

            return line01 + line02 + line03;
        }
        public string KhoMayInLonNhat(int idGiaInOffsetGiaCong)
        {
            var output = "";
            //Lấy bảng giá
            var giaModel = giaInGiaCongOffset.DocTheoId(idGiaInOffsetGiaCong);
            //Lay chi tiết máy in
            var modelMayIn = mayInOffsetContext.DocTheoId(giaModel.IdMayIn);

            output = $"{modelMayIn.KhoInToiDaRong} x {modelMayIn.KhoInToiDaDai}cm";

            return output;
        }
        public void ResetViewData()
        {
            View.TenBaiIn = "";
            View.DienGiai = "";
            View.TenGiay = "Couche";
            View.DonGiaGiayTheoTo = 0;
            View.SoLuongToGiay = 500;
            View.SoMatCanIn = 500;
            View.SoKemIn = 1;
            View.SoToChayBuHaoThucCan = 50;
            View.KhoGiayChay = this.KhoMayInLonNhat(View.IdGiaInOffsetGiaCong);
            View.InTheoLo = true;
        }

    }
}
