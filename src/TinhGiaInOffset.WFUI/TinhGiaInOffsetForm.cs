using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.Common.Enum;
using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.WFUI.Presentation;

namespace TinhGiaInOffset.WFUI
{
    public partial class TinhGiaInOffsetForm : Telerik.WinControls.UI.RadForm, IViewTinhGiaInOffset
    {
        TinhGiaInOffsetPresenter tinhGiaOffsetPres;
       
        public TinhTrangForm TinhTrangForm { get; set; }

        #region implement IViewTinhGiaInOffset
        public string TieuDe
        {
            get
            {
                return tieuDeTinhGiaRTextBox.Text;
            }

            set
            {
                tieuDeTinhGiaRTextBox.Text = value;
               
            }
        }

        public DateTime NgayTinhGia
        {
            get
            {
                return ngayTinhGiaDateTime.Value;
            }

            set
            {
                ngayTinhGiaDateTime.Value = value;
            }
        }

        public string YeuCau
        {
            get
            {
                return yeuCauRTextCtrl.Text;
            }

            set
            {
                yeuCauRTextCtrl.Text = value;
            }
        }

        public string TenNguoiTinhGia
        {
            get
            {
                return tenNguoiTinhGiaRTextBox.Text;
            }

            set
            {
                tenNguoiTinhGiaRTextBox.Text = value;
            }
        }

        public int MucLoiNhuanBaiIn
        {
            get
            {
                return (int)phanTramLoiNhuanInSpin.Value;
                
            }

            set
            {
                phanTramLoiNhuanGiaySpin.Value = value;
            }
        }

        public int MucLoiNhuanGiay
        {
            get
            {
                return (int)phanTramLoiNhuanGiaySpin.Value;
            }

            set
            {
                phanTramLoiNhuanGiaySpin.Value = value;
                     
            }
        }

        public string TomTatChaoGia
        {
            get
            {
                return tomTatChaoGiaTextBoxCtrl.Text;
            }

            set
            {
                tomTatChaoGiaTextBoxCtrl.Text = value;
            }
        }

        public int MucLoiNhuanGiayMin
        {
            get;set;
        }

        public int MucLoiNhuanInMin
        {
            get; set;
        }
        #endregion

        public TinhGiaInOffsetForm()
        {
            InitializeComponent();
            tinhGiaOffsetPres = new TinhGiaInOffsetPresenter(this);
            //Khởi tạo các giá trị
            tinhGiaOffsetPres.KhoiTaoGiaTriBanDau();
            //set 2 spin
            phanTramLoiNhuanInSpin.Minimum = this.MucLoiNhuanInMin;
            phanTramLoiNhuanGiaySpin.Minimum = this.MucLoiNhuanGiayMin;


        }
        private void DauNoiDuLieuChiPhiBaiIn()
        {
            phiBaiInGiaCongRListView.DataSource = null;
            phiBaiInGiaCongRListView.DataSource = tinhGiaOffsetPres.BaiInOffsetGiaCongBaoGom;
            phiBaiInGiaCongRListView.ValueMember = "Id";
            phiBaiInGiaCongRListView.DisplayMember = "TenChiPhi";
            phiBaiInGiaCongRListView.IsAccessible = false;

            giaBanThanhPhamRListView.DataSource = null;
            giaBanThanhPhamRListView.DataSource = tinhGiaOffsetPres.GiaBanThanhPhamTaiChoBaoGom;
            giaBanThanhPhamRListView.ValueMember = "Id";
            giaBanThanhPhamRListView.DisplayMember = "Ten";
            giaBanThanhPhamRListView.IsAccessible = false;
            //            
            giaBanThanhPhamGiaCongRListView.DataSource = null;
            giaBanThanhPhamGiaCongRListView.DataSource = tinhGiaOffsetPres.GiaBanThanhPhamGiaCongBaoGom;
            giaBanThanhPhamGiaCongRListView.ValueMember = "Id";
            giaBanThanhPhamGiaCongRListView.DisplayMember = "Ten";
            giaBanThanhPhamGiaCongRListView.IsAccessible = false;
            //
            chiPhiKhacRListView.DataSource = null;
            chiPhiKhacRListView.DataSource = tinhGiaOffsetPres.ChiPhiKhacBaoGom;
            chiPhiKhacRListView.ValueMember = "Id";
            chiPhiKhacRListView.DisplayMember = "Ten";
            chiPhiKhacRListView.IsAccessible = false;

        }

