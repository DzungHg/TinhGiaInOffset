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
        public int SoLuong { get; set; }
        public int DonGia { get; set; }
        public string DonViTinh { get; set; }
        public int IdTinhGia { get; set; }
        public GiaBanThanhPhamModel(string ten, int soLuong, int donGia, string donViTinh)
        {
            this.Ten = ten;
            this.DonGia = donGia;
            this.SoLuong = soLuong;
            this.DonViTinh = donViTinh;
            //giả lập Id
            lastId += 1;
            this.Id = lastId;

        }
    }
}
