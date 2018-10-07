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
                var line = "------------" + '\r' + '\n';
                var kq = this.MoTa + '\r' + '\n';
                kq += $"Khổ giấy Max: {this.KhoGiayToiDaRong} x {this.KhoGiayToiDaDai}cm" + '\r' + '\n';
                kq += $"Khổ giấy Min: {this.KhoGiayToiThieuRong} x {this.KhoGiayToiThieuDai}cm" + '\r' + '\n';
                kq += line;
                kq += $"Vùng in Max: {this.KhoInToiDaRong} x {this.KhoInToiDaDai}cm" + '\r' + '\n';
                kq += $"Vùng in Min: {this.KhoInToiThieuRong} x {this.KhoInToiThieuDai}cm" + '\r' + '\n';
                kq += line;
                kq += $"Chừa giấy trắng bắt nhíp:" + '\r' + '\n';
                kq += $"Tự trở {this.LeTuTro} cm, trở nhíp {this.LeBatNhip} cm" + '\r' + '\n';
                kq += line;
                kq += $"Giấy có thể in: {this.GiayCoTheIn}" + '\r' + '\n';
                kq += $"Thông tin tốc độ: {this.ThongTinTocDo}" + '\r' + '\n';
                kq +=  $"Tốc độ thường chạy: {this.TocDoToGio} tờ/giờ" + '\r' + '\n';
                kq += $"Số màu: {this.SoMauIn} màu" + '\r' + '\n';
                kq += $"Hãng SX: {this.HangSanXuat}" + '\r' + '\n';
                return kq;

            }    
        }
        //
    }
}
