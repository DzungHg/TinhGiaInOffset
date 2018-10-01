using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TinhGiaInOffset.Common.Enum;
using TinhGiaInOffset.WFUI.Model;

namespace TinhGiaInOffset.WFUI
{
    public partial class TaoGiaBanThanhPhamForm : Telerik.WinControls.UI.RadForm
    {
        public TinhTrangForm TinhTrangForm { get; set; }
        public GiaBanThanhPhamModel giaBanThanhPhamModel { get; set; }
        public TaoGiaBanThanhPhamForm()
        {
            InitializeComponent();
        }

       

        private void ResetFormData()
        {
            thanhTienRTextBox.Text = 1.ToString();
            
            
        }
        private bool FormValidation()
        {
            bool output = true;

            if (tenRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (ghiChuRTextCtrl.Text.Trim().Length == 0)
            {
                output = false;
            }

            //so
            decimal thanhTien = 0;
           

            bool thanhTienValid = decimal.TryParse(thanhTienRTextBox.Text, out thanhTien);
            if (thanhTienValid == false)
                output = false;
            else
            {
                if (thanhTien <= 0)
                    output = false;
            }

           


            return output;
        }

        private void taoRButton_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                switch (this.TinhTrangForm)
                {
                    case TinhTrangForm.Moi:
                        var model = new GiaBanThanhPhamModel(tenRTextBox.Text, decimal.Parse(thanhTienRTextBox.Text), ghiChuRTextCtrl.Text);
                        this.giaBanThanhPhamModel = model;

                        break;
                }
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn cần điền đúng");

            }
        }

      

        private void TaoGiaBanThanhPhamForm_Load(object sender, EventArgs e)
        {
            switch (this.TinhTrangForm)
            {
                case TinhTrangForm.Moi:
                    tieuDeFormLabel.Text = this.Text;
                    ResetFormData();
                    break;
                case TinhTrangForm.Sua:
                    tieuDeFormLabel.Text = this.Text;
                    tenRTextBox.Text = this.giaBanThanhPhamModel.Ten;
                    thanhTienRTextBox.Text = this.giaBanThanhPhamModel.ThanhTien.ToString();
                    ghiChuRTextCtrl.Text = this.giaBanThanhPhamModel.GhiChu;
                    break;
            }
        }
    }
}
