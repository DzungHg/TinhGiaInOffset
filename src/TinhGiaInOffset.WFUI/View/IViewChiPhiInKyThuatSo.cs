using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.View
{
    public interface IViewChiPhiInKyThuatSo
    {
        string ChiTietPhiMayIn { get; set; }
        double ThoiGianRIPDuLieuBienDoi { get; set; }
        bool InMotMau { get; set; }
        int SoTrangA4Tinh { get; set; }
        int IdPhiMayInKyThuatSo { get; set; }
        string KetQuaTinhToan { get; set; }
    }
}
