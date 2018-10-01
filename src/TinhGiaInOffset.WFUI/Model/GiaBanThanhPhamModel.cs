using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class GiaBanThanhPhamModel
    {
        private static int lastId = 0;
        public int Id { get; set; }
        public string Ten { get; set; }
        public decimal ThanhTien { get; set; }
        public string GhiChu { get; set; }
        public int IdTinhGia { get; set; }
        public GiaBanThanhPhamModel(string ten, decimal thanhTien, string ghiChu)
        {
            this.Ten = ten;
            this.ThanhTien = thanhTien;
            this.GhiChu = ghiChu;
            //giả lập Id
            lastId += 1;
            this.Id = lastId;

        }
    }
}
