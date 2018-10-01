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
    public partial class TaoBaiInOffsetGiaCongForm : Telerik.WinControls.UI.RadForm
    {
        public TinhTrangForm TinhTrangForm { get; set; }
        private List<GiaInOffsetGiaCongModel> giaInOffsetGiaCongS  = new GiaInOffsetGiaCongContext().DocGiaConSuDung();
        public BaiInOffsetGiaCongModel BaiInInOffsetGiaCong { get; set; }
       
        public TaoBaiInOffsetGiaCongForm()
        {
            InitializeComponent();
            //Dau noi du lieu vo combo
            DauNoiDuLieu();
            DuLieuKieuInOffset();
        }

        private void DauNoiDuLieu()
        {
            bangGiaOffsetGiaCongDropDown.DataSource = null;
            bangGiaOffsetGiaCongDropDown.DataSource = giaInOffsetGiaCongS;
            bangGiaOffsetGiaCongDropDown.DataMember = "Id";
            bangGiaOffsetGiaCongDropDown.DisplayMember = "TenGia";
        }
        private void DuLieuKieuInOffset()
        {
            //Bind the account level settings
            /* foreach (KieuInOffset kieuIn in Enum.GetValues(typeof(KieuInOffset)))
             {
                 kieuInOffsetDropDown.Items.Add(kieuIn.ToString());
                 kieuInOffsetDropDown.SelectedIndex = 0;
             }*/
            kieuInOffsetDropDown.DataSource = Enum.GetValues(typeof(KieuInOffset));
            kieuInOffsetDropDown.SelectedIndex = 0;
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
        private void ResetFormData()
        {
            soMatInRTextBox.Text = 500.ToString();
            soKemRTextBox.Text = "1";
            soToChayBuHaoThucCanRTextBox.Text = 50.ToString();
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
            if (dienGiaiRTextCtrl.Text.Trim().Length == 0)
            {
                output = false;
            }
           

            int donGiaGiay = 0;
            int soTo = 0;
            int soMatIn = 0;
            int soKemIn = 0;
            int soToChayBuHaoThucCan;

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

            bool soKemInValid = int.TryParse(soKemRTextBox.Text, out soKemIn);
            if (!soKemInValid)
            {
                output = false;
            }
            else
            {
                if (soKemIn < 1)
                    output = false;
            }
            bool soToChayBuHaoThucCanValid = int.TryParse(soToChayBuHaoThucCanRTextBox.Text, out soToChayBuHaoThucCan);
            if (!soToChayBuHaoThucCanValid)
            {
                output = false;
            }
            else
            {
                if (soToChayBuHaoThucCan < 50)
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

                        this.BaiInInOffsetGiaCong = new BaiInOffsetGiaCongModel(tenBaiInOffsetRTextBox.Text, dienGiaiRTextCtrl.Text, modelGiaInOffset.Id, modelGiaInOffset.TenGia,
                            int.Parse(soMatInRTextBox.Text), int.Parse(soKemRTextBox.Text), int.Parse(soToChayBuHaoThucCanRTextBox.Text), kieuInOffsetDropDown.Text,
                            tenGiayRTextBox.Text, khoGiayRTextBox.Text, int.Parse(donGiaGiayRTextBox.Text),
                            int.Parse(soToGiayRTextBox.Text), giayDaGomLoiNhuanRCheck.Checked);
                            
                        
                        break;
                    case TinhTrangForm.Sua:
                        this.BaiInInOffsetGiaCong.TenBaiIn = tenBaiInOffsetRTextBox.Text;
                        this.BaiInInOffsetGiaCong.IdGiaInOffsetGiaCong = modelGiaInOffset.Id;
                        this.BaiInInOffsetGiaCong.TenGiaInOffsetGiaCong = modelGiaInOffset.TenGia;
                        this.BaiInInOffsetGiaCong.SoMatCanIn = int.Parse(soMatInRTextBox.Text);
                        this.BaiInInOffsetGiaCong.SoKemIn = int.Parse(soKemRTextBox.Text);
                        this.BaiInInOffsetGiaCong.SoToChayBuHaoThucCan = int.Parse(soToChayBuHaoThucCanRTextBox.Text);
                        this.BaiInInOffsetGiaCong.KieuInOffset = kieuInOffsetDropDown.Text;
                        this.BaiInInOffsetGiaCong.TenGiay = tenGiayRTextBox.Text;
                        this.BaiInInOffsetGiaCong.KhoGiayChay = khoGiayRTextBox.Text;
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
                    ResetFormData();
                    break;
                case TinhTrangForm.Sua:
                    tenBaiInOffsetRTextBox.Text = this.BaiInInOffsetGiaCong.TenBaiIn;
                    dienGiaiRTextCtrl.Text = this.BaiInInOffsetGiaCong.DienGiai;
                    soMatInRTextBox.Text = this.BaiInInOffsetGiaCong.SoMatCanIn.ToString();
                    soKemRTextBox.Text = this.BaiInInOffsetGiaCong.SoKemIn.ToString();
                    soToChayBuHaoThucCanRTextBox.Text = this.BaiInInOffsetGiaCong.SoToChayBuHaoThucCan.ToString();
                    tenGiayRTextBox.Text = this.BaiInInOffsetGiaCong.TenGiay;
                    khoGiayRTextBox.Text = this.BaiInInOffsetGiaCong.KhoGiayChay;
                    donGiaGiayRTextBox.Text = this.BaiInInOffsetGiaCong.DonGiayTheoTo.ToString();
                    soToGiayRTextBox.Text = this.BaiInInOffsetGiaCong.SoLuongToGiay.ToString();
                    giayDaGomLoiNhuanRCheck.Checked = this.BaiInInOffsetGiaCong.GiayDaCoLoiNhuan;
                    
                    //Định  vị bảng giá
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
                    //định vị kiểu in
                    kieuInOffsetDropDown.Text = this.BaiInInOffsetGiaCong.KieuInOffset;
                    break;
            }
        }

        private void kieuInOffsetDropDown_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            KieuInOffset kieuIn;
            Enum.TryParse<KieuInOffset>(kieuInOffsetDropDown.SelectedValue.ToString(), out kieuIn);
           // MessageBox.Show(kieuIn.ToString());//OK
           switch (kieuIn)
            {
                                   
                case KieuInOffset.InAB:
                    soKemRTextBox.Text = 2.ToString();
                    break;
                case KieuInOffset.InMotMat:
                case KieuInOffset.InTuTroNhip:
                case KieuInOffset.InTuTroTayKe:
                    soKemRTextBox.Text = 1.ToString();
                    break;
            }
        }
    }
}
