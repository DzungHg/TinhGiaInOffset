using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class ChiPhiOffsetKhacModel
    {
        static int lastId = 0;
        public int Id { get; set; }
        public string Ten { get; set; }
        public decimal TienPhi { get; set; }
        public string GhiChu { get; set; }

        public ChiPhiOffsetKhacModel(string ten, decimal tienPhi, string ghiChu)      
        {
            this.Ten = ten;
            TienPhi = tienPhi;
            this.GhiChu = ghiChu;
            lastId += 1;
            this.Id = lastId;
        }
    }
}
