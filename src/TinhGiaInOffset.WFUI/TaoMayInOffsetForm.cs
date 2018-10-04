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
    public partial class TaoMayInOffsetForm : Telerik.WinControls.UI.RadForm, IViewTaoMayInOffset
    {
        public TinhTrangForm TinhTrangForm { get; set; }
        TaoMayInOffsetPresenter taoMayInPres;
        public MayInOffsetModel MayInOffsetModel = null;
        public TaoMayInOffsetForm()
        {
            InitializeComponent();
            taoMayInPres = new TaoMayInOffsetPresenter(this);
        }
        #region implement IView
        public string DonViDemClick
        {
            get
            {
                return donViTinhClickRTextBox.Text;
            }

            set
            {
                donViTinhClickRTextBox.Text = value;
            }
        }

        public string GiayCoTheIn
        {
            get
            {
                return giayCoTheInRTextBox.Text;
            }

            set
            {
                giayCoTheInRTextBox.Text = value;
            }
        }

        public string HangSanXuat
        {
            get
            {
                return hangSanXuanRTextBox.Text;
            }

            set
            {
                hangSanXuanRTextBox.Text = value;
            }
        }

        public double KhoGiayToiDaDai
        {
            get
            {
                return double.Parse(khoGiayToiDaDaiRTextBox.Text);
            }

            set
            {
                khoGiayToiDaDaiRTextBox.Text = value.ToString();
            }
        }

        public double KhoGiayToiDaRong
        {
            get
            {
                return double.Parse(khoGiayToiDaRongRTextBox.Text);
            }

            set
            {
                khoGiayToiDaRongRTextBox.Text = value.ToString();
            }
        }

        public double KhoGiayToiThieuDai
        {
            get
            {
                return double.Parse(khoGiayToiThieuDaiRTextBox.Text);
            }

            set
            {
                khoGiayToiThieuDaiRTextBox.Text = value.ToString();
            }
        }

        public double KhoGiayToiThieuRong
        {
            get
            {
                return double.Parse(khoGiayToiThieuRongRTextBox.Text);
            }

            set
            {
                khoGiayToiThieuRongRTextBox.Text = value.ToString();
            }
        }

        public double KhoInToiDaDai
        {
            get
            {
                return double.Parse(khoInToiDaDaiRTextBox.Text);
            }

            set
            {
                khoInToiDaDaiRTextBox.Text = value.ToString();
            }
        }

        public double KhoInToiDaRong
        {
            get
            {
                return double.Parse(khoInToiDaRongRTextBox.Text);
            }

            set
            {
                khoInToiDaRongRTextBox.Text = value.ToString();
            }
        }

        public double KhoInToiThieuDai
        {
            get
            {
                return double.Parse(khoInToiThieuDaiRTextBox.Text);
            }

            set
            {
                khoInToiThieuDaiRTextBox.Text = value.ToString();
            }
        }

        public double KhoInToiThieuRong
        {
            get
            {
                return double.Parse(khoInToiThieuRongRTextBox.Text);
            }

            set
            {
                khoInToiThieuRongRTextBox.Text = value.ToString();
            }
        }

        public int LeBatNhip
        {
            get
            {
                return int.Parse(leBatNhipRTextBox.Text);
            }

            set
            {
                leBatNhipRTextBox.Text = value.ToString();
            }
        }

        public int LeTuTro
        {
            get
            {
                return int.Parse(leTuTroRTextBox.Text);
            }

            set
            {
                leTuTroRTextBox.Text = value.ToString();
            }
        }

        public string MoTa
        {
            get
            {
                return moTaRTextCtrl.Text;
            }

            set
            {
                moTaRTextCtrl.Text = value.ToString();
            }
        }

        public int SoMauIn
        {
            get
            {
                return int.Parse(soMauInRTextBox.Text);
            }

            set
            {
                soMauInRTextBox.Text = value.ToString();
            }
        }

        public string TenMayIn
        {
            get
            {
                return tenMayInRTextBox.Text;
            }

            set
            {
                tenMayInRTextBox.Text = value;
            }
        }

        public string ThongTinTocDo
        {
            get
            {
                return thongTinTocDoRTextBox.Text;
            }

            set
            {
                thongTinTocDoRTextBox.Text = value;
            }
        }

        public int TocDoToGio
        {
            get
            {
                return int.Parse(tocDoToGioRTextBox.Text);
            }

            set
            {
                tocDoToGioRTextBox.Text = value.ToString();
            }
        }
        #endregion
        private bool FormValidation()
        {
            bool output = true;
            if (donViTinhClickRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (moTaRTextCtrl.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (tenMayInRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (thongTinTocDoRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }


            if (giayCoTheInRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }


            if (hangSanXuanRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            double khoGiayToiDaRong = 0;
            double khoGiayToiDaDai = 0;
            double khoGiayToiThieuRong = 0;
            double khoGiayToiThieuDai = 0;
            double khoInToiDaRong = 0;
            double khoInToiDaDai = 0;
            double khoInToiThieuRong = 0;
            double khoInToiThieuDai = 0;

            bool khoGiayToiDaRongValid = double.TryParse(khoGiayToiDaRongRTextBox.Text, out khoGiayToiDaRong);
            if (!khoGiayToiDaRongValid)
            {
                output = false;
            }
            else
            {
                if (khoGiayToiDaRong <= 0)
                    output = false;
            };
            bool khoGiayToiDaDaiValid = double.TryParse(khoGiayToiDaDaiRTextBox.Text, out khoGiayToiDaDai);
            if (!khoGiayToiDaDaiValid)
            {
                output = false;
            }
            else
            {
                if (khoGiayToiDaDai <= 0)
                    output = false;
            }

            bool khoGiayToThieuRongValid = double.TryParse(khoGiayToiThieuRongRTextBox.Text, out khoGiayToiThieuRong);
            if (!khoGiayToThieuRongValid)
            {
                output = false;
            }
            else
            {
                if (khoGiayToiThieuRong <= 0)
                    output = false;
            }

            bool khoGiayToThieuDaiValid = double.TryParse(khoGiayToiThieuDaiRTextBox.Text, out khoGiayToiThieuDai);
            if (!khoGiayToThieuDaiValid)
            {
                output = false;
            }
            else
            {
                if (khoGiayToiThieuDai <= 0)
                    output = false;
            }

            bool khoInToiDaRongValid = double.TryParse(khoInToiDaRongRTextBox.Text, out khoInToiDaRong);
            if (!khoInToiDaRongValid)
            {
                output = false;
            }
            else
            {
                if (khoInToiDaRong <= 0)
                    output = false;
            }

            bool khoInToiDaDaiValid = double.TryParse(khoInToiDaDaiRTextBox.Text, out khoInToiDaDai);
            if (!khoInToiDaDaiValid)
            {
                output = false;
            }
            else
            {
                if (khoInToiDaDai <= 0)
                    output = false;
            }

            bool khoInToiThieuRongValid = double.TryParse(khoInToiThieuRongRTextBox.Text, out khoInToiThieuRong);
            if (!khoInToiThieuRongValid)
            {
                output = false;
            }
            else
            {
                if (khoInToiDaRong <= 0)
                    output = false;
            }

            bool khoInToiThieuDaiValid = double.TryParse(khoInToiThieuDaiRTextBox.Text, out khoInToiThieuDai);
            if (!khoInToiThieuDaiValid)
            {
                output = false;
            }
            else
            {
                if (khoInToiThieuDai <= 0)
                    output = false;
            }

            int leBatNhip = 0;
            int leTuTro = 0;
            int soMauIn = 0;
            int tocDoGio = 0;

            bool leTuTroValid = int.TryParse(leTuTroRTextBox.Text, out leTuTro);
            if (!leTuTroValid)
            {
                output = false;
            }
            else
            {
                if (leTuTro <= 0)
                    output = false;
            }

            bool leBatNhipValid = int.TryParse(leBatNhipRTextBox.Text, out leBatNhip);
            if (!leBatNhipValid)
            {
                output = false;
            }
            else
            {
                if (leBatNhip <= 0)
                    output = false;
            }

            bool soMauInValid = int.TryParse(soMauInRTextBox.Text, out soMauIn);
            if (!soMauInValid)
            {
                output = false;
            }
            else
            {
                if (soMauIn <= 0)
                    output = false;
            }

            bool tocDoGioValid = int.TryParse(tocDoToGioRTextBox.Text, out tocDoGio);
            if (!tocDoGioValid)
            {
                output = false;
            }
            else
            {
                if (tocDoGio <= 0)
                    output = false;
            }


            return output;

        }

        private void TaoMayInOffsetForm_Load(object sender, EventArgs e)
        {
            if (this.TinhTrangForm == TinhTrangForm.Sua)
            {
                tieuDeFormLabel.Text = this.Text;
                taoGiaButton.Text = "Lưu";
                //DDiefu dữ liệu
                this.TenMayIn = this.MayInOffsetModel.TenMayIn ;
                this.MoTa = this.MayInOffsetModel.MoTa ;
                this.KhoGiayToiDaRong = this.MayInOffsetModel.KhoGiayToiDaRong ;
                this.KhoGiayToiDaDai = this.MayInOffsetModel.KhoGiayToiDaDai ;
                this.KhoGiayToiThieuRong = this.MayInOffsetModel.KhoGiayToiThieuRong ;
                this.KhoGiayToiThieuDai = this.MayInOffsetModel.KhoGiayToiThieuDai ;
                this.KhoInToiDaRong = this.MayInOffsetModel.KhoInToiDaRong ;
                this.KhoInToiDaDai = this.MayInOffsetModel.KhoInToiDaDai ;
                this.KhoInToiThieuRong = this.MayInOffsetModel.KhoInToiThieuRong ;
                this.KhoInToiThieuDai = this.MayInOffsetModel.KhoInToiThieuDai  ;
                this.ThongTinTocDo = this.MayInOffsetModel.ThongTinTocDo ;
                this.TocDoToGio = this.MayInOffsetModel.TocDoToGio ;
                this.GiayCoTheIn = this.MayInOffsetModel.GiayCoTheIn  ;
                this.SoMauIn = this.MayInOffsetModel.SoMauIn ;
                this.DonViDemClick = this.MayInOffsetModel.DonViDemClick  ;
                this.HangSanXuat = this.MayInOffsetModel.HangSanXuat;
                this.LeBatNhip = this.MayInOffsetModel.LeBatNhip ;
                this.LeTuTro = this.MayInOffsetModel.LeTuTro ;
            }
            if (this.TinhTrangForm == TinhTrangForm.Moi)
            {
                tieuDeFormLabel.Text = this.Text;
                taoGiaButton.Text = "Tạo";
               
            }
            tieuDeFormLabel.Left = (ClientSize.Width - tieuDeFormLabel.Width) / 2;
        }

        private void taoGiaButton_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                switch (this.TinhTrangForm)
                {
                    case TinhTrangForm.Sua:
                        //Cập nhật lại nội dung
                        this.MayInOffsetModel.TenMayIn = this.TenMayIn;
                        this.MayInOffsetModel.MoTa = this.MoTa;
                        this.MayInOffsetModel.KhoGiayToiDaRong = this.KhoGiayToiDaRong;
                        this.MayInOffsetModel.KhoGiayToiDaDai = this.KhoGiayToiDaDai;
                        this.MayInOffsetModel.KhoGiayToiThieuRong = this.KhoGiayToiThieuRong;
                        this.MayInOffsetModel.KhoGiayToiThieuDai = this.KhoGiayToiThieuDai;
                        this.MayInOffsetModel.KhoInToiDaRong = this.KhoInToiDaRong;
                        this.MayInOffsetModel.KhoInToiDaDai = this.KhoInToiDaDai;
                        this.MayInOffsetModel.KhoInToiThieuRong = this.KhoInToiThieuRong;
                        this.MayInOffsetModel.KhoInToiThieuDai = this.KhoInToiThieuDai;
                        this.MayInOffsetModel.ThongTinTocDo = this.ThongTinTocDo;
                        this.MayInOffsetModel.TocDoToGio = this.TocDoToGio;
                        this.MayInOffsetModel.GiayCoTheIn = this.GiayCoTheIn;
                        this.MayInOffsetModel.SoMauIn = this.SoMauIn;
                        this.MayInOffsetModel.DonViDemClick = this.DonViDemClick;
                        this.MayInOffsetModel.HangSanXuat = this.HangSanXuat;
                        this.MayInOffsetModel.LeBatNhip = this.LeBatNhip;
                        this.MayInOffsetModel.LeTuTro = this.LeTuTro;
                        //Cập nhật vô
                        taoMayInPres.Sua(this.MayInOffsetModel);
                        break;
                    case TinhTrangForm.Moi:
                        this.MayInOffsetModel = new MayInOffsetModel(this.TenMayIn, this.MoTa, this.KhoGiayToiDaRong,
                            this.KhoGiayToiDaDai, this.KhoGiayToiThieuRong, this.KhoGiayToiThieuDai, this.KhoInToiDaRong,
                            this.KhoInToiDaDai, this.KhoInToiThieuRong, this.KhoInToiThieuDai, this.ThongTinTocDo,
                            this.TocDoToGio, this.GiayCoTheIn, this.SoMauIn, this.DonViDemClick, this.HangSanXuat,
                            this.LeBatNhip, this.LeTuTro);
                        taoMayInPres.Them(this.MayInOffsetModel);
                            
                        break;


                }
                this.DialogResult = DialogResult.OK;
            } else
            {
                MessageBox.Show("Bạn phải điền đủ và đúng loại nội dung");
            }

        }
    }
}
