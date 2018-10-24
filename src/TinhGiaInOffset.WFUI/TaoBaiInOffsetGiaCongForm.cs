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
        public int IdBaiIn { get; set; }
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

        public int SoMatIn
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

        public int SoToChayBuHao
        {
            get
            {
                int soToBu = 0;
                int.TryParse(soToChayBuHaoRTextBox.Text, out soToBu);
                return soToBu;
            }

            set
            {
                soToChayBuHaoRTextBox.Text = value.ToString();
            }
        }

        public KieuInOffset KieuIn
        {
            get
            {
                KieuInOffset kieuIn;
                Enum.TryParse<KieuInOffset>(kieuInOffsetDropDown.SelectedValue.ToString(), out kieuIn);
                return kieuIn;
            }

            set
            {
                int index = 0;
                foreach (var item in kieuInOffsetDropDown.Items)
                {
                    if ((KieuInOffset)item.DataBoundItem == value)
                    {
                        index = item.RowIndex;
                        break;
                    }
                }
                kieuInOffsetDropDown.SelectedIndex = index;
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
                return khoToChayGiayRTextBox.Text;
            }

            set
            {
                khoToChayGiayRTextBox.Text = value;
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

        public int SoToChayLyThuyet
        {
            get
            {
                int soLuong = 0;
                int.TryParse(soToChayLyThuyetRTextBox.Text, out soLuong);
                return soLuong;
            }

            set
            {
                soToChayLyThuyetRTextBox.Text = value.ToString();
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
        public bool BaiNhanBan
        {
            get
            {
                return baiInNhanBanCheck.Checked;
            }

            set
            {
                baiInNhanBanCheck.Checked = value;
            }
        }

        public int SoLuotIn
        {
            get;set;
        }

        public int SoBaiNhanBan
        {
            get
            {
                return int.Parse(soBaiInNhanBanRTextBox.Text);
            }

            set
            {
                soBaiInNhanBanRTextBox.Text = value.ToString();
            }
        }

        public string KhoToChayIn
        {
            get
            {
                return khoToChayInRTextBox.Text;
            }

            set
            {
                khoToChayInRTextBox.Text = value;
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
                //MessageBox.Show(idGiaIn.ToString()); đúng
                chiTietBangGiaTextCtrl.Text = baiInOffsetGiaCongPres.ChiTietGiaInGiaCong(idGiaIn);
                tenNhaInOffsetRLabel.Text = baiInOffsetGiaCongPres.LayTenNhaInOffset(idGiaIn);
                //
                baiInOffsetGiaCongPres.DisplayWhenSelectGiaInOffset();
            } catch { }

                   
        }
        private void ResetFormData()
        {
            baiInOffsetGiaCongPres.ResetViewData();

        }
        private void RangBuocDuLieuInTheoKieuIn()
        {
            switch (this.KieuIn)
            {
                case KieuInOffset.InAB:
                    this.SoKemIn = 2;
                    this.SoMatIn = 2;
                    this.SoLuotIn = 2;
                    break;
                case KieuInOffset.InMotMat:
                    this.SoKemIn = 1;
                    this.SoMatIn = 1;
                    this.SoLuotIn = 1;
                    break;
                case KieuInOffset.InTuTroNhip:
                case KieuInOffset.InTuTroTayKe:                
                    this.SoKemIn = 1;
                    this.SoMatIn = 2;
                    this.SoLuotIn = 2;
                    break;                                    
            }

        }
        private bool FormValidation(out string loi)
        {
            List<string> lois = new List<string>();
            bool output = true;

            if (tenBaiInOffsetRTextBox.Text.Trim().Length == 0)
            {
                
                lois.Add("Tên bài in?");
            }

            if (tenGiayRTextBox.Text.Trim().Length == 0)
            {
                
                lois.Add("Tên giấy?");
            }
            if (khoToChayGiayRTextBox.Text.Trim().Length == 0)
            {
                lois.Add("Khổ giấy?");
            }
            if (dienGiaiRTextCtrl.Text.Trim().Length == 0)
            {
                lois.Add("Diễn giải?"); ;
            }
           

            int donGiaGiay = 0;
            int soTo = 0;
            int soMatIn = 0;
            int soKemIn = 0;
            int soToChayBuHaoThucCan;
            int soBaiInNhanBan;

            bool donGiaGiayValid = int.TryParse(donGiaGiayRTextBox.Text, out donGiaGiay);
            if (!donGiaGiayValid)
            {
                lois.Add("Đơn giá dạng số");
            }
            else
            {
                if (donGiaGiay <= 0)
                    lois.Add("Trị giá đơn giá");
            }

            bool soToValid = int.TryParse(soToChayLyThuyetRTextBox.Text, out soTo);
            if (!soToValid)
            {
                lois.Add("Số tờ giấy");
            }
            else
            {
                if (soTo <= 0)
                    lois.Add("Số lượng tờ giấy"); ;
            }


            bool soMatInValid = int.TryParse(soMatInRTextBox.Text, out soMatIn);
            if (!soMatInValid)
            {
                lois.Add("Số mặt in");
            }
            else
            {
                if (soMatIn <= 0)
                    lois.Add("Số lượng mặt in"); ;
            }

            bool soKemInValid = int.TryParse(soKemRTextBox.Text, out soKemIn);
            if (!soKemInValid)
            {
                lois.Add("Số kẽm"); ;
            }
            else
            {
                if (soKemIn < 1)
                    lois.Add("Số lượng kẽm"); ;
            }
            bool soToChayBuHaoThucCanValid = int.TryParse(soToChayBuHaoRTextBox.Text, out soToChayBuHaoThucCan);
            if (!soToChayBuHaoThucCanValid)
            {
               lois.Add("Số tờ chạy bù hao"); ;
            }
            else
            {
                if (soToChayBuHaoThucCan < 50)
                    lois.Add("Số lượng tờ chạy bù hao"); ;
            }

            bool soBaiInNhanBanValid = int.TryParse(soBaiInNhanBanRTextBox.Text, out soBaiInNhanBan);
            if (!soBaiInNhanBanValid)
            {
                lois.Add("Số bài in nhân bản?"); ;
            }
            else
            {
                if (this.BaiNhanBan == false)
                {
                    this.SoBaiNhanBan = 1;
                }

                if (soBaiInNhanBan < 1)
                    lois.Add("Số lượng bài in nhân bản");
                

            }



            var msg = "";
            if (lois.Count > 0)
            {
                output = false;
                msg = "Lỗi: ";
                foreach (var str in lois)
                {
                    msg += str + ";";
                }
            }
            loi = msg;
            return output;

        }

        private void taoGiaButton_Click(object sender, EventArgs e)
        {
            var thongBao = "";
            if (FormValidation(out thongBao))
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
                            this.TenGiaInOffsetGiaCong, this.SoMatIn, this.SoKemIn, this.SoToChayBuHao, this.KieuIn,
                            this.TenGiay, this.KhoGiayChay, this.DonGiaGiayTheoTo, this.SoToChayLyThuyet, this.GiayDaCoLoiNhuan,
                            this.BaiNhanBan, this.SoBaiNhanBan);    
                        
                        break;
                    case TinhTrangForm.Sua:
                        this.BaiInInOffsetGiaCong.TenBaiIn = this.TenBaiIn;
                        this.BaiInInOffsetGiaCong.IdGiaInOffsetGiaCong = modelGiaInOffset.Id;
                        this.BaiInInOffsetGiaCong.TenGiaInOffsetGiaCong = modelGiaInOffset.TenGia;
                        this.BaiInInOffsetGiaCong.SoMatIn = this.SoMatIn;
                        this.BaiInInOffsetGiaCong.SoKemIn = this.SoKemIn;
                        this.BaiInInOffsetGiaCong.SoToChayBuHao = this.SoToChayBuHao;
                        this.BaiInInOffsetGiaCong.KieuIn = this.KieuIn;
                        this.BaiInInOffsetGiaCong.TenGiay = this.TenGiay;
                        this.BaiInInOffsetGiaCong.KhoGiayChay = this.KhoGiayChay;
                        this.BaiInInOffsetGiaCong.DonGiaGiayTheoTo = this.DonGiaGiayTheoTo;
                        this.BaiInInOffsetGiaCong.SoToChayLyThuyet = this.SoToChayLyThuyet;
                        this.BaiInInOffsetGiaCong.GiayDaCoLoiNhuan = this.GiayDaCoLoiNhuan;
                        this.BaiInInOffsetGiaCong.BaiNhanBan = this.BaiNhanBan;
                        this.BaiInInOffsetGiaCong.SoBaiNhanBan = this.SoBaiNhanBan;

                        break;
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                //MessageBox.Show("Bạn cần điền đầy đủ chi tiết form");
                thongBaoRLabel.Text = thongBao;
            }
        }

        private void TaoPhiInOffsetGiaCongForm_Load(object sender, EventArgs e)
        {
            switch (this.TinhTrangForm)
            {
                case TinhTrangForm.Moi:
                    ResetFormData();
                    //Bẩy 
                    giaOffsetGiaCongDropDown.SelectedIndex = -1;
                    giaOffsetGiaCongDropDown.SelectedIndex = 0;
                    break;
                case TinhTrangForm.Sua:
                   
                    this.TenBaiIn = this.BaiInInOffsetGiaCong.TenBaiIn;
                    this.DienGiai = this.BaiInInOffsetGiaCong.DienGiai;
                    this.IdGiaInOffsetGiaCong = this.BaiInInOffsetGiaCong.IdGiaInOffsetGiaCong;
                    this.SoMatIn = this.BaiInInOffsetGiaCong.SoMatIn;
                    this.SoKemIn = this.BaiInInOffsetGiaCong.SoKemIn;
                    this.SoToChayBuHao = this.BaiInInOffsetGiaCong.SoToChayBuHao;
                    this.TenGiay = this.BaiInInOffsetGiaCong.TenGiay;
                    this.KhoGiayChay = this.BaiInInOffsetGiaCong.KhoGiayChay;
                    this.DonGiaGiayTheoTo = this.BaiInInOffsetGiaCong.DonGiaGiayTheoTo;
                    this.SoToChayLyThuyet = this.BaiInInOffsetGiaCong.SoToChayLyThuyet;
                    this.GiayDaCoLoiNhuan = this.BaiInInOffsetGiaCong.GiayDaCoLoiNhuan;
                    this.KieuIn = this.BaiInInOffsetGiaCong.KieuIn;
                    this.BaiNhanBan = this.BaiInInOffsetGiaCong.BaiNhanBan;
                    this.SoBaiNhanBan = this.BaiInInOffsetGiaCong.SoBaiNhanBan;
                    break;
            }
            tieuDeFormLabel.Left = (ClientSize.Width - tieuDeFormLabel.Width) / 2;
            TatMoControlsInNhanBan();
        }

        private void kieuInOffsetDropDown_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            RangBuocDuLieuInTheoKieuIn();
            /*KieuInOffset kieuIn;
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
            */
        }

        private void TatMoControlsInNhanBan()
        {
            //TatMoControlsTheoInTheoLo();
            soBaiInNhanBanRTextBox.Enabled = this.BaiNhanBan;

            soToChayLyThuyetRTextBox.ReadOnly = this.BaiNhanBan;
            soToChayBuHaoRTextBox.ReadOnly = soToChayLyThuyetRTextBox.ReadOnly;
            if (this.BaiNhanBan == false)
            {
                this.SoBaiNhanBan = 1;
            }
        }
       
        private void baiInNhanBanCheck_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            TatMoControlsInNhanBan();
        }
    }
}
