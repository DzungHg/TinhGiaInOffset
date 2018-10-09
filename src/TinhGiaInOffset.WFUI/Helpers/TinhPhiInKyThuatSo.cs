using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TinhGiaInOffset.WFUI.Model;

namespace TinhGiaInOffset.WFUI.Helpers
{
    public class TinhPhiInKyThuatSo : ITinhPhiInKyThuatSo
    {
        
        private PhiMayInKyThuatSoModel PhiMayIn;
        private int SoTrangA4Tinh;
        private bool InMotMau;
        private double ThoiGianGiuLieuBienDoi;
        public TinhPhiInKyThuatSo(PhiMayInKyThuatSoModel phiMayIn, int soLuongTrangA4, bool inMotMau, double thoiGianDuLieuBienDoi)
        {
            this.PhiMayIn = phiMayIn;
            this.SoTrangA4Tinh = soLuongTrangA4;
            this.InMotMau = inMotMau;
            this.ThoiGianGiuLieuBienDoi = thoiGianDuLieuBienDoi;

        }
        public decimal PhiChay()
        {
            decimal thoiGiayChayTheoSoLuong = (decimal)SoTrangA4Tinh / PhiMayIn.TocDoA4HieuQua;
            decimal phiChay = PhiMayIn.BHR * thoiGiayChayTheoSoLuong;
            decimal phiSetup = (decimal)PhiMayIn.ThoiGianSanSang * PhiMayIn.BHR;
            decimal phiDLBD = (decimal)ThoiGianGiuLieuBienDoi * this.PhiMayIn.BHR;
            return phiChay + phiSetup + phiDLBD;
        }

        public decimal PhiClick()
        {
            decimal kq = 0;

            decimal phiClick = 0;
            phiClick = PhiMayIn.PhiClickA4BonMau;
            if (this.InMotMau)
                phiClick = PhiMayIn.PhiClickA4MotMau;

            kq = phiClick * this.SoTrangA4Tinh;
            return kq;
        }

        public decimal TongPhi()
        {
            return PhiChay() + PhiClick();
        }
    }
}
