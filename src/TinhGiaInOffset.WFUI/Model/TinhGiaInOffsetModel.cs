using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.WFUI.Helpers;

namespace TinhGiaInOffset.WFUI.Model
{
    public class TinhGiaInOffsetModel
    {
        public string TieuDe { get; set; }
        public DateTime NgayTinhGia { get; set; }
        public string YeuCau { get; set; }
        public string TenNguoiTinhGia { get; set; }
        public List<BaiInOffsetGiaCongModel> BaiInOffsetGiaCongBaoGom { get; set; }
        public List<GiaBanThanhPhamTaiChoModel> GiaBanThanhPhamTaiChoBaoGom { get; set; }
      
        
        public int MucLoiNhuanBaiIn { get; set; }
        public int MucLoiNhuanGiay { get; set; }
        public string TomTatQuanLy { get; set; }
        public string TomTatChaoGia { get; set; }
       
        public decimal TongPhiIn
        { get; set; }
        public decimal TongPhiGiayChuaLoiNhuan
        { get; set; }
        public decimal TongTienGiayDaCoLoiNhuan { get; set; }
        

        public decimal GiaTienIn_Ba { get; set; }
       
        public decimal GiaTienGiay_Ban { get; set; }
        
        public string CacLoaiGiaySuDung { get; set; }
        
       
        public decimal TongGiaThanhPham_Ban { get; set; }
        
        public string CacLoaiThanhPham { get; set; }
       
          
        public string TaoTomTat_ChaoGia { get; set; }
        public string TaoTomTat_QuanLy { get; set; }
    }
}
