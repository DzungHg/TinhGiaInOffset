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

using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.WFUI.Presentation;


namespace TinhGiaInOffset.WFUI
{
    public partial class TaoBaiInOffsetGiaCongForm : Telerik.WinControls.UI.RadForm, IViewBaiInOffsetGiaCong
    {
        public TinhTrangForm TinhTrangForm { get; set; }
        private BaiInOffsetGiaCongPresenter baiInOffsetGiaCongPres;
        
        public BaiInOffsetGiaCongModel BaiInInOffsetGiaCong { get; set; }

        #region implement Iview
        public string TenBaiIn
        {
            get
            {
                return tenBaiInOffsetRTextBox.Text;
            }

            set
            {
                tenBaiInOffsetRTextBox.Text = value;
            }
        }

        public string DienGiai
        {
            get
            {
                return dienGiaiRTextCtrl.Text;
            }

            set
            {
                dienGiaiRTextCtrl.Text = value;
            }
        }

        public int IdGiaInOffsetGiaCong
        {
            get
            {
                var model = (GiaInOffsetGiaCongModel)(giaOffsetGiaCongDropDown.SelectedValue);
                return model.Id;
            }

            set
            {
                //Định  vị bảng giá
                int index = 0;
                int valueCheck = value;
                foreach (var item in giaOffsetGiaCongDropDown.Items)
                {
                    if (((GiaInOffsetGiaCongModel)item.DataBoundItem).Id == valueCheck)
                    {
                        index = item.RowIndex;
                        break;
                    }
                }
                giaOffsetGiaCongDropDown.SelectedIndex = index;
            }
        }
        public string TenGiaInOffsetGiaCong
        {
            get { return giaOffsetGiaCongDropDown.Text; }
            set { TenGiaInOffsetGiaCong = value; }
        }

        public int SoMatCanIn
        {
            get
            {
                int soMat = 0;
                int.TryParse(soMatInRTextBox.Text, out soMat);
                return soMat;
            }

            set
            {
                soMatInRTextBox.Text = value.ToString();
            }
        }

        public int SoKemIn
        {
            get
            {
                int soKem = 0;
                int.TryParse(soKemRTextBox.Text, out soKem);
                return soKem;
            }

            set
            {
                soKemRTextBox.Text = value.ToString();
            }
        }

        public int SoToChayBuHaoThucCan
        {
            get
            {
                int soToBu = 0;
                int.TryParse(soToChayBuHaoThucCanRTextBox.Text, out soToBu);
                return soToBu;
            }

            set
            {
                soToChayBuHaoThucCanRTextBox.Text = value.ToString();
            }
        }

        public string KieuInOffset
        {
            get
            {
                return kieuInOffsetDropDown.Text;
            }

            set
            {
                kieuInOffsetDropDown.Text = value;
            }
        }

        public string TenGiay
        {
            get
            {
                return tenGiayRTextBox.Text;
            }

            set
            {
                tenGiayRTextBox.Text = value;
            }
        }

        public string KhoGiayChay
        {
            get
            {
                return khoGiayRTextBox.Text;
            }

            set
            {
                khoGiayRTextBox.Text = value;
            }
        }

        public int DonGiaGiayTheoTo
        {
            get
            {
                int donGia = 0;
                int.TryParse(donGiaGiayRTextBox.Text, out donGia);
                return donGia;
            }

            set
            {
                donGiaGiayRTextBox.Text = value.ToString();
            }
        }

        public int SoLuongToGiay
        {
            get
            {
                int soLuong = 0;
                int.TryParse(soToGiayRTextBox.Text, out soLuong);
                return soLuong;
            }

            set
            {
                soToGiayRTextBox.Text = value.ToString();
            }
        }

        public bool GiayDaCoLoiNhuan
        {
            get
            {
                return giayDaGomLoiNhuanRCheck.Checked;
            }

            set
            {
                giayDaGomLoiNhuanRCheck.Checked = value;
            }
        }
#endregion
        public TaoBaiInOffsetGiaCongForm()
        {
            InitializeComponent();
            baiInOffsetGiaCongPres = new BaiInOffsetGiaCongPresenter(this);
            //Dau noi du lieu vo combo
            DauNoiDuLieu();
            DuLieuKieuInOffset();
        }

