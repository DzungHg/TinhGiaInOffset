using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinhGiaInOffset.Common.Enum;

namespace TinhGiaInOffset.WFUI.View
{
    public interface IViewBaiInOffsetGiaCong
    {
        string TenBaiIn { get; set; }
        string DienGiai { get; set; }
        int IdGiaInOffsetGiaCong { get; set; }
        string TenGiaInOffsetGiaCong { get; set; }
        int SoLuotIn { get; set; }
        int SoBaiNhanBan { get; set; }
        int SoMatIn { get; set; }
        int SoKemIn { get; set; }
        int SoToChayBuHao { get; set; }
        KieuInOffset KieuIn { get; set; }
        string TenGiay { get; set; }
        string KhoGiayChay { get; set; }
        int DonGiaGiayTheoTo { get; set; }
        int SoToChayLyThuyet { get; set; }
        bool GiayDaCoLoiNhuan { get; set; }

        bool BaiNhanBan { get; set; }
    }
}
