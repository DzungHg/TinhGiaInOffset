using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.DBO
{
    public class MayInOffsetDBO
    {
        public int Id { get; set; }
        public string TenMayIn { get; set; }
        public string MoTa { get; set; }
        public double KhoInToDaRong { get; set; }
        public double KhoInToiDaDai { get; set; }
        public double KhoInToiThieuRong { get; set; }
        public double KhoInToiThieuDai { get; set; }
        public int TocDoToGio { get; set; }
        public int SoMauIn { get; set; }
        public string DonViDemClick { get; set; }
        public string HangSanXuat { get; set; }
    }
}
