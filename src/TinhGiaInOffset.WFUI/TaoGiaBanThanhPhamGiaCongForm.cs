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
    public partial class TaoGiaBanThanhPhamGiaCongForm : Telerik.WinControls.UI.RadForm
    {
        public TinhTrangForm TinhTrangForm { get; set; }
        public GiaBanThanhPhamGiaCongModel giaBanThanhPhamModel { get; set; }
        public TaoGiaBanThanhPhamGiaCongForm()
        {
            InitializeComponent();
            DauNoiDuLieuDropBox();
        }

        private void DauNoiDuLieuDropBox()
        {
            loaiThanhPhamDropDown.DataSource = Enum.GetValues(typeof(LoaiGiaSauInKemOffset));
        }

        private void ResetFormData()
        {
            phiGiaCongRTextBox.Text = 1.ToString();
            soLuongRTextBox.Text = 1.ToString();
            mucLoiNhuanRTextBox.Text = 30.ToString();
            
        }
        private bool FormValidation()
        {
            bool output = true;

            if (tenRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if ( donViTinhRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            

            //so
            decimal thanhTien = 0;
            int soLuong = 0;
            int mucLoiNhuan = 0;

            bool thanhTienValid = decimal.TryParse(phiGiaCongRTextBox.Text, out thanhTien);
            if (thanhTienValid == false)
                output = false;
            else
            {
                if (thanhTien <= 0)
                    output = false;
            }

            bool soLuongValid = int.TryParse(soLuongRTextBox.Text, out soLuong);
            if (soLuongValid == false)
                output = false;
            else
            {
                if (soLuong <= 0)
                    output = false;
            }

            bool mucLoiNhuanValid = int.TryParse(mucLoiNhuanRTextBox.Text, out mucLoiNhuan);
            if (mucLoiNhuanValid == false)
                output = false;
            else
            {
                if (mucLoiNhuan <= 0 || mucLoiNhuan >= 100)
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
                        var model = new GiaBanThanhPhamGiaCongModel(tenRTextBox.Text, int.Parse(soLuongRTextBox.Text),
                            donViTinhRTextBox.Text, decimal.Parse(phiGiaCongRTextBox.Text), 
                            ghiChuRTextCtrl.Text, loaiThanhPhamDropDown.Text, int.Parse(mucLoiNhuanRTextBox.Text));
                        this.giaBanThanhPhamModel = model;

                        break;
                    case TinhTrangForm.Sua:
                        //điền lại dữ liệu
                        this.giaBanThanhPhamModel.Ten = tenRTextBox.Text ;
                        this.giaBanThanhPhamModel.SoLuong = int.Parse(soLuongRTextBox.Text);
                        this.giaBanThanhPhamModel.DonViTinh = donViTinhRTextBox.Text;
                        this.giaBanThanhPhamModel.ThanhTien = decimal.Parse(phiGiaCongRTextBox.Text);
                        this.giaBanThanhPhamModel.GhiChu = ghiChuRTextCtrl.Text;
                        this.giaBanThanhPhamModel.LoaiThanhPham = loaiThanhPhamDropDown.Text;
                        this.giaBanThanhPhamModel.MucLoiNhuan = int.Parse(mucLoiNhuanRTextBox.Text);
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
                    soLuongRTextBox.Text = this.giaBanThanhPhamModel.SoLuong.ToString();
                    donViTinhRTextBox.Text = this.giaBanThanhPhamModel.DonViTinh;
                    phiGiaCongRTextBox.Text = this.giaBanThanhPhamModel.ThanhTien.ToString();
                    ghiChuRTextCtrl.Text = this.giaBanThanhPhamModel.GhiChu;
                    mucLoiNhuanRTextBox.Text = this.giaBanThanhPhamModel.MucLoiNhuan.ToString();
                    //combo
                    break;
            }
            tieuDeFormLabel.Left = (ClientSize.Width - tieuDeFormLabel.Width) / 2;
        }
    }
}
