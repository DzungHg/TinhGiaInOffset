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
        private List<ChiPhiBaiInOffsetModel> ChiPhiBaiInBaoGom = new List<ChiPhiBaiInOffsetModel>();
        public TinhGiaInOffsetForm()
        {
            InitializeComponent();
            //Clear all danh sách cho phí
            this.ChiPhiBaiInBaoGom.Clear();
            //Bật tắt nút
           
        }
        private void DauNoiDuLieuChiPhiBaiIn()
        {
            phiBaiInGiaCongRListView.DataSource = null;
            phiBaiInGiaCongRListView.DataSource = ChiPhiBaiInBaoGom;
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
                this.ChiPhiBaiInBaoGom.Add(frm.ChiPhiBaiIn);
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
            if (e.Column.Name == "TenChiPhi")
            {
                e.Column.HeaderText = "Tên Phí In";
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
            if (ChiPhiBaiInBaoGom.Count <= 0)
                return;
            

            var frm = new TaoPhiInOffsetGiaCongForm();
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Sua;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            var model = (ChiPhiBaiInOffsetModel)phiBaiInGiaCongRListView.SelectedItem.DataBoundItem;
            frm.ChiPhiBaiIn = model;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DauNoiDuLieuChiPhiBaiIn();
            }
        }
    }
}
