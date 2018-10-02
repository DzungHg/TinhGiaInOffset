using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.View
{
    public interface IViewBaiInOffsetGiaCong
    {
        string TenBaiIn { get; set; }
        string DienGiai { get; set; }
        int IdGiaInOffsetGiaCong { get; set; }
        string TenGiaInOffsetGiaCong { get; set; }
        int SoMatCanIn { get; set; }
        int SoKemIn { get; set; }
        int SoToChayBuHaoThucCan { get; set; }
        string KieuInOffset { get; set; }
        string TenGiay { get; set; }
        string KhoGiayChay { get; set; }
        int DonGiaGiayTheoTo { get; set; }
        int SoLuongToGiay { get; set; }
        bool GiayDaCoLoiNhuan { get; set; }
    }
}
