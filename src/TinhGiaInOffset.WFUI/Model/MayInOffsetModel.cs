using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinhGiaInOffset.WFUI.Model
{
    public class MayInOffsetModel
    {
        public int Id { get; set; }
        public string TenMayIn { get; set; }
        public string MoTa { get; set; }
        public double KhoInToiDaRong { get; set; }
        public double KhoInToiDaDai { get; set; }
        public double KhoInToiThieuRong { get; set; }
        public double KhoInToiThieuDai { get; set; }
        public int TocDoToGio { get; set; }
        public int SoMauIn { get; set; }
        public string DonViDemClick { get; set; }
        public string HangSanXuat { get; set; }
        //
        public string ChiTietMayIn
        {
            get
            {
                var str01 = this.MoTa + '\r' + '\n';
                var str02 = $"Khô giấy Max rộng: {this.KhoInToiDaRong}cm" + '\r' + '\n';
                var str03 = $"Khô giấy Max dài: {this.KhoInToiDaDai}cm" + '\r' + '\n';
                var str04 = $"Khô giấy Min rộng: {this.KhoInToiThieuRong}cm" + '\r' + '\n';
                var str05 = $"Khô giấy Min dài: {this.KhoInToiThieuDai}cm" + '\r' + '\n';
                var str06 = $"Tốc độ: {this.TocDoToGio} tờ/giờ" + '\r' + '\n';
                var str07 = $"Số màu: {this.SoMauIn} màu" + '\r' + '\n';
                var str08 = $"Hãng SX: {this.HangSanXuat}" + '\r' + '\n';
                return str01 + str02 + str03 + str04 + str05 + str06 + str07 + str08;

            }    
        }
        //
    }
}
