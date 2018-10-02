﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TinhGiaInOffset.WFUI.DTOContext;
using TinhGiaInOffset.WFUI.Model;

namespace TinhGiaInOffset.WFUI
{
    public partial class QuanLyGiaInOffsetGiaCongForm : Telerik.WinControls.UI.RadForm
    {
        private List<GiaInOffsetGiaCongModel> giaInOffsetSrc = null;
        private List<NhaInOffsetModel> nhaInOffsetSrc = new NhaInOffsetContext().DocTatCa();
        public QuanLyGiaInOffsetGiaCongForm()
        {
            InitializeComponent();
            //Cài check
            tatCaNhaInRCheck.Checked = true;
            DauNoiDuLieu();
           
            //
        }

        private void DauNoiDuLieu()
        {
            nhaInOffsetDropDown.DataSource = null;
            nhaInOffsetDropDown.DataSource = nhaInOffsetSrc;
            nhaInOffsetDropDown.DataMember = "Id";
            nhaInOffsetDropDown.DisplayMember = "TenNhaIn";
        }
        private void taoGiaRButton_Click(object sender, EventArgs e)
        {
            var frm = new TaoGiaInOffsetGiaCongForm();
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Moi;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DauNoiDuLieu();
            }
        }
        private void suaGiaRButton_Click(object sender, EventArgs e)
        {
            if (giaInOffsetRGridView.CurrentCell == null)
            {
                MessageBox.Show("Bạn cần chọn gì đó để sửa");
                return;
            }
            var model = (GiaInOffsetGiaCongModel)giaInOffsetRGridView.CurrentRow.DataBoundItem;

            var frm = new TaoGiaInOffsetGiaCongForm();
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Sua;
            frm.giaInSua = model;
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                DauNoiDuLieu();
            }
        }

        private void tatCaNhaInRCheck_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            //Tắt mở
            nhaInOffsetDropDown.Enabled = !tatCaNhaInRCheck.Checked;
            // đấu lại dữ liệu
            
            if (tatCaNhaInRCheck.Checked)
            {
                giaInOffsetSrc = new GiaInOffsetGiaCongContext().DocTatCa();
            }
            else
            {
                if (nhaInOffsetDropDown.SelectedItem != null)
                {
                    var model = (NhaInOffsetModel) nhaInOffsetDropDown.SelectedItem.DataBoundItem;
                    giaInOffsetSrc = new GiaInOffsetGiaCongContext().DocTheoIdNhaInOffset(model.Id);
                }
            }
            giaInOffsetRGridView.DataSource = null;
            giaInOffsetRGridView.DataSource = giaInOffsetSrc;
    }

        private void QuanLyGiaInOffsetGiaCongForm_Resize(object sender, EventArgs e)
        {
            panel01RPanel.Width = ClientSize.Width - 8;
            panel01RPanel.Left = 4;
        }

        private void huyButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giaInOffsetRGridView_CreateCell(object sender, Telerik.WinControls.UI.GridViewCreateCellEventArgs e)
        {
            if (e.Column.Name == "id")
            {
                e.Column.HeaderText = "Id";
                e.Column.Width = 20;
            }
            if (e.Column.Name == "TenGia")
            {
                e.Column.HeaderText = "Tên bảng giá";
                e.Column.Width = 120;
            }
            if (e.Column.Name == "DienGiai")
            {
                e.Column.HeaderText = "Diễn giải";
                e.Column.Width = 200;
            }
            if (e.Column.Name == "idNhaIn")
            {
                
                e.Column.HeaderText = "Id Nhà In";
                e.Column.Width = 120;
                if (tatCaNhaInRCheck.Checked)
                    e.Column.IsVisible = true;
                else
                    e.Column.IsVisible = false;
            }
            if (e.Column.Name == "DoiMayIn")
            {
                e.Column.HeaderText = "Đời máy in";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "DonGiaBai")
            {
                e.Column.HeaderText = "Giá 1 bài";
                e.Column.Width = 60;
            }
            if (e.Column.Name == "GiaDaBaoKem")
            {
                e.Column.HeaderText = "Giá bao kẽm";
                e.Column.Width = 40;
            }
            if (e.Column.Name == "ThongTinLienHe")
            {
                e.Column.HeaderText = "Thông tin liên hệ";
                e.Column.Width = 200;
            }
            if (e.Column.Name == "GhiChu")
            {
                e.Column.HeaderText = "Ghi chú";
                e.Column.Width = 250;
            }
            if (e.Column.Name == "KhongSuDung")
            {
                e.Column.HeaderText = "Không dùng";
                e.Column.Width = 120;
            }
            if (e.Column.Name == "ThuTuSapXem")
            {
                e.Column.HeaderText = "Thứ tự";
                e.Column.Width = 40;
            }
        }
    }
}
