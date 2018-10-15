using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.Common.Enum;

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
        KieuInOffset KieuIn { get; set; }
        int SoNhanBan { get; set; }
        int SoToChay { get; set; }
        string KetQuaTinh { get; set; }
    }
}