        private bool ThemSuaVilidation()
        {
            bool valid = true;
            if (tieuDeTinhGiaRTextBox.Text.Trim().Length == 0)
            {
                valid = false;
            }
            if (yeuCauRTextCtrl.Text.Trim().Length == 0)
            {
                valid = false;
            }
            return valid;
        }
        private void ResetFormData()
        {
            ngayTinhGiaDateTime.Value = DateTime.Today;
            phanTramLoiNhuanGiaySpin.Text = 30.ToString();
            phanTramLoiNhuanInSpin.Text = 30.ToString();
        }
        private void phiBaiInGiaCongRListView_ColumnCreating(object sender, Telerik.WinControls.UI.ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.Name == "Id")
            {
                e.Column.HeaderText = "Id";
                e.Column.Width = 20;
            }
            if (e.Column.Name == "TenBaiIn")
            {
                e.Column.HeaderText = "Tên Bài In";
                e.Column.Width = 120;
            }
            if (e.Column.Name == "DienGiai")
            {
                e.Column.HeaderText = "Diễn giải";
                e.Column.Width = 240;
            }
            if (e.Column.Name == "IdGiaInOffsetGiaCong")
            {
                e.Column.HeaderText = "Id Bảng giá";
                e.Column.Width = 120;
                e.Column.Visible = false;
            }
            if (e.Column.Name == "TenGiaInOffsetGiaCong")
            {
                e.Column.HeaderText = "Bảng Giá Gia Công";
                e.Column.Width = 120;
            }
            if (e.Column.Name == "SoMatCanIn")
            {
                e.Column.HeaderText = "Số mặt cần in";
                e.Column.Width = e.Column.HeaderText.Length * 5;

            }
        }
       

