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
        private List<GiaInOffsetGiaCongModel> giaInOffsetGiaCongS  = new GiaInOffsetGiaCongContext().DocGiaConSuDung();
        public BaiInOffsetGiaCongModel BaiInInOffsetGiaCong { get; set; }
       
        public TaoPhiInOffsetGiaCongForm()
        {
            InitializeComponent();
            //Dau noi du lieu vo combo
            DauNoiDuLieu();
        }

        private void DauNoiDuLieu()
        {
            bangGiaOffsetGiaCongDropDown.DataSource = null;
            bangGiaOffsetGiaCongDropDown.DataSource = giaInOffsetGiaCongS;
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
                var modelContext = new GiaInOffsetGiaCongContext().DocTheoId(idGiaIn);
                chiTietBangGiaTextCtrl.Text = modelContext.ChiTietGiaInOffsetGiaCong;
            } catch { }

                   
        }
        private bool FormValidation()
        {
            bool output = true;

            if (tenBaiInOffsetRTextBox.Text.Trim().Length == 0)
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
                var modelGiaInOffset = (GiaInOffsetGiaCongModel)bangGiaOffsetGiaCongDropDown.SelectedValue;
                switch (this.TinhTrangForm)
                {
                    case TinhTrangForm.Moi:
                       
                        var modelGiayInOffset = new GiayChoBaiInOffsetModel(tenGiayRTextBox.Text, khoGiayRTextBox.Text,
                            int.Parse(donGiaGiayRTextBox.Text), int.Parse(soToGiayRTextBox.Text), giayDaGomLoiNhuanRCheck.Checked);

                        this.BaiInInOffsetGiaCong = new BaiInOffsetGiaCongModel(tenBaiInOffsetRTextBox.Text, modelGiaInOffset.Id, modelGiaInOffset.TenGia,
                            int.Parse(soMatInRTextBox.Text), tenGiayRTextBox.Text, khoGiayRTextBox.Text, int.Parse(donGiaGiayRTextBox.Text),
                            int.Parse(soToGiayRTextBox.Text), giayDaGomLoiNhuanRCheck.Checked);
                            
                        
                        break;
                    case TinhTrangForm.Sua:
                        this.BaiInInOffsetGiaCong.TenBaiIn = tenBaiInOffsetRTextBox.Text;
                        this.BaiInInOffsetGiaCong.IdGiaInOffsetGiaCong = modelGiaInOffset.Id;
                        this.BaiInInOffsetGiaCong.TenGiaInOffsetGiaCong = modelGiaInOffset.TenGia;
                        this.BaiInInOffsetGiaCong.SoMatCanIn = int.Parse(soMatInRTextBox.Text);
                        this.BaiInInOffsetGiaCong.TenGiay = tenGiayRTextBox.Text;
                        this.BaiInInOffsetGiaCong.KhoGiay = khoGiayRTextBox.Text;
                        this.BaiInInOffsetGiaCong.DonGiayTheoTo = int.Parse(donGiaGiayRTextBox.Text);
                        this.BaiInInOffsetGiaCong.SoLuongToGiay = int.Parse(soToGiayRTextBox.Text);
                        this.BaiInInOffsetGiaCong.GiayDaCoLoiNhuan = giayDaGomLoiNhuanRCheck.Checked;

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

        private void TaoPhiInOffsetGiaCongForm_Load(object sender, EventArgs e)
        {
            switch (this.TinhTrangForm)
            {
                case TinhTrangForm.Moi:
                    break;
                case TinhTrangForm.Sua:
                    tenBaiInOffsetRTextBox.Text = this.BaiInInOffsetGiaCong.TenBaiIn;
                    tenGiayRTextBox.Text = this.BaiInInOffsetGiaCong.TenGiay;
                    khoGiayRTextBox.Text = this.BaiInInOffsetGiaCong.KhoGiay;
                    donGiaGiayRTextBox.Text = this.BaiInInOffsetGiaCong.DonGiayTheoTo.ToString();
                    soToGiayRTextBox.Text = this.BaiInInOffsetGiaCong.SoLuongToGiay.ToString();
                    giayDaGomLoiNhuanRCheck.Checked = this.BaiInInOffsetGiaCong.GiayDaCoLoiNhuan;
                    soMatInRTextBox.Text = this.BaiInInOffsetGiaCong.SoMatCanIn.ToString();
                    //Định 
                    int index = 0;
                    foreach (var item in bangGiaOffsetGiaCongDropDown.Items)
                    {
                        if (((GiaInOffsetGiaCongModel)item.DataBoundItem).Id == this.BaiInInOffsetGiaCong.IdGiaInOffsetGiaCong)
                        {
                            index = item.RowIndex;
                            break;
                        }
                    }
                    bangGiaOffsetGiaCongDropDown.SelectedIndex = index;

                    break;
            }
        }
    }
}
