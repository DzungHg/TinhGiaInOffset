using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.WFUI.Presentation;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.Common.Enum;


namespace TinhGiaInOffset.WFUI
{
    public partial class XemBangGiaInOffsetGiaCongForm : Telerik.WinControls.UI.RadForm, IViewXemGiaInOffsetGiaCong
    {
        XemGiaInOffsetGiaCongPresenter xemGiaInPres;
        public XemBangGiaInOffsetGiaCongForm()
        {
            InitializeComponent();
            xemGiaInPres = new XemGiaInOffsetGiaCongPresenter(this);
            DauNoiDuLieu();
            DuLieuKieuInOffset();
        }
        #region implement Iview....
        public int IdGiaInOffsetChon
        {
            get
            {
                int idGiaIn = 0;

                int.TryParse(giaInOffsetGiaCongListCtrl.SelectedValue.ToString(), out idGiaIn);
                return idGiaIn;
            }

            set
            {
                
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
        public string ChiTietMayIn
        {
           
            set { chiTietMayInTextCtrl.Text = value; }
        }
        public string DoiMayIn
        {
           

            set
            {
                doiMayInRTextBox.Text = value;
            }
        }

        public int DonGiaBai
        {
           
            set
            {
                donGiaBaiRTextBox.Text = value.ToString();
            }
        }

       

        public int DonGiaVuot
        {
            get
            {
                return int.Parse(donGiaBaiRTextBox.Text);

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

        public int SoNhanBan
        {
            get
            {
                return int.Parse(soNhanBanTinhRTextBox.Text);
            }

            set
            {
                soNhanBanTinhRTextBox.Text = value.ToString();
            }
        }

        public string KetQuaTinh
        {
            get
            {
                return ketQuaTinhRTextBox.Text;
            }

            set
            {
                ketQuaTinhRTextBox.Text = value;
            }
        }

        public int SoToChay
        {
            get
            {
                return int.Parse(soToChayTinhRTextBox.Text);
            }

            set
            {
                soToChayTinhRTextBox.Text = value.ToString();
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

        public string KhoChayTheoGia
        {
            set
            {
                khoChayTheoGiaRTextBox.Text = value;               
            }
        }






        #endregion
        private void DauNoiDuLieu()
        {
            giaInOffsetGiaCongListCtrl.DataSource = null;
            giaInOffsetGiaCongListCtrl.DataSource = xemGiaInPres.GiaInOffsetGiaCongConDung();
            giaInOffsetGiaCongListCtrl.ValueMember = "Id";
            giaInOffsetGiaCongListCtrl.DisplayMember = "TenGia";
            //Chọn để bẩy hiện chi tiết
            if (giaInOffsetGiaCongListCtrl.DataSource != null)
            {
                giaInOffsetGiaCongListCtrl.SelectedIndex = -1;
                giaInOffsetGiaCongListCtrl.SelectedIndex = 0;
            }
        }
        private void DuLieuKieuInOffset()
        {

            kieuInOffsetDropDown.DataSource = Enum.GetValues(typeof(KieuInOffset));
            kieuInOffsetDropDown.SelectedIndex = 0;
        }
        private void giaInOffsetGiaCongListCtrl_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            //Đúng là vô đây
            try
            {
                int idGiaIn = 0;

                int.TryParse(giaInOffsetGiaCongListCtrl.SelectedValue.ToString(), out idGiaIn);
                //MessageBox.Show(idGiaIn.ToString());
                               
                xemGiaInPres.TrinhBayChiTietGia(idGiaIn);
            } catch { }
        }
        private bool FormTinhValidation()
        {
            bool output = true;
            int soKem = 0;
            int soMatIn = 0;
            bool soKemValid = int.TryParse(soNhanBanTinhRTextBox.Text, out soKem);
            if (soKemValid != true)
            {
                output = false;
            }
            else
            {
                if (soKem <= 0)
                    output = false;
            }
            bool soMatInValid = int.TryParse(soToChayTinhRTextBox.Text, out soMatIn);
            if (soMatInValid != true)
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
       
        private void giaInOffsetGiaCongListCtrl_SelectedValueChanged(object sender, EventArgs e)
        {

           

        }

        private void dongFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemBangGiaInOffsetGiaCongForm_Load(object sender, EventArgs e)
        {
            tieuDeFormLabel.Text = this.Text;
            tieuDeFormLabel.Left = (ClientSize.Width - tieuDeFormLabel.Width) / 2;
        }

        private void tinhPhiRButton_Click(object sender, EventArgs e)
        {
            if (FormTinhValidation())
            {
                this.KetQuaTinh = string.Format("{0:0,0.00}", xemGiaInPres.KetQuaTinh());
            }
            else
            {
                MessageBox.Show("Bạn cần điền đúng và đủ nội dung form tính");
            }
        }

        private void resetTinhRButton_Click(object sender, EventArgs e)
        {
            xemGiaInPres.ResetFormTinh();
        }
    }
}
