using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.WFUI.DTOContext;


namespace TinhGiaInOffset.WFUI.Helpers
{
    public static class TinhToanIn
    {

        public static decimal PhiInOffsetMotKem(int idGiaInOffsetGiaCong, int soMatCanIn)
        {
            decimal ketQua = 0;
            var giaInOffset = new GiaInOffsetGiaCongContext().DocTheoId(idGiaInOffsetGiaCong);

            //Tính số mặt chênh lệch với số mặt bao in
            var soMatInChenhLech = soMatCanIn - giaInOffset.SoLuongBaoIn;

            //Phí kẽm in            
            var phiMotKem = giaInOffset.DonGiaBai; 

            decimal phiInSoLuongVuot = 0;

            if (soMatInChenhLech > 0)
            {
                phiInSoLuongVuot = giaInOffset.DonGiaVuot * soMatInChenhLech;
            }

            ketQua = phiMotKem + phiInSoLuongVuot;
            return ketQua;
        }

        public static decimal PhiInOffset(int idGiaInOffsetGiaCong, int soMatCanIn, int soKemIn = 1)
        {
            decimal ketQua = 0;
            var giaInOffset = new GiaInOffsetGiaCongContext().DocTheoId(idGiaInOffsetGiaCong);

            //Tính số mặt chênh lệch với số mặt bao in
            var soMatInChenhLech = soMatCanIn - giaInOffset.SoLuongBaoIn;

            //Phí kẽm in            
            var phiKemIn = giaInOffset.DonGiaBai * soKemIn;

            decimal phiInSoLuongVuot = 0;

            if (soMatInChenhLech > 0)
            {
                phiInSoLuongVuot = giaInOffset.DonGiaVuot * soMatInChenhLech;
            }

            ketQua = phiKemIn + phiInSoLuongVuot;
            return ketQua;
        }
        public static decimal TienGiayIn(int donGiaGiay, int soToGiay)
        {
            return donGiaGiay * soToGiay;
        }

    }
}
