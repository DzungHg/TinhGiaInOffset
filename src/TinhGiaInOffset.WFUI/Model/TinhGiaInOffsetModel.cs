using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class TinhGiaInOffsetModel
    {
        public string TieuDe { get; set; }
        public DateTime NgayTinhGia { get; set; }
        public string YeuCau { get; set; }
        public List<ChiPhiBaiInOffsetModel> ChiPhiInBaoGom { get; set; }
        public int MucLoiNhuanBaiIn { get; set; }
        public int MucLoiNhuanGiay { get; set; }
    }
}
