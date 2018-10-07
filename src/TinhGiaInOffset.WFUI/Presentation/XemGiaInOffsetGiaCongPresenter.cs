using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.DTOContext;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.WFUI.View;

namespace TinhGiaInOffset.WFUI.Presentation
{
    public class XemGiaInOffsetGiaCongPresenter
    {
        private GiaInOffsetGiaCongContext giaInOffsetGiaCongCont = new GiaInOffsetGiaCongContext();
        private MayInOffsetContext mayInOffset = new MayInOffsetContext();
        private NhaInOffsetContext nhaInOffset = new NhaInOffsetContext();
        IViewXemGiaInOffsetGiaCong View;
        public XemGiaInOffsetGiaCongPresenter(IViewXemGiaInOffsetGiaCong view)
        {
            View = view;

        }
        public List<GiaInOffsetGiaCongModel>GiaInOffsetGiaCongConDung()
        {
            return giaInOffsetGiaCongCont.DocGiaConSuDung() ;
        }

        public void TrinhBayChiTietGia(int idGiaInOffset)
        {
            var model = giaInOffsetGiaCongCont.DocTheoId(idGiaInOffset);
            //
            var tenNhaIn = nhaInOffset.DocTheoId(model.IdNhaIn).TenNhaIn;
            var line = "------------" + '\r' + '\n';
            View.ChiTietMayIn = $"({tenNhaIn})" + '\r' + '\n' + line + mayInOffset.DocTheoId(model.IdMayIn).ChiTietMayIn;            
            View.DienGiai = model.DienGiai;
            View.DoiMayIn = model.DoiMayIn;
            View.DonGiaBai = model.DonGiaBai;
            View.SoLuongBaoIn = model.SoLuongBaoIn;
            View.DonGiaVuot = model.DonGiaVuot;
            View.DonViTinhSoLuong = model.DonViTinhSoLuong;
            View.SoToChayBuHaoCoBan = model.SoToChayBuHaoCoBan;
            View.ThongTinLienHe = model.ThongTinLienHe;
            View.GhiChu = model.GhiChu;
            View.GiaDaBaoKem = model.GiaDaBaoKem;




        }
    }
}
