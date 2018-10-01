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

        private void TinhThanhTien()
        {
            int soLuong = 0;
            int donGia = 0;
            bool soLuongValid = int.TryParse(soLuongRTextBox.Text, out soLuong);
            bool donGiaValid = int.TryParse(donGiaRTextBox.Text, out donGia);

            if (soLuongValid && donGiaValid)
                thanhTienRTextBox.Text = (soLuong * donGia).ToString();
            else
                thanhTienRTextBox.Text = 0.ToString();
        }

        private void ResetFormData()
        {
            soLuongRTextBox.Text = 1.ToString();
            donGiaRTextBox.Text = 1.ToString();
            
        }
        private bool FormValidation()
        {
            bool output = true;

            if (tenRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (donViTinhRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }

            //so
            int soLuong = 0;
            int donGia = 0;

            bool soLuongValid = int.TryParse(soLuongRTextBox.Text, out soLuong);
            if (soLuongValid == false)
                output = false;
            else
            {
                if (soLuong <= 0)
                    output = false;
            }

            bool donGiaValid = int.TryParse(donGiaRTextBox.Text, out donGia);
            if (soLuongValid == false)
                output = false;
            else
            {
                if (donGia <= 0)
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
                        var model = new GiaBanThanhPhamModel(tenRTextBox.Text, int.Parse(soLuongRTextBox.Text), int.Parse(donGiaRTextBox.Text), donGiaRTextBox.Text);
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

        private void tinhThanhTienRButton_Click(object sender, EventArgs e)
        {
            TinhThanhTien();
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
                    donGiaRTextBox.Text = this.giaBanThanhPhamModel.DonGia.ToString();
                    soLuongRTextBox.Text = this.giaBanThanhPhamModel.SoLuong.ToString();
                    donViTinhRTextBox.Text = this.giaBanThanhPhamModel.DonViTinh;
                    break;
            }
        }
    }
}
