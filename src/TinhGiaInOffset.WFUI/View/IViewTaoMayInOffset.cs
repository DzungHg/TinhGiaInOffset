using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.View
{
    public interface IViewTaoMayInOffset
    {
        //int Id { get; set; }
        string TenMayIn { get; set; }
        string MoTa { get; set; }
        double KhoGiayToiDaRong { get; set; }
        double KhoGiayToiDaDai { get; set; }
        double KhoGiayToiThieuRong { get; set; }
        double KhoGiayToiThieuDai { get; set; }
        double KhoInToiDaRong { get; set; }
        double KhoInToiDaDai { get; set; }
        double KhoInToiThieuRong { get; set; }
        double KhoInToiThieuDai { get; set; }
        string ThongTinTocDo { get; set; }
        int TocDoToGio { get; set; }
        string GiayCoTheIn { get; set; }
        int SoMauIn { get; set; }
        string DonViDemClick { get; set; }
        string HangSanXuat { get; set; }
        int LeBatNhip { get; set; }
        int LeTuTro { get; set; }
    }
}
