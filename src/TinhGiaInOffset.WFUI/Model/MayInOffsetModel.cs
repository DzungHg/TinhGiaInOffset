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
        public double KhoGiayToiDaRong { get; set; }
        public double KhoGiayToiDaDai { get; set; }
        public double KhoGiayToiThieuRong { get; set; }
        public double KhoGiayToiThieuDai { get; set; }
        public double KhoInToiDaRong { get; set; }
        public double KhoInToiDaDai { get; set; }
        public double KhoInToiThieuRong { get; set; }
        public double KhoInToiThieuDai { get; set; }
        public string ThongTinTocDo { get; set; }
        public int TocDoToGio { get; set; }
        public string GiayCoTheIn { get; set; }
        public int SoMauIn { get; set; }
        public string DonViDemClick { get; set; }
        public string HangSanXuat { get; set; }
        public int LeBatNhip { get; set; }
        public int LeTuTro { get; set; }
        //
        public MayInOffsetModel( string tenMayIn, string moTa, double khoGiayToiDaRong,
                double khoGiayToiDaDai, double khoGiayToiThieuRong, double khoGiayToiThieuDai,
                double khoInToiDaRong, double khoInToiDaDai, double khoInToiThieuRong,
                double khoInToiThieuDai, string thongTinTocDo, int tocDoToGio, 
                string giayCoTheIn, int soMauIn, string donViDemClick, 
                string hangSanXuat, int leBatNhip,int leTuTro)
        {
            this.TenMayIn = tenMayIn;
            this.MoTa = moTa;
            this.KhoGiayToiDaRong = khoGiayToiDaRong;
            this.KhoGiayToiDaDai = khoGiayToiDaDai;
            this.KhoGiayToiThieuRong = khoGiayToiThieuRong;
            this.KhoGiayToiThieuDai = khoGiayToiThieuDai;
            this.KhoInToiDaRong = khoInToiDaRong;
            this.KhoInToiDaDai = khoInToiDaDai;
            this.KhoInToiThieuRong = khoInToiThieuRong;
            this.KhoInToiThieuDai = khoInToiThieuDai;
            this.ThongTinTocDo = thongTinTocDo;
            this.TocDoToGio = tocDoToGio;
            this.GiayCoTheIn = giayCoTheIn;
            this.SoMauIn = soMauIn;
            this.DonViDemClick = donViDemClick;
            this.HangSanXuat = hangSanXuat;
            this.LeBatNhip = leBatNhip;
            this.LeTuTro = leTuTro;

        }
        public MayInOffsetModel()
        {

        }
        public string ChiTietMayIn
        {
            get
            {
                var str01 = this.MoTa + '\r' + '\n';
                var str02 = $"Khô giấy Max: {this.KhoGiayToiDaRong} x {this.KhoGiayToiDaDai}cm" + '\r' + '\n';
              
                var str04 = $"Khô giấy Min: {this.KhoGiayToiThieuRong} x {this.KhoGiayToiThieuDai}cm" + '\r' + '\n';
               
                var str06 = $"Tốc độ: {this.TocDoToGio} tờ/giờ" + '\r' + '\n';
                var str07 = $"Số màu: {this.SoMauIn} màu" + '\r' + '\n';
                var str08 = $"Hãng SX: {this.HangSanXuat}" + '\r' + '\n';
                return str01 + str02 + str04 +  str06 + str07 + str08;

            }    
        }
        //
    }
}
