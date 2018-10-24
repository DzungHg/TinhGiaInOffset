using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Presentation
{
    public interface IViewGiaInOffsetGiaCong
    {
        int IdGiaIn { get; set; }
        string TenGia { get; set; }
        string DienGiai { get; set; }
        int IdNhaIn { get; set; }
        int IdMayIn { get; set; }
        string DoiMayIn { get; set; }
        int ToChayRong { get; set; }
        int ToChayDai { get; set; }
        int DonGiaBai { get; set; }
        int SoToChayBuHaoCoBan { get; set; }
        int SoLuongBaoIn { get; set; }
        int DonGiaVuot { get; set; }
        string DonViTinhSoLuong { get; set; }
        bool GiaDaBaoKem { get; set; }
        string ThongTinLienHe { get; set; }
        string GhiChu { get; set; }
        bool KhongSuDung { get; set; }
        int ThuTuSapXep { get; set; }
    }
}
