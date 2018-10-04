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
    public partial class TaoChiPhiOffsetKhacForm : Telerik.WinControls.UI.RadForm
    {
        public TinhTrangForm TinhTrangForm { get; set; }
        public ChiPhiOffsetKhacModel chiPhiOffsetKhacModel { get; set; }
        public TaoChiPhiOffsetKhacForm()
        {
            InitializeComponent();
           
        }

     

        private void ResetFormData()
        {
            tienPhiRTextBox.Text = 1.ToString();
            
            
        }
        private bool FormValidation()
        {
            bool output = true;

            if (tenRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
                     

            //so
            decimal thanhTien = 0;
           

            bool thanhTienValid = decimal.TryParse(tienPhiRTextBox.Text, out thanhTien);
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
                        var model = new ChiPhiOffsetKhacModel(tenRTextBox.Text,decimal.Parse(tienPhiRTextBox.Text), ghiChuRTextCtrl.Text);
                        this.chiPhiOffsetKhacModel = model;

                        break;
                    case TinhTrangForm.Sua:
                        //điền lại dữ liệu
                        this.chiPhiOffsetKhacModel.Ten = tenRTextBox.Text ;
                     
                        this.chiPhiOffsetKhacModel.TienPhi = decimal.Parse(tienPhiRTextBox.Text);
                        this.chiPhiOffsetKhacModel.GhiChu = ghiChuRTextCtrl.Text;
                       
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
                  
                    tienPhiRTextBox.Text = this.chiPhiOffsetKhacModel.TienPhi.ToString();
                    ghiChuRTextCtrl.Text = this.chiPhiOffsetKhacModel.GhiChu;
                    //combo
                    break;
            }
        }
    }
}