        private void DauNoiDuLieu()
        {
            giaOffsetGiaCongDropDown.DataSource = null;
            giaOffsetGiaCongDropDown.DataSource = baiInOffsetGiaCongPres.GiaInOffsetS();
            giaOffsetGiaCongDropDown.DataMember = "Id";
            giaOffsetGiaCongDropDown.DisplayMember = "TenGia";
        }
        private void DuLieuKieuInOffset()
        {
           
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
                var idGiaIn = ((GiaInOffsetGiaCongModel)giaOffsetGiaCongDropDown.SelectedValue).Id;

                chiTietBangGiaTextCtrl.Text = baiInOffsetGiaCongPres.ChiTietGiaInGiaCong(idGiaIn);
            } catch { }

                   
        }
        private void ResetFormData()
        {
            baiInOffsetGiaCongPres.ResetViewData();

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
                var modelGiaInOffset = (GiaInOffsetGiaCongModel)giaOffsetGiaCongDropDown.SelectedValue;
                switch (this.TinhTrangForm)
                {
                    case TinhTrangForm.Moi:
                       
                          /*this.BaiInInOffsetGiaCong = new BaiInOffsetGiaCongModel(tenBaiInOffsetRTextBox.Text, dienGiaiRTextCtrl.Text, modelGiaInOffset.Id, modelGiaInOffset.TenGia,
                            int.Parse(soMatInRTextBox.Text), int.Parse(soKemRTextBox.Text), int.Parse(soToChayBuHaoThucCanRTextBox.Text), kieuInOffsetDropDown.Text,
                            tenGiayRTextBox.Text, khoGiayRTextBox.Text, int.Parse(donGiaGiayRTextBox.Text),
                            int.Parse(soToGiayRTextBox.Text), giayDaGomLoiNhuanRCheck.Checked);*/

                        this.BaiInInOffsetGiaCong = baiInOffsetGiaCongPres.ThemBaiIn(this.TenBaiIn, this.DienGiai, this.IdGiaInOffsetGiaCong,
                            this.TenGiaInOffsetGiaCong, this.SoMatCanIn, this.SoKemIn, this.SoToChayBuHaoThucCan, this.KieuInOffset,
                            this.TenGiay, this.KhoGiayChay, this.DonGiaGiayTheoTo, this.SoLuongToGiay, this.GiayDaCoLoiNhuan);    
                        
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
                        this.BaiInInOffsetGiaCong.DonGiaGiayTheoTo = int.Parse(donGiaGiayRTextBox.Text);
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
                   
                    this.TenBaiIn = this.BaiInInOffsetGiaCong.TenBaiIn;
                    this.DienGiai = this.BaiInInOffsetGiaCong.DienGiai;
                    this.IdGiaInOffsetGiaCong = this.BaiInInOffsetGiaCong.IdGiaInOffsetGiaCong;
                    this.SoMatCanIn = this.BaiInInOffsetGiaCong.SoMatCanIn;
                    this.SoKemIn = this.BaiInInOffsetGiaCong.SoKemIn;
                    this.SoToChayBuHaoThucCan = this.BaiInInOffsetGiaCong.SoToChayBuHaoThucCan;
                    this.TenGiay = this.BaiInInOffsetGiaCong.TenGiay;
                    this.KhoGiayChay = this.BaiInInOffsetGiaCong.KhoGiayChay;
                    this.DonGiaGiayTheoTo = this.BaiInInOffsetGiaCong.DonGiaGiayTheoTo;
                    this.SoLuongToGiay = this.BaiInInOffsetGiaCong.SoLuongToGiay;
                    this.GiayDaCoLoiNhuan = this.BaiInInOffsetGiaCong.GiayDaCoLoiNhuan;
                    this.KieuInOffset = this.BaiInInOffsetGiaCong.KieuInOffset;
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
                                   
                case Common.Enum.KieuInOffset.InAB:
                    soKemRTextBox.Text = 2.ToString();
                    break;
                case Common.Enum.KieuInOffset.InMotMat:
                case Common.Enum.KieuInOffset.InTuTroNhip:
                case Common.Enum.KieuInOffset.InTuTroTayKe:
                    soKemRTextBox.Text = 1.ToString();
                    break;
            }
        }
    }
}
