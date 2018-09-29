using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.BDO
{
    public class GiaInOffsetGiaCongBDO
    {
        public int Id { get; set; }
        public string TenGia { get; set; }
        public string DienGiai { get; set; }
        public int IdNhaIn { get; set; }
        public int IdMayIn { get; set; }
        public string DoiMayIn { get; set; }
        public int DonGiaBai { get; set; }
        public int SoToChayBuHaoCoBan { get; set; }
        public int SoLuongBaoIn { get; set; }
        public int DonGiaVuot { get; set; }
        public string DonViTinhSoLuong { get; set; }
        public bool GiaDaBaoKem { get; set; }
        public string ThongTinLienHe { get; set; }
        public string GhiChu { get; set; }
        public bool KhongSuDung { get; set; }
        public int ThuTuSapXep { get; set; }
    }
}
