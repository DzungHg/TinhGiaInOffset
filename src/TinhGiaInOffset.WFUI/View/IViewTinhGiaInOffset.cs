using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.View
{
    public interface IViewTinhGiaInOffset
    {
        string TieuDe { get; set; }
         DateTime NgayTinhGia { get; set; }
         string YeuCau { get; set; }
       string TenNguoiTinhGia { get; set; }
         
        int MucLoiNhuanBaiIn { get; set; }
        int MucLoiNhuanGiay { get; set; }
        int MucLoiNhuanGiayMin { get; set; }
        int MucLoiNhuanInMin { get; set; }
        string TomTatChaoGia { get; set; }
    }
}
