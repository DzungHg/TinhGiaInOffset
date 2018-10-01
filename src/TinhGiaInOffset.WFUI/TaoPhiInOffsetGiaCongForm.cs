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
using TinhGiaInOffset.WFUI.DTOContext;

namespace TinhGiaInOffset.WFUI
{
    public partial class TaoPhiInOffsetGiaCongForm : Telerik.WinControls.UI.RadForm
    {
        public TinhTrangForm TinhTrangForm { get; set; }
        private GiaInOffsetGiaCongContext giaInOffsetGiaCongContext  = new GiaInOffsetGiaCongContext();
        public ChiPhiBaiInOffsetModel ChiPhiBaiIn { get; set; }
       
        public TaoPhiInOffsetGiaCongForm()
        {
            InitializeComponent();
            //Dau noi du lieu vo combo
            DauNoiDuLieu();
        }

        private void DauNoiDuLieu()
        {
            bangGiaOffsetGiaCongDropDown.DataSource = null;
            bangGiaOffsetGiaCongDropDown.DataSource = giaInOffsetGiaCongContext.DocGiaConSuDung();
            bangGiaOffsetGiaCongDropDown.DataMember = "Id";
            bangGiaOffsetGiaCongDropDown.DisplayMember = "TenGia";
        }

        private void bangGiaOffsetGiaCongDropDown_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
           /* if (tenChiPhiRTextBox.Text.Trim().Length == 0
               )
            {
                tenChiPhiRTextBox.Text = $"{bangGiaOffsetGiaCongDropDown.Text}/ ";
            }*/

            try
            {
                var idGiaIn = ((GiaInOffsetGiaCongModel)bangGiaOffsetGiaCongDropDown.SelectedValue).Id;
                var modelContext = giaInOffsetGiaCongContext.DocTheoId(idGiaIn);
                chiTietBangGiaTextCtrl.Text = modelContext.ChiTietGiaInOffsetGiaCong;
            } catch { }

                   
        }
        private bool FormValidation()
        {
            bool output = true;

            if (tenChiPhiRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }

            if (tenGiayRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (khoGiayRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }

            int donGiaGiay = 0;
            int soTo = 0;
            int soMatIn = 0;

            bool donGiaGiayValid = int.TryParse(donGiaGiayRTextBox.Text, out donGiaGiay);
            if (!donGiaGiayValid)
            {
                output = false;
            }
            else
            {
                if (donGiaGiay <= 0)
                    output = false;
            }

            bool soToValid = int.TryParse(soToGiayRTextBox.Text, out soTo);
            if (!soToValid)
            {
                output = false;
            }
            else
            {
                if (soTo <= 0)
                    output = false;
            }


            bool soMatInValid = int.TryParse(soMatInRTextBox.Text, out soMatIn);
            if (!soMatInValid)
            {
                output = false;
            }
            else
            {
                if (soMatIn <= 0)
                    output = false;
            }

            return output;
        }

        private void taoGiaButton_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                switch (this.TinhTrangForm)
                {
                    case TinhTrangForm.Moi:
                        var modelGiaInOffset = (GiaInOffsetGiaCongModel)bangGiaOffsetGiaCongDropDown.SelectedValue;
                        var modelGiayInOffset = new GiayChoBaiInOffsetModel(tenGiayRTextBox.Text, khoGiayRTextBox.Text,
                            int.Parse(donGiaGiayRTextBox.Text), int.Parse(soToGiayRTextBox.Text), giayDaGomLoiNhuanRCheck.Checked);

                        this.ChiPhiBaiIn = new ChiPhiBaiInOffsetModel(tenChiPhiRTextBox.Text, modelGiaInOffset, modelGiayInOffset, int.Parse(this.soMatInRTextBox.Text));
                        
                        break;
                    case TinhTrangForm.Sua:
                        this.ChiPhiBaiIn.TenChiPhi = tenChiPhiRTextBox.Text;
                        this.ChiPhiBaiIn.Giay.TenGiayIn = hiPhi tenChiPhiRTextBox.Text, modelGiaInOffset, modelGiayInOffset, int.Parse(this.soMatInRTextBox.Text
                        break;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bạn cần điền đầy đủ chi tiết form");
            }
        }
    }
}
