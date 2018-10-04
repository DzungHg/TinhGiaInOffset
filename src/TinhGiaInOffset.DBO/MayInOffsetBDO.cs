using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.BDO
{
    public class MayInOffsetBDO
    {
        public int Id { get; set; }
        public string TenMayIn { get; set; }
        public string MoTa { get; set; }
        public double KhoGiayToiDaRong { get; set; }
        public double KhoGiayToiDaDai { get; set; }
        public double KhoGiayToiThieuRong { get; set; }
        public double KhoGiayToiThieuDai { get; set; }
        public double KhoInToiDaRong { get; set; }
        public double KhoInToiDaDai { get; set; }
        public double KhoInToiThieuRong { get; set; }
        public double KhoInToiThieuDai { get; set; }
        public string ThongTinTocDo { get; set; }
        public int TocDoToGio { get; set; }
        public string GiayCoTheIn { get; set; }
        public int SoMauIn { get; set; }
        public string DonViDemClick { get; set; }
        public string HangSanXuat { get; set; }
        public int LeBatNhip   { get; set; }
        public int LeTuTro { get; set; }
  
    }
}
