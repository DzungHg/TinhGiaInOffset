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
    public class TaoGiaInOffsetGiaCongPresenter
    {
        IViewGiaInOffsetGiaCong View;
        NhaInOffsetContext nhaInOffsetCont = new NhaInOffsetContext();
        MayInOffsetContext mayInOffsetCont = new MayInOffsetContext();
        GiaInOffsetGiaCongContext giaInOffsetCont = new GiaInOffsetGiaCongContext();
        public TaoGiaInOffsetGiaCongPresenter(IViewGiaInOffsetGiaCong view)
        {
            View = view;

        }

        public List<NhaInOffsetModel> NhaInOffsetS()
        {
            return nhaInOffsetCont.DocTatCa();
        }
        public List<MayInOffsetModel> MayInOffsetS ()
        {
            return mayInOffsetCont.DocTatCa();
         }

        //
        public void DisplayChiTietGiaInOffset()
        {
            if (View.IdGiaIn <= 0)
                return;
            //
            var model = giaInOffsetCont.DocTheoId(View.IdGiaIn);

            View.TenGia = model.TenGia;
            View.DienGiai = model.DienGiai;

            View.DoiMayIn = model.DoiMayIn;
            View.ToChayRong = model.ToChayRong;
            View.ToChayDai = model.ToChayDai;
            View.DonGiaBai = model.DonGiaBai;
            View.SoToChayBuHaoCoBan = model.SoToChayBuHaoCoBan;
            View.SoLuongBaoIn = model.SoLuongBaoIn;
            View.DonGiaVuot = model.DonGiaVuot;
            View.DonViTinhSoLuong = model.DonViTinhSoLuong;
            View.GiaDaBaoKem = model.GiaDaBaoKem;
            View.ThongTinLienHe = model.ThongTinLienHe;
            View.GhiChu = model.GhiChu;
            View.KhongSuDung = model.KhongSuDung;
            View.ThuTuSapXep = model.ThuTuSapXep;
        }
        public string ChiTietMayInOffset()
        {
            return mayInOffsetCont.DocTheoId(View.IdMayIn).ChiTietMayIn;
        }
        public void TaoMoiGiaInOffsetGiaCong()
        {
            var model = new GiaInOffsetGiaCongModel(View.TenGia, View.DienGiai, View.IdGiaIn, View.IdMayIn,
                View.DoiMayIn, View.ToChayRong, View.ToChayDai, View.DonGiaBai, View.SoToChayBuHaoCoBan, View.SoLuongBaoIn,
                View.DonGiaVuot, View.DonViTinhSoLuong, View.GiaDaBaoKem, View.ThongTinLienHe, View.GhiChu, 
                View.KhongSuDung, View.ThuTuSapXep);

           
            giaInOffsetCont.Them(model);
        }
        public void SuaGiaInOffsetGiaCong()
        {
            if (View.IdGiaIn > 0)
            {
                var model = new GiaInOffsetGiaCongModel(View.TenGia, View.DienGiai, View.IdGiaIn, View.IdMayIn,
               View.DoiMayIn, View.ToChayRong, View.ToChayDai, View.DonGiaBai, View.SoToChayBuHaoCoBan, View.SoLuongBaoIn,
               View.DonGiaVuot, View.DonViTinhSoLuong, View.GiaDaBaoKem, View.ThongTinLienHe, View.GhiChu,
               View.KhongSuDung, View.ThuTuSapXep);
               model.Id = View.IdGiaIn;
                //Sửa
               
                giaInOffsetCont.Sua(model);
            }
        }
    }
}
