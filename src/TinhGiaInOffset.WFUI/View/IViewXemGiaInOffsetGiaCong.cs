using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.View
{
    public interface IViewXemGiaInOffsetGiaCong
    {
     
        int IdGiaInOffsetChon { get; set; }
        string DienGiai { get; set; }
      
       
        string ChiTietMayIn { set; }
        string DoiMayIn {  set; }
        int DonGiaBai {  set; }
        int SoToChayBuHaoCoBan { get; set; }
        int SoLuongBaoIn { get; set; }
        int DonGiaVuot { get; set; }
        string DonViTinhSoLuong { get; set; }
        bool GiaDaBaoKem { get; set; }
        string ThongTinLienHe { get; set; }
        string GhiChu { get; set; }
        //Tính toán
        int SoKemTinh { get; set; }
        int SoMatInTinh { get; set; }
        string KetQuaTinh { get; set; }
    }
}
