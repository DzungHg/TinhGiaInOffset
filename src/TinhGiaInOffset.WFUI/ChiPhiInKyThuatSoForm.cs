using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Telerik.WinControls;
using TinhGiaInOffset.WFUI.View;
using TinhGiaInOffset.WFUI.Model;
using TinhGiaInOffset.WFUI.Presentation;

namespace TinhGiaInOffset.WFUI
{
    public partial class ChiPhiInKyThuatSoForm : Telerik.WinControls.UI.RadForm, IViewChiPhiInKyThuatSo
    {
        ChiPhiInKyThuatSoPresenter chiPhiInKTSPres;
        public ChiPhiInKyThuatSoForm()
        {
            InitializeComponent();
            chiPhiInKTSPres = new ChiPhiInKyThuatSoPresenter(this);
            //
            DauNoiDuLieu();
            chiPhiInKTSPres.ResetFormData();
        }
        #region implement IView...
        public string ChiTietPhiMayIn
        {
            get
            {
                return chiTietPhiMayInKTSRTextCtrl.Text;
            }

            set
            {
                chiTietPhiMayInKTSRTextCtrl.Text = value;
            }
        }

        public int IdPhiMayInKyThuatSo
        {
            get
            {
                int idPhiMay = 0;
                if (phiMayInKTSDropDownList.SelectedValue != null)
                {
                    var model = (PhiMayInKyThuatSoModel)phiMayInKTSDropDownList.SelectedValue;
                    //int.TryParse(model.Id, out idPhiMay);
                    idPhiMay = model.Id;
                }
                return idPhiMay;
            }

            set { }
           
        }

        public bool InMotMau
        {
            get
            {
                return inMotMauCheck.Checked;
            }

            set
            {
                inMotMauCheck.Checked = value;
            }
        }

        public int SoTrangA4Tinh
        {
            get
            {
                return int.Parse(soTrangA4RTextBox.Text);
            }

            set
            {
                soTrangA4RTextBox.Text = value.ToString();
            }
        }

        public double ThoiGianRIPDuLieuBienDoi
        {
            get
            {
                return double.Parse(thoiGianRIPDLBDRTextBox.Text);
            }

            set
            {
                thoiGianRIPDLBDRTextBox.Text = value.ToString();
            }
        }

        public string KetQuaTinhToan
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
        #endregion;
        private void DauNoiDuLieu()
        {
            phiMayInKTSDropDownList.DataSource = null;
           
            phiMayInKTSDropDownList.DataSource = chiPhiInKTSPres.PhiMayInKyThuatSoS();
            phiMayInKTSDropDownList.DataMember = "Id";
            phiMayInKTSDropDownList.DisplayMember = "Ten";
            //Bẫy
            phiMayInKTSDropDownList.SelectedIndex = -1;
            phiMayInKTSDropDownList.SelectedIndex = 0;


        }
        private bool FormValidatiion()
        {
            bool output = true;

            int soTrangTinh = 0;
            double thoiGianDuLieuBienDoi = 0;

            bool soTrangTinhValid = int.TryParse(soTrangA4RTextBox.Text, out soTrangTinh);
            if (soTrangTinhValid == false)
            {
                output = false;
            } else
            {
                if (soTrangTinh <= 0)
                {
                    output = false;
                }
            }

            bool thoiGianDuLieuBienDoiValid = double.TryParse(thoiGianRIPDLBDRTextBox.Text, out thoiGianDuLieuBienDoi);
            if (thoiGianDuLieuBienDoiValid == false)
            {
                output = false;
            }
            else
            {
                if (thoiGianDuLieuBienDoi < 0)
                {
                    output = false;
                }
            }
            return output;
        }

        private void tinhPhiRButton_Click(object sender, EventArgs e)
        {
            if (FormValidatiion())
            {
                  this.KetQuaTinhToan = string.Format("{0:0,0.00}", chiPhiInKTSPres.KetQuaTinh());
                
            }
            else
            {
                MessageBox.Show("Bạn phải điền đúng và đủ dữ liệu form!");
                
            }
        }

        private void phiMayInKTSDropDownList_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            chiTietPhiMayInKTSRTextCtrl.Text = chiPhiInKTSPres.ChiTietPhiMayInKTS(this.IdPhiMayInKyThuatSo);
        }

        private void resetFormRButton_Click(object sender, EventArgs e)
        {
            chiPhiInKTSPres.ResetFormData();
        }
        private void TextBox_ValueChanged()
        {
            this.KetQuaTinhToan = 0.ToString();
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            Telerik.WinControls.UI.RadTextBox tb;
            if (sender is Telerik.WinControls.UI.RadTextBox)
            {
                tb = (Telerik.WinControls.UI.RadTextBox)sender;
                if (tb == thoiGianRIPDLBDRTextBox || tb == soTrangA4RTextBox)
                {
                    TextBox_ValueChanged();
                }
            }

            Telerik.WinControls.UI.RadCheckBox cb;
            if (sender is Telerik.WinControls.UI.RadCheckBox)
            {
                cb = (Telerik.WinControls.UI.RadCheckBox)sender;
                if (cb == inMotMauCheck)
                {
                    TextBox_ValueChanged();
                }
            }
        }
    }
}
