using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TinhGiaInOffset.WFUI.Model
{
    public class ChiPhiBaiInOffsetModel
    {
        private static int lastId = 0;
        public int Id { get; set; }
        public string TenChiPhi { get; set; }
        private GiaInOffsetGiaCongModel BangGiaInOffset { get; set; }
        private GiayChoBaiInOffsetModel GiayChoBaiIn { get; set; }
        public int SoMatCanIn { get; set; }
        
        public ChiPhiBaiInOffsetModel(string tenChiPhi, GiaInOffsetGiaCongModel bangGiaInOffset, GiayChoBaiInOffsetModel giayChoBaiIn, int soCanMatIn)
        {
            //Tăng lên id
            lastId += 1;
            this.Id = lastId;

            this.TenChiPhi = tenChiPhi;

            if (bangGiaInOffset == null || giayChoBaiIn == null)
                throw new Exception("Giấy hoặc Bảng giá null");

            this.BangGiaInOffset = bangGiaInOffset;
            this.GiayChoBaiIn = giayChoBaiIn;
            this.SoMatCanIn = soCanMatIn;
        }
       
       
        public decimal PhiInOffset()
        {
            decimal ketQua = 0;
            if (this.BangGiaInOffset == null || this.GiayChoBaiIn == null || this.SoMatCanIn <= 0)
                return 0;
            //Tính
            var soMatBaoIn = this.BangGiaInOffset.SoLuongBaoIn;
            var giaBai = this.BangGiaInOffset.DonGiaBai;
            var soMatInChenhLech = this.SoMatCanIn - soMatBaoIn;
            ///Nếu âm thì không sao nếu dương thì lấy tính tiép
            decimal phiIn = 0;
            if (soMatInChenhLech <= 0)
            {
                phiIn = giaBai;
            }
            else
            {
                phiIn = giaBai + this.BangGiaInOffset.DonGiaVuot * soMatInChenhLech;
            }
            ketQua = phiIn;

            return ketQua;
        }
        public string TenGiayIn
        {
            get { return this.GiayChoBaiIn.TenGiay; }

        }
        public string KhoGiayIn
        {
            get { return this.GiayChoBaiIn.KhoGiay; }
        }
        public int SoLuongToGiayIn
        {
            get { return this.GiayChoBaiIn.SoLuongTo; }
        }
        public decimal TienGiay
        {
            get { return this.GiayChoBaiIn.TienGiay; }
            
        }
        public bool GiayDaCoLoiNhuan
        {
            get { return this.GiayChoBaiIn.GiayDaCoLoiNhuan; }

        }

    }
}
