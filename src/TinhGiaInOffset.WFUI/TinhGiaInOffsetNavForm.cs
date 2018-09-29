using System;
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
    }
}
