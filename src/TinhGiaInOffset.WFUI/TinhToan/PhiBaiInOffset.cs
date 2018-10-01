using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.WFUI.DTOContext;


namespace TinhGiaInOffset.WFUI.TinhToan
{
    public static class PhiBaiInOffset
    {
        
       
       
        public static decimal PhiInOffset(int idGiaInOffsetGiaCong, int soMatCanIn, int soKemIn = 1)
        {
            decimal ketQua = 0;
            var giaInOffset = new GiaInOffsetGiaCongContext().DocTheoId(idGiaInOffsetGiaCong);
            
            
            var soMatBaoIn = giaInOffset.SoLuongBaoIn;
            
            var soMatInChenhLech = soMatCanIn - soMatBaoIn;
            ///Nếu âm thì không sao nếu dương thì lấy tính tiép
            decimal phiKemIn = 0;
            phiKemIn = giaInOffset.DonGiaBai * soKemIn;

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
