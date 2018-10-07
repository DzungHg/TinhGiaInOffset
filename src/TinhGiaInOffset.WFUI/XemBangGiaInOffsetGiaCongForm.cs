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
        }
        #region implement Iview....
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

        private void giaInOffsetGiaCongListCtrl_SelectedValueChanged(object sender, EventArgs e)
        {

           

        }

        private void dongFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void XemBangGiaInOffsetGiaCongForm_Load(object sender, EventArgs e)
        {
            tieuDeFormLabel.Left = (ClientSize.Width - tieuDeFormLabel.Width) / 2;
        }
    }
}
