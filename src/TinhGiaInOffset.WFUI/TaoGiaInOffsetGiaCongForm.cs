using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TinhGiaInOffset.Common.Enum;
using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.WFUI.Presentation;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.WFUI.DTOContext;


namespace TinhGiaInOffset.WFUI
{
    public partial class TaoGiaInOffsetGiaCongForm : Telerik.WinControls.UI.RadForm, IViewGiaInOffsetGiaCong
    {
        
        public TinhTrangForm TinhTrangForm;
        private TaoGiaInOffsetGiaCongPresenter taoGiaInPres;
        //Dữ liệu nhà in và máy in

        #region implement IView....
        public int IdGiaIn { get; set; }
        public string TenGia
        {
            get
            {
                return tenGiaInRTextBox.Text;
            }

            set
            {
                tenGiaInRTextBox.Text = value;
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

        public int IdNhaIn
        {
            get
            {
                int idNhaIn = 0;
                if (nhaInOffsetDropDown.SelectedValue != null)
                {
                    //int.TryParse(nhaInOffsetDropDown.SelectedValue.ToString(), out idNhaIn);
                    idNhaIn = ((NhaInOffsetModel)nhaInOffsetDropDown.SelectedValue).Id;
                }
                return idNhaIn;
            }

            set
            {
                int index = 0;
                foreach (var item in nhaInOffsetDropDown.Items)
                {
                    if (((NhaInOffsetModel)item.DataBoundItem).Id == value)
                    {
                        index = item.RowIndex;
                        break;
                    }
                }
                nhaInOffsetDropDown.SelectedIndex = index;
            }
        }

        public int IdMayIn
        {
            get
            {
                int idMayIn = 0;
                if (mayInOffsetDropDown.SelectedValue != null)
                {
                    idMayIn = ((MayInOffsetModel)mayInOffsetDropDown.SelectedValue).Id;
                }
                return idMayIn;
            }

            set
            {
                int index = 0;
                foreach (var item in mayInOffsetDropDown.Items)
                {
                    if (((MayInOffsetModel)item.DataBoundItem).Id == value)
                    {
                        index = item.RowIndex;
                        break;
                    }
                }
                mayInOffsetDropDown.SelectedIndex = index;
            }
        }

        public string DoiMayIn
        {
            get
            {
                return doiMayInRTextBox.Text;
            }

            set
            {
                doiMayInRTextBox.Text = value;
            }
        }

        public int ToChayRong
        {
            get
            {
                return int.Parse(toChayRongRTextBox.Text);
            }

            set
            {
                toChayRongRTextBox.Text = value.ToString();
            }
        }

        public int ToChayDai
        {
            get
            {
                return int.Parse(toChayDaiRTextBox.Text);
            }

            set
            {
                toChayDaiRTextBox.Text = value.ToString();
            }
        }

        public int DonGiaBai
        {
            get
            {
                return int.Parse(donGiaBaiRTextBox.Text);
            }

            set
            {
                donGiaBaiRTextBox.Text = value.ToString();
            }
        }

        public int SoToChayBuHaoCoBan
        {
            get
            {
                return int.Parse(soToChayBuHaoCoBanRTextBox.Text);
            }

            set
            {
                soToChayBuHaoCoBanRTextBox.Text = value.ToString();
            }
        }

        public int SoLuongBaoIn
        {
            get
            {
                return int.Parse(soLuongBaoInRTextBox.Text);
            }

            set
            {
                soLuongBaoInRTextBox.Text = value.ToString();
            }
        }

        public int DonGiaVuot
        {
            get
            {
                return int.Parse(donGiaVuotRTextBox.Text);
            }

            set
            {
                donGiaVuotRTextBox.Text = value.ToString();
            }
        }

        public string DonViTinhSoLuong
        {
            get
            {
                return donViTinhTheoSoLuongRTextBox.Text;
            }

            set
            {
                donViTinhTheoSoLuongRTextBox.Text = value;
            }
        }

        public bool GiaDaBaoKem
        {
            get
            {
                return giaDaBaoGomKemRCheck.Checked;
            }

            set
            {
                giaDaBaoGomKemRCheck.Checked = value;
            }
        }

        public string ThongTinLienHe
        {
            get
            {
                return thongTinLienHeRTextCtrl.Text;
            }

            set
            {
                thongTinLienHeRTextCtrl.Text = value;
            }
        }

        public string GhiChu
        {
            get
            {
                return ghiChuRTextCtrl.Text;
            }

            set
            {
                ghiChuRTextCtrl.Text = value;
            }
        }

        public bool KhongSuDung
        {
            get
            {
                return khongSuDungRCheck.Checked;
            }

            set
            {
                khongSuDungRCheck.Checked = value;
            }
        }

        public int ThuTuSapXep
        {
            get
            {
                return int.Parse(thuTuSapXepRTextBox.Text);
            }

            set
            {
                thuTuSapXepRTextBox.Text = value.ToString();
            }
        }
        #endregion

        public TaoGiaInOffsetGiaCongForm()
        {
            InitializeComponent();
            //Đấu nối dữ liệu vô comboboxes
            taoGiaInPres = new TaoGiaInOffsetGiaCongPresenter(this);
            DauNoiDuLieu();
        }
        private void DauNoiDuLieu()
        {
            nhaInOffsetDropDown.DataSource = null;
            nhaInOffsetDropDown.Items.Clear();
            nhaInOffsetDropDown.DataSource = taoGiaInPres.NhaInOffsetS();
            nhaInOffsetDropDown.DataMember = "Id";            
            nhaInOffsetDropDown.DisplayMember = "TenNhaIn";

            mayInOffsetDropDown.DataSource = null;
            mayInOffsetDropDown.Items.Clear();
            mayInOffsetDropDown.DataSource = taoGiaInPres.MayInOffsetS();
            mayInOffsetDropDown.DataMember = "Id";
            mayInOffsetDropDown.DisplayMember = "TenMayIn";
        }
        private bool FormValidation()
        {
            bool output = true;
            //Xử lý text
            if (tenGiaInRTextBox.Text.Trim().Length ==0)
            {
                output = false;
            }
            if (dienGiaiRTextCtrl.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (doiMayInRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (donViTinhTheoSoLuongRTextBox.Text.Trim().Length == 0)
            {
                output = false;
            }
            if ( thongTinLienHeRTextCtrl.Text.Trim().Length == 0)
            {
                output = false;
            }
            if (ghiChuRTextCtrl.Text.Trim().Length == 0)
            {
                output = false;
            }
            //Dạng số
            int donGiaBai = 0;
            bool donGiaBaiValid = int.TryParse(donGiaBaiRTextBox.Text, out donGiaBai);
            if (donGiaBaiValid == false)
            {
                output = false;
            }
            else
            {
                if (donGiaBai <= 0)
                    output = false;
            }

            int donGiaVuot = 0;
            bool donGiaVuotValid = int.TryParse(donGiaVuotRTextBox.Text, out donGiaVuot);
            if (donGiaVuotValid == false)
            {
                output = false;
            }
            else
            {
                if (donGiaVuot <= 0)
                    output = false;
            }

            int soLuongBaoIn = 0;
            bool soLuongBaoInValid = int.TryParse(soLuongBaoInRTextBox.Text, out soLuongBaoIn);
            if (donGiaBaiValid == false)
            {
                output = false;
            }
            else
            {
                if (soLuongBaoIn <= 0)
                    output = false;
            }

            int soToChayBuHaoCoBan = 0;
            bool soToChayBuHaoCoBanValid = int.TryParse(soToChayBuHaoCoBanRTextBox.Text, out soToChayBuHaoCoBan);
            if (soToChayBuHaoCoBanValid == false)
            {
                output = false;
            }
            else
            {
                if (soToChayBuHaoCoBan <= 0)
                    output = false;
            }

            int toChayRong = 0;
            bool toChayRongValid = int.TryParse(toChayRongRTextBox.Text, out toChayRong);
            if (toChayRongValid == false)
            {
                output = false;
            }
            else
            {
                if (toChayRong <= 0)
                    output = false;
            }
           
            int toChayDai = 0;
            bool toChayDaiValid = int.TryParse(toChayDaiRTextBox.Text, out toChayDai);
            if (toChayDaiValid == false)
            {
                output = false;
            }
            else
            {
                if (toChayDai <= 0)
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
                        taoGiaInPres.TaoMoiGiaInOffsetGiaCong();                       
                        break;
                    case TinhTrangForm.Sua:
                        taoGiaInPres.SuaGiaInOffsetGiaCong();
                        break;
                }//Switch
                this.DialogResult = DialogResult.OK;
            }//if
            else
            {
                MessageBox.Show("Bạn cần điền đúng và đủ dữ liệu trên form");
            }
            
        }

        private void mayInOffsetDropDown_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
          
            try
            {
                var model = (MayInOffsetModel)mayInOffsetDropDown.SelectedItem.DataBoundItem;
                chiTietMayInTextCtrl.Text = taoGiaInPres.ChiTietMayInOffset();
                ///mayInOffsetDropDown.SelectedValue là đối tượng
                
                
            }
            catch { }
        }

        private void TaoGiaInOffsetGiaCongForm_Load(object sender, EventArgs e)
        {
            if (this.TinhTrangForm == TinhTrangForm.Sua)
            {
                taoGiaInPres.DisplayChiTietGiaInOffset();
              
                //Nút
                taoGiaButton.Text = "Lưu";
                tieuDeFormLabel.Text = $"SỬA GIÁ ID [{this.IdGiaIn}]";

            }
            tieuDeFormLabel.Left = (ClientSize.Width - tieuDeFormLabel.Width) / 2;
        }

        private void donViTinhTheoSoLuongRTextBox_TextChanged(object sender, EventArgs e)
        {
            donVi_DonGiaVuotRLabel.Text = $"đ/{this.DonViTinhSoLuong}";
        }
    }
}