        private void giaBanThanhPhamRListView_ColumnCreating(object sender, Telerik.WinControls.UI.ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.Name == "Id")
            {
                e.Column.HeaderText = "Id";
                e.Column.Width = 20;
            }
            if (e.Column.Name == "Ten")
            {
                e.Column.HeaderText = "Tên";
                e.Column.Width = 120;
            }
            if (e.Column.Name == "SoLuong")
            {
                e.Column.HeaderText = "Số lượng";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "DonViTinh")
            {
                e.Column.HeaderText = "ĐVT";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "ThanhTien")
            {
                e.Column.HeaderText = "Thành tiền";
                e.Column.Width = 120;
            }
            if (e.Column.Name == "IdTinhGia")
            {
                e.Column.HeaderText = "Id Bảng giá";
                e.Column.Width = 120;
                e.Column.Visible = false;
            }
            if (e.Column.Name == "GhiChu")
            {
                e.Column.HeaderText = "Ghi chú";
                e.Column.Width = 250;
            }
            if (e.Column.Name == "LoaiThanhPham")
            {
                e.Column.HeaderText = "Loại TP";
                e.Column.Width = 60;
                e.Column.Visible = false;
            }
        }
        #region Them, sua, xoa bai in
        private void ThemBaiIn()
        {
            var frm = new TaoBaiInOffsetGiaCongForm();
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Moi;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                //Thêm vô
                tinhGiaOffsetPres.BaiInOffsetGiaCongBaoGom.Add(frm.BaiInInOffsetGiaCong);
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
       
        private void SuaBaiIn()
        {
            if (tinhGiaOffsetPres.BaiInOffsetGiaCongBaoGom.Count <= 0 ||
                phiBaiInGiaCongRListView.SelectedItems.Count <= 0)
                return;


            var frm = new TaoBaiInOffsetGiaCongForm();
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Sua;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            var model = (BaiInOffsetGiaCongModel)phiBaiInGiaCongRListView.SelectedItem.DataBoundItem;
            frm.BaiInInOffsetGiaCong = model;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
        private void XoaBaiIn()
        {
            if (phiBaiInGiaCongRListView.SelectedItems.Count <= 0)
                return;

            tinhGiaOffsetPres.BaiInOffsetGiaCongBaoGom.Remove((BaiInOffsetGiaCongModel)phiBaiInGiaCongRListView.SelectedItem.DataBoundItem);
            DauNoiDuLieuChiPhiBaiIn();
        }
        #endregion;
        //Giá bán thành phẩm
        #region them, sua, xoa thanh pham tai cho
        private void ThemGiaThanhPham()
        {
            var frm = new TaoGiaBanThanhPhamTaiChoForm();
            frm.Text = "Thêm mới giá thành phẩm";
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Moi;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                //Thêm vô
                tinhGiaOffsetPres.GiaBanThanhPhamTaiChoBaoGom.Add(frm.giaBanThanhPhamModel);
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
        private void SuaGiaThanhPham()
        {
            if (tinhGiaOffsetPres.GiaBanThanhPhamTaiChoBaoGom.Count <= 0 ||
                 giaBanThanhPhamRListView.SelectedItems.Count <= 0)
                return;


            var frm = new TaoGiaBanThanhPhamTaiChoForm();
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Sua;
            var model = (GiaBanThanhPhamTaiChoModel)giaBanThanhPhamRListView.SelectedItem.DataBoundItem;
            frm.Text = $"Sửa Giá thành phẩm Id [{model.Id}]";
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.giaBanThanhPhamModel = model;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
        private void XoaGiaThanhPham()
        {
            if (giaBanThanhPhamRListView.SelectedItems.Count <= 0)
                return;

            tinhGiaOffsetPres.GiaBanThanhPhamTaiChoBaoGom.Remove((GiaBanThanhPhamTaiChoModel)giaBanThanhPhamRListView.SelectedItem.DataBoundItem);
            DauNoiDuLieuChiPhiBaiIn();
        }
        #endregion

        #region them, sua, xoa ThanhPham Gia cong
        private void ThemGiaThanhPhamGiaCong()
        {
            var frm = new TaoGiaBanThanhPhamGiaCongForm();
            frm.Text = "Thêm mới giá thành phẩm";
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Moi;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                //Thêm vô
                tinhGiaOffsetPres.GiaBanThanhPhamGiaCongBaoGom.Add(frm.giaBanThanhPhamModel);
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
        private void SuaGiaThanhPhamGiaCong()
        {
            if (tinhGiaOffsetPres.GiaBanThanhPhamGiaCongBaoGom.Count <= 0 ||
                 giaBanThanhPhamGiaCongRListView.SelectedItems.Count <= 0)
                return;


            var frm = new TaoGiaBanThanhPhamGiaCongForm();
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Sua;
            var model = (GiaBanThanhPhamGiaCongModel)giaBanThanhPhamGiaCongRListView.SelectedItem.DataBoundItem;
            frm.Text = $"Sửa Giá TP Gia công Id [{model.Id}]";
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.giaBanThanhPhamModel = model;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
        private void XoaGiaThanhPhamGiaCong()
        {
            if (giaBanThanhPhamGiaCongRListView.SelectedItems.Count <= 0)
                return;

            tinhGiaOffsetPres.GiaBanThanhPhamGiaCongBaoGom.Remove((GiaBanThanhPhamGiaCongModel)giaBanThanhPhamGiaCongRListView.SelectedItem.DataBoundItem);
            DauNoiDuLieuChiPhiBaiIn();
        }
        #endregion

        #region PhiInOffset khac: Them, Sua, Xoa
        private void ThemChiPhiInOffsetKhac()
        {
            var frm = new TaoChiPhiOffsetKhacForm();
            frm.Text = "Thêm mới phí in offset";
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Moi;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                //Thêm vô
                tinhGiaOffsetPres.ChiPhiKhacBaoGom.Add(frm.chiPhiOffsetKhacModel);
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
        private void SuaChiPhiInOffsetKhac()
        {
            if (tinhGiaOffsetPres.ChiPhiKhacBaoGom.Count <= 0 ||
                 chiPhiKhacRListView.SelectedItems.Count <= 0)
                return;


            var frm = new TaoChiPhiOffsetKhacForm();
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Sua;
            var model = (ChiPhiOffsetKhacModel) chiPhiKhacRListView.SelectedItem.DataBoundItem;
            frm.Text = $"Sửa Chi phí in Offset Id [{model.Id}]";
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;

            frm.chiPhiOffsetKhacModel = model;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
        private void XoaChiPhiInOffsetKhac()
        {
            if (chiPhiKhacRListView.SelectedItems.Count <= 0)
                return;

            tinhGiaOffsetPres.ChiPhiKhacBaoGom.Remove((ChiPhiOffsetKhacModel)chiPhiKhacRListView.SelectedItem.DataBoundItem);
            DauNoiDuLieuChiPhiBaiIn();
        }
        #endregion
    
        
        private bool FormValidation()
        {
            bool output = true;

            if (tieuDeTinhGiaRTextBox.Text.Trim().Length == 0)
                output = false;
            if (yeuCauRTextCtrl.Text.Trim().Length == 0)
                output = false;
            if (tenNguoiTinhGiaRTextBox.Text.Trim().Length == 0)
                output = false;
            int phanTramInMarkup = 0;
            int phanTramGiayMarkup = 0;

            bool phanTramInMarkupValid = int.TryParse(phanTramLoiNhuanInSpin.Text, out phanTramInMarkup);
            if (!phanTramInMarkupValid)
            {
                output = false;
            } else
            {
                if (phanTramInMarkup <=0)
                    output = false;
            }

            bool phanTramGiayMarkupValid = int.TryParse(phanTramLoiNhuanGiaySpin.Text, out phanTramGiayMarkup);
            if (!phanTramInMarkupValid)
            {
                output = false;
            }
            else
            {
                if (phanTramGiayMarkup <= 0)
                    output= false;
            }

            bool baiInValid = (tinhGiaOffsetPres.BaiInOffsetGiaCongBaoGom.Count > 0);
            if (!baiInValid )
            {
                output = false;
            }
            


            return output;
        }
        private void tinhToanGiaRButton_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                //Gắn trước một số dữ liệu
              

                tomTatChaoGiaTextBoxCtrl.Clear();

                tomTatChaoGiaTextBoxCtrl.Text = tinhGiaOffsetPres.TaoTomTat_ChaoGia();
                tomTatQuanLyTextBoxCtrl.Text = tinhGiaOffsetPres.TaoTomTat_QuanLy();
            }
            else
            {
                MessageBox.Show("Bạn cần điền đủ và đúng nội dung thông tin");
            }
        }

        private void TinhGiaInOffsetForm_Load(object sender, EventArgs e)
        {
            PageViewChiTiet.TabIndex = 0; //tab đầu tiên
            
            switch (this.TinhTrangForm)
            {
                case TinhTrangForm.Moi:
                    ResetFormData();
                    break;

            }
            tieuDeFormLabel.Left = (ClientSize.Width - tieuDeFormLabel.Width) / 2;
            tenNguoiTinhGiaRTextBox.NullText = "Tên người tính giá";
            tieuDeTinhGiaRTextBox.NullText = "Tiêu đề";
            yeuCauRTextCtrl.NullText = "Yêu cầu";
        }

        private void themRButton_Click(object sender, EventArgs e)
        {
            switch (PageViewChiTiet.SelectedPage.Name)
            {
                case "tabInVaGiayPageView":
                    ThemBaiIn();
                    break;
               
                case "tabThanhPhamTai123PageView":
                    ThemGiaThanhPham();
                    break;
                case "tabThanhPhamGiaCongPageView":
                    ThemGiaThanhPhamGiaCong();
                        break;
                case "tabChiPhiKhacPageView":
                    ThemChiPhiInOffsetKhac();
                    break;

            }
        }

        private void suaRButton_Click(object sender, EventArgs e)
        {
            if (PageViewChiTiet.SelectedPage.Name == "tabInVaGiayPageView")
            {
                SuaBaiIn();
            }
          
            if (PageViewChiTiet.SelectedPage.Name == "tabThanhPhamTai123PageView")
            {
                SuaGiaThanhPham();
            }
            if (PageViewChiTiet.SelectedPage.Name == "tabThanhPhamGiaCongPageView")
            {
                SuaGiaThanhPhamGiaCong();
            }
            if (PageViewChiTiet.SelectedPage.Name == "tabChiPhiKhacPageView")
            {
                SuaChiPhiInOffsetKhac();
            }
        }

        private void xoaRButton_Click(object sender, EventArgs e)
        {
            switch (PageViewChiTiet.SelectedPage.Name)
            {
                case "tabInVaGiayPageView":
                    XoaBaiIn();
                    break;
              
                case "tabThanhPhamTai123PageView":
                    XoaGiaThanhPham();
                    break;
                case "tabThanhPhamGiaCongPageView":
                    XoaGiaThanhPhamGiaCong();
                    break;
                case "tabChiPhiKhacPageView":
                    XoaChiPhiInOffsetKhac();
                    break;
            }
        }

        private void giaBanThanhPhamGiaCongRListView_ColumnCreating(object sender, Telerik.WinControls.UI.ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.Name == "Id")
            {
                e.Column.HeaderText = "Id";
                e.Column.Width = 20;
            }
            if (e.Column.Name == "Ten")
            {
                e.Column.HeaderText = "Tên";
                e.Column.Width = 120;
            }
            if (e.Column.Name == "SoLuong")
            {
                e.Column.HeaderText = "Số lượng";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "DonViTinh")
            {
                e.Column.HeaderText = "ĐVT";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "ThanhTien")
            {
                e.Column.HeaderText = "Phí gia công";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "MucLoiNhuan")
            {
                e.Column.HeaderText = "Mức lợi nhuận";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "GiaBanText")
            {
                e.Column.HeaderText = "Giá bán";

                e.Column.Width = 60;
            }
            if (e.Column.Name == "GiaBan")
            {
                e.Column.HeaderText = "Giá bán";

                e.Column.Visible = false;
            }

            if (e.Column.Name == "IdTinhGia")
            {
                e.Column.HeaderText = "Id Bảng giá";
                e.Column.Width = 120;
                e.Column.Visible = false;
            }
            if (e.Column.Name == "GhiChu")
            {
                e.Column.HeaderText = "Ghi chú";
                e.Column.Width = 250;
            }
            if (e.Column.Name == "LoaiThanhPham")
            {
                e.Column.HeaderText = "Loại TP";
                e.Column.Width = 60;
                e.Column.Visible = false;
            }
        }

        private void chiPhiKhacRListView_ColumnCreating(object sender, Telerik.WinControls.UI.ListViewColumnCreatingEventArgs e)
        {
            if (e.Column.Name == "Id")
            {
                e.Column.HeaderText = "Id";
                e.Column.Width = 20;
            }
            if (e.Column.Name == "Ten")
            {
                e.Column.HeaderText = "Tên";
                e.Column.Width = 120;
            }
            if (e.Column.Name == "TienPhi")
            {
                e.Column.HeaderText = "Tiền phí";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "GhiChu")
            {
                e.Column.HeaderText = "Ghi chú";
                e.Column.Width = 60;
            }
         
        }
    }
}
