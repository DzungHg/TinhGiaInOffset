﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TinhGiaInOffset.WFUI
{
    public partial class TinhGiaInOffsetNavForm : Telerik.WinControls.UI.RadForm
    {
        public TinhGiaInOffsetNavForm()
        {
            InitializeComponent();
        }

        private void quanLyGiaInOffsetRMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new QuanLyGiaInOffsetGiaCongForm();
            
            frm.ShowDialog();
        }

        private void thoatRMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void themTinhGiaOffsetRButton_Click(object sender, EventArgs e)
        {
            var frm = new TinhGiaInOffsetForm();
            frm.Text = "Tính Giá In Offset Gia Công";
            frm.TinhTrangForm = Common.Enum.TinhTrangForm.Moi;
            frm.MaximizeBox = false;
            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Show();

        }

        private void xemBangGiaInOffsetGiaCongRButton_Click(object sender, EventArgs e)
        {
            var frm = new XemBangGiaInOffsetGiaCongForm();
            frm.Text = "Bảng Giá In Offset Gia Công";
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }

        private void phiInNhanhRButton_Click(object sender, EventArgs e)
        {
            var frm = new ChiPhiInKyThuatSoForm();
            frm.Text = "Chi Phí In Kỹ Thuật Số";
            frm.MaximizeBox = false;
            frm.MinimizeBox = false;
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.Show();
        }
    }
}
