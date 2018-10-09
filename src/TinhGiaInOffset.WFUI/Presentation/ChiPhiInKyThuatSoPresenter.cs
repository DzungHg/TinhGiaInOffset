using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.WFUI.DTOContext;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.WFUI.Helpers;

namespace TinhGiaInOffset.WFUI.Presentation
{
    public class ChiPhiInKyThuatSoPresenter
    {
        IViewChiPhiInKyThuatSo View;
        private PhiMayInKyThuatSoContext phiMayInKTS = new PhiMayInKyThuatSoContext();

        public ChiPhiInKyThuatSoPresenter(IViewChiPhiInKyThuatSo view)
        {
            View = view;

        }
        public List<PhiMayInKyThuatSoModel>PhiMayInKyThuatSoS()
        {
            return phiMayInKTS.DocTatCa();
        }
        public void ResetFormData()
        {
            View.SoTrangA4Tinh = 500;
            View.ThoiGianRIPDuLieuBienDoi = 0;
            View.InMotMau = false;
            View.KetQuaTinhToan = 0.ToString();
        }
        public string ChiTietPhiMayInKTS(int idPhiMayInKTS)
        {
            var kq = "";
            

            var model = phiMayInKTS.DocTheoId(idPhiMayInKTS);
            if (model != null)
            {
                kq += $"BHR: {model.BHR}" + '\r' + '\n';
                kq += $"Tốc độ: {model.TocDoA4HieuQua}A4/giờ" + '\r' + '\n';
                kq += $"Thời gian sẵn sàng: {model.ThoiGianSanSang} giờ" + '\r' + '\n';
                kq += $"ClickA4 4 Màu: {model.PhiClickA4BonMau} đ/a4" + '\r' + '\n';
                kq += $"ClickA4 1 Màu: {model.PhiClickA4MotMau} đ/a4" + '\r' + '\n';

            }

            return kq;
        }
        public decimal KetQuaTinh()
        {
            decimal kq = 0;
            if (View.IdPhiMayInKyThuatSo >0)
            {
                var tinhToanObj = new TinhPhiInKyThuatSo(phiMayInKTS.DocTheoId(View.IdPhiMayInKyThuatSo), View.SoTrangA4Tinh,
                                View.InMotMau, View.ThoiGianRIPDuLieuBienDoi);

                kq = tinhToanObj.TongPhi();
            }

            return kq;
        }
    }
}
