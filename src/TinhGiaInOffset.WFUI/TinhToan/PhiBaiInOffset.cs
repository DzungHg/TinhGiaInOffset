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
        
       
       
        public static decimal PhiInOffset(int idGiaInOffsetGiaCong, int soMatCanIn)
        {
            decimal ketQua = 0;
            var giaInOffset = new GiaInOffsetGiaCongContext().DocTheoId(idGiaInOffsetGiaCong);
            
            
            var soMatBaoIn = giaInOffset.SoLuongBaoIn;
            var giaBai = giaInOffset.DonGiaBai;
            var soMatInChenhLech = soMatCanIn - soMatBaoIn;
            ///Nếu âm thì không sao nếu dương thì lấy tính tiép
            decimal phiIn = 0;
            if (soMatInChenhLech <= 0)
            {
                phiIn = giaBai;
            }
            else
            {
                phiIn = giaBai + giaInOffset.DonGiaVuot * soMatInChenhLech;
            }
            ketQua = phiIn;

            return ketQua;
        }
        public static decimal TienGiayIn(int donGiaGiay, int soToGiay)
        {
            return donGiaGiay * soToGiay;
        }

    }
}
