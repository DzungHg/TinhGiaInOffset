﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.Common.Enum;

namespace TinhGiaInOffset.WFUI
{
    public partial class TinhGiaInOffsetForm : Telerik.WinControls.UI.RadForm
    {
        public TinhGiaInOffsetModel TinhGiaInOffset = new TinhGiaInOffsetModel();
        public TinhTrangForm TinhTrangForm { get; set; }
        public TinhGiaInOffsetForm()
        {
            InitializeComponent();
            this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom = new List<BaiInOffsetGiaCongModel>();
           
            this.TinhGiaInOffset.GiaBanThanhPhamSauInBaoGom = new List<GiaBanThanhPhamModel>();
            //Clear all danh sách cho phí
            this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom.Clear();
            //Bật tắt nút
           
        }
        private void DauNoiDuLieuChiPhiBaiIn()
        {
            phiBaiInGiaCongRListView.DataSource = null;
            phiBaiInGiaCongRListView.DataSource = this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom;
            phiBaiInGiaCongRListView.ValueMember = "Id";
            phiBaiInGiaCongRListView.DisplayMember = "TenChiPhi";

            giaBanThanhPhamRListView.DataSource = null;
            giaBanThanhPhamRListView.DataSource = this.TinhGiaInOffset.GiaBanThanhPhamSauInBaoGom;


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
            phanTramLoiNhuanGiayRTextBox.Text = 30.ToString();
            phanTramLoiNhuanInRTextBox.Text = 30.ToString();
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
                this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom.Add(frm.BaiInInOffsetGiaCong);
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
        private void SuaBaiIn()
        {
            if (this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom.Count <= 0 ||
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

            this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom.Remove((BaiInOffsetGiaCongModel)phiBaiInGiaCongRListView.SelectedItem.DataBoundItem);
            DauNoiDuLieuChiPhiBaiIn();
        }
       
        //Giá bán thành phẩm
        private void ThemGiaThanhPham()
        {
            var frm = new TaoGiaBanThanhPhamForm();
            frm.Text = "Thêm mới giá thành phẩm";
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Moi;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                //Thêm vô
                this.TinhGiaInOffset.GiaBanThanhPhamSauInBaoGom.Add(frm.giaBanThanhPhamModel);
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
        private void SuaGiaThanhPham()
        {
            if (this.TinhGiaInOffset.GiaBanThanhPhamSauInBaoGom.Count <= 0 ||
                 giaBanThanhPhamRListView.SelectedItems.Count <= 0)
                return;


            var frm = new TaoGiaBanThanhPhamForm();
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Sua;
            var model = (GiaBanThanhPhamModel)giaBanThanhPhamRListView.SelectedItem.DataBoundItem;
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

            this.TinhGiaInOffset.GiaBanThanhPhamSauInBaoGom.Remove((GiaBanThanhPhamModel)giaBanThanhPhamRListView.SelectedItem.DataBoundItem);
            DauNoiDuLieuChiPhiBaiIn();
        }

        //TODO--Làm tiếp formvalidatioin
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

            bool phanTramInMarkupValid = int.TryParse(phanTramLoiNhuanInRTextBox.Text, out phanTramInMarkup);
            if (!phanTramInMarkupValid)
            {
                output = false;
            } else
            {
                if (phanTramInMarkup <=0)
                    output = false;
            }

            bool phanTramGiayMarkupValid = int.TryParse(phanTramLoiNhuanGiayRTextBox.Text, out phanTramGiayMarkup);
            if (!phanTramInMarkupValid)
            {
                output = false;
            }
            else
            {
                if (phanTramGiayMarkup <= 0)
                    output= false;
            }

            bool baiInValid = (this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom.Count > 0);
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
                this.TinhGiaInOffset.TieuDe = tieuDeTinhGiaRTextBox.Text;
                this.TinhGiaInOffset.NgayTinhGia = ngayTinhGiaDateTime.Value;
                this.TinhGiaInOffset.MucLoiNhuanBaiIn = int.Parse(phanTramLoiNhuanInRTextBox.Text);
                this.TinhGiaInOffset.MucLoiNhuanGiay = int.Parse(phanTramLoiNhuanGiayRTextBox.Text);

                ketQuaTinhGiaBoxCtrl.Clear();

                ketQuaTinhGiaBoxCtrl.Text = this.TinhGiaInOffset.TaoTomTat_ChaoGia();
            }
            else
            {
                MessageBox.Show("Bạn cần điền đủ và đúng nội dung thông tin");
            }
        }

        private void TinhGiaInOffsetForm_Load(object sender, EventArgs e)
        {
            tabPageView.TabIndex = 0; //tab đầu tiên
            
            switch (this.TinhTrangForm)
            {
                case TinhTrangForm.Moi:
                    ResetFormData();
                    break;

            }
        }

        private void themRButton_Click(object sender, EventArgs e)
        {
            switch (tabPageView.SelectedPage.Name)
            {
                case "tabInVaGiayPageView":
                    ThemBaiIn();
                    break;
               
                case "tabThanhPhamSauInPageView":
                    ThemGiaThanhPham();
                    break;

            }
        }

        private void suaRButton_Click(object sender, EventArgs e)
        {
            if (tabPageView.SelectedPage.Name == "tabInVaGiayPageView")
            {
                SuaBaiIn();
            }
          
            if (tabPageView.SelectedPage.Name == "tabThanhPhamSauInPageView")
            {
                SuaGiaThanhPham();
            }

        }

        private void xoaRButton_Click(object sender, EventArgs e)
        {
            switch (tabPageView.SelectedPage.Name)
            {
                case "tabInVaGiayPageView":
                    XoaBaiIn();
                    break;
              
                case "tabThanhPhamSauInPageView":
                    XoaGiaThanhPham();
                    break;

            }
        }

       
    }
}
