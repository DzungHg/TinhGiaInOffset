using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class GiaBanThanhPhamModel
    {
        
        public int Id { get; set; }
        public string Ten { get; set; }
        public int SoLuong { get; set; }
        public string DonViTinh { get; set; }
        public decimal ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public int IdTinhGia { get; set; }
        public string LoaiThanhPham { get; set; }
       
    }
}
