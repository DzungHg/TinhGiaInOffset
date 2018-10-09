using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class PhiMayInKyThuatSoModel
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public int BHR { get; set; }
        public int TocDoA4HieuQua { get; set; }
        public double ThoiGianSanSang { get; set; }
        public int PhiClickA4BonMau { get; set; }
        public int PhiClickA4MotMau { get; set; }

        public int PhiBaoHanhThang { get; set; }
    }
}
