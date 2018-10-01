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
    public partial class TaoGiaInOffsetGiaCongForm : Telerik.WinControls.UI.RadForm
    {
        public GiaInOffsetGiaCongModel giaInSua;
        public TinhTrangForm TinhTrangForm;
        //Dữ liệu nhà in và máy in
        private List<NhaInOffsetModel> nhaInOffsetSrc = new NhaInOffsetContext().DocTatCa();
        private List<MayInOffsetModel> mayInOffsetSrc = new MayInOffsetContext().DocTatCa();
        public TaoGiaInOffsetGiaCongForm()
        {
            InitializeComponent();
            //Đấu nối dữ liệu vô comboboxes
            DauNoiDuLieu();
        }
        private void DauNoiDuLieu()
        {
            nhaInOffsetDropDown.DataSource = null;
            nhaInOffsetDropDown.Items.Clear();
            nhaInOffsetDropDown.DataSource = nhaInOffsetSrc;
            nhaInOffsetDropDown.DataMember = "Id";            
            nhaInOffsetDropDown.DisplayMember = "TenNhaIn";

            mayInOffsetDropDown.DataSource = null;
            mayInOffsetDropDown.Items.Clear();
            mayInOffsetDropDown.DataSource = mayInOffsetSrc;
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

            return output;
        }

        private void taoGiaButton_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                var giaInOffsetContext = new GiaInOffsetGiaCongContext();

                int idNhaIn;
                int idMayIn;

                idNhaIn = ((NhaInOffsetModel)nhaInOffsetDropDown.SelectedValue).Id;
                idMayIn = ((MayInOffsetModel)mayInOffsetDropDown.SelectedValue).Id;
                //int.TryParse(nhaInOffsetDropDown.SelectedValue.ToString(), out idNhaIn);
                //int.TryParse(mayInOffsetDropDown.SelectedValue.ToString(), out idMayIn);


                switch (this.TinhTrangForm)
                {
                    case TinhTrangForm.Moi:


                        var model = new GiaInOffsetGiaCongModel(tenGiaInRTextBox.Text, dienGiaiRTextCtrl.Text, idNhaIn,
                            idMayIn, doiMayInRTextBox.Text, int.Parse(donGiaBaiRTextBox.Text), int.Parse(soToChayBuHaoCoBanRTextBox.Text),
                            int.Parse(soLuongBaoInRTextBox.Text), int.Parse(donGiaVuotRTextBox.Text), donViTinhTheoSoLuongRTextBox.Text,
                            giaDaBaoGomKemRCheck.Checked, thongTinLienHeRTextCtrl.Text, ghiChuRTextCtrl.Text, khongSuDungRCheck.Checked,
                            int.Parse(thuTuSapXepRTextBox.Text));

                        giaInOffsetContext.Them(model);
                        break;
                    case TinhTrangForm.Sua:
                        giaInSua.TenGia = tenGiaInRTextBox.Text;
                        giaInSua.DienGiai = dienGiaiRTextCtrl.Text;
                        giaInSua.IdNhaIn = idNhaIn;
                        giaInSua.IdMayIn = idMayIn;
                        giaInSua.DoiMayIn = doiMayInRTextBox.Text;
                        giaInSua.DonGiaBai = int.Parse(donGiaBaiRTextBox.Text);
                        giaInSua.SoToChayBuHaoCoBan = int.Parse(soToChayBuHaoCoBanRTextBox.Text);
                        giaInSua.SoLuongBaoIn = int.Parse(soLuongBaoInRTextBox.Text);
                        giaInSua.DonGiaVuot = int.Parse(donGiaVuotRTextBox.Text);
                        giaInSua.DonViTinhSoLuong = donViTinhTheoSoLuongRTextBox.Text;
                        giaInSua.GiaDaBaoKem = giaDaBaoGomKemRCheck.Checked;
                        giaInSua.ThongTinLienHe = thongTinLienHeRTextCtrl.Text;
                        giaInSua.GhiChu = ghiChuRTextCtrl.Text;
                        giaInSua.KhongSuDung = khongSuDungRCheck.Checked;
                        giaInSua.ThuTuSapXep = int.Parse(thuTuSapXepRTextBox.Text);
                        giaInOffsetContext.Sua(this.giaInSua);
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
                chiTietMayInTextCtrl.Text = model.ChiTietMayIn;
                ///mayInOffsetDropDown.SelectedValue là đối tượng
                ///mình gắn vô để thử
                ///
                ///int idMayIn = 0;
                ///int.TryParse(mayInOffsetDropDown.SelectedValue.ToString(), out idMayIn);
                ///MessageBox.Show($"{idMayIn}");
                ///var model2 = (MayInOffsetModel)mayInOffsetDropDown.SelectedValue;
                ///MessageBox.Show(model2.Id.ToString());
                ///Cuối cùng là đối tượng khác với nguyên gốc là DataMember
                
            }
            catch { }
        }

        private void TaoGiaInOffsetGiaCongForm_Load(object sender, EventArgs e)
        {
            if (this.TinhTrangForm == TinhTrangForm.Sua)
            {
                tenGiaInRTextBox.Text = this.giaInSua.TenGia;
                dienGiaiRTextCtrl.Text = this.giaInSua.DienGiai;

                doiMayInRTextBox.Text = this.giaInSua.DoiMayIn;
                donGiaBaiRTextBox.Text =  this.giaInSua.DonGiaBai.ToString();
                soToChayBuHaoCoBanRTextBox.Text = this.giaInSua.SoToChayBuHaoCoBan.ToString();
                soLuongBaoInRTextBox.Text = this.giaInSua.SoLuongBaoIn.ToString();
                donGiaVuotRTextBox.Text = this.giaInSua.DonGiaVuot.ToString();
                donViTinhTheoSoLuongRTextBox.Text = this.giaInSua.DonViTinhSoLuong;
                giaDaBaoGomKemRCheck.Checked = this.giaInSua.GiaDaBaoKem;
                thongTinLienHeRTextCtrl.Text = this.giaInSua.ThongTinLienHe;
                ghiChuRTextCtrl.Text = this.giaInSua.GhiChu;               
                khongSuDungRCheck.Checked = this.giaInSua.KhongSuDung;
                thuTuSapXepRTextBox.Text = this.giaInSua.ThuTuSapXep.ToString();
                //Id printer và
                int index = 0;
                foreach (var item in nhaInOffsetDropDown.Items)
                {
                    if (((NhaInOffsetModel)item.DataBoundItem).Id == this.giaInSua.IdNhaIn)
                    {
                        index = item.RowIndex;
                        break;
                    }                    
                }
                nhaInOffsetDropDown.SelectedIndex = index;

                foreach (var item in mayInOffsetDropDown.Items)
                {
                    if (((MayInOffsetModel)item.DataBoundItem).Id == this.giaInSua.IdMayIn)
                    {
                        index = item.RowIndex;
                        break;
                    }
                }
                mayInOffsetDropDown.SelectedIndex = index;

                //Nút
                taoGiaButton.Text = "Lưu";
                tieuDeFormLabel.Text = $"SỬA GIÁ ID [{this.giaInSua.Id}]";

            }
        }
    }
}
