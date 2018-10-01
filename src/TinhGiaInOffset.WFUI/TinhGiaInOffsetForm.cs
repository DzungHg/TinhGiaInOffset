using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TinhGiaInOffset.WFUI.Model;

namespace TinhGiaInOffset.WFUI
{
    public partial class TinhGiaInOffsetForm : Telerik.WinControls.UI.RadForm
    {
        public TinhGiaInOffsetModel TinhGiaInOffset = new TinhGiaInOffsetModel();
       
        public TinhGiaInOffsetForm()
        {
            InitializeComponent();
            this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom = new List<BaiInOffsetGiaCongModel>();
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
        }

        private void themPhiInOffsetRButton_Click(object sender, EventArgs e)
        {
            var frm = new TaoPhiInOffsetGiaCongForm();
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
        private bool ThemSuaVilidation()
        {
            bool valid = true;
            if (tieuDeRTextBox.Text.Trim().Length == 0)
            {
                valid = false;
            }
            if (yeuCauRTextCtrl.Text.Trim().Length == 0)
            {
                valid = false;
            }
            return valid;
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

        private void suaPhiInOffsetRButton_Click(object sender, EventArgs e)
        {
            if (this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom.Count <= 0 ||
                phiBaiInGiaCongRListView.SelectedItems.Count <= 0)
                return;
            

            var frm = new TaoPhiInOffsetGiaCongForm();
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

        private void xoaPhiInOffsetRButton_Click(object sender, EventArgs e)
        {
            if (phiBaiInGiaCongRListView.SelectedItems.Count <= 0)
                return;

            this.TinhGiaInOffset.BaiInOffsetGiaCongBaoGom.Remove((BaiInOffsetGiaCongModel)phiBaiInGiaCongRListView.SelectedItem.DataBoundItem);
            DauNoiDuLieuChiPhiBaiIn();
        }

        private void tinhToanGiaRButton_Click(object sender, EventArgs e)
        {
            var line01 = this.TinhGiaInOffset.
        }
    }
}
