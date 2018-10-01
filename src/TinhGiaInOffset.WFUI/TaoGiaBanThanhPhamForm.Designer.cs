namespace TinhGiaInOffset.WFUI
{
    partial class TaoGiaBanThanhPhamForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tieuDeFormLabel = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.tenRTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.taoRButton = new Telerik.WinControls.UI.RadButton();
            this.huyRButton = new Telerik.WinControls.UI.RadButton();
            this.ghiChuRTextCtrl = new Telerik.WinControls.UI.RadTextBoxControl();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.thanhTienRTextBox = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tieuDeFormLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenRTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taoRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huyRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuRTextCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhTienRTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tieuDeFormLabel
            // 
            this.tieuDeFormLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieuDeFormLabel.Location = new System.Drawing.Point(84, 12);
            this.tieuDeFormLabel.Name = "tieuDeFormLabel";
            this.tieuDeFormLabel.Size = new System.Drawing.Size(157, 30);
            this.tieuDeFormLabel.TabIndex = 11;
            this.tieuDeFormLabel.Text = "Tính giá In Offset";
            // 
            // radLabel3
            // 
            this.radLabel3.Location = new System.Drawing.Point(12, 52);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(24, 18);
            this.radLabel3.TabIndex = 13;
            this.radLabel3.Text = "Tên";
            // 
            // tenRTextBox
            // 
            this.tenRTextBox.Location = new System.Drawing.Point(84, 52);
            this.tenRTextBox.Name = "tenRTextBox";
            this.tenRTextBox.Size = new System.Drawing.Size(218, 20);
            this.tenRTextBox.TabIndex = 1;
            // 
            // taoRButton
            // 
            this.taoRButton.Location = new System.Drawing.Point(164, 188);
            this.taoRButton.Name = "taoRButton";
            this.taoRButton.Size = new System.Drawing.Size(110, 24);
            this.taoRButton.TabIndex = 52;
            this.taoRButton.Text = "Tạo";
            this.taoRButton.Click += new System.EventHandler(this.taoRButton_Click);
            // 
            // huyRButton
            // 
            this.huyRButton.Location = new System.Drawing.Point(48, 188);
            this.huyRButton.Name = "huyRButton";
            this.huyRButton.Size = new System.Drawing.Size(110, 24);
            this.huyRButton.TabIndex = 53;
            this.huyRButton.Text = "Hủy";
            // 
            // ghiChuRTextCtrl
            // 
            this.ghiChuRTextCtrl.Location = new System.Drawing.Point(82, 104);
            this.ghiChuRTextCtrl.Multiline = true;
            this.ghiChuRTextCtrl.Name = "ghiChuRTextCtrl";
            this.ghiChuRTextCtrl.Size = new System.Drawing.Size(220, 57);
            this.ghiChuRTextCtrl.TabIndex = 3;
            // 
            // radLabel1
            // 
            this.radLabel1.Location = new System.Drawing.Point(12, 104);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(44, 18);
            this.radLabel1.TabIndex = 14;
            this.radLabel1.Text = "Ghi chú";
            // 
            // thanhTienRTextBox
            // 
            this.thanhTienRTextBox.Location = new System.Drawing.Point(84, 78);
            this.thanhTienRTextBox.Name = "thanhTienRTextBox";
            this.thanhTienRTextBox.Size = new System.Drawing.Size(218, 20);
            this.thanhTienRTextBox.TabIndex = 2;
            // 
            // radLabel2
            // 
            this.radLabel2.Location = new System.Drawing.Point(12, 79);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(59, 18);
            this.radLabel2.TabIndex = 15;
            this.radLabel2.Text = "Thành tiền";
            // 
            // TaoGiaBanThanhPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 224);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.thanhTienRTextBox);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.ghiChuRTextCtrl);
            this.Controls.Add(this.taoRButton);
            this.Controls.Add(this.huyRButton);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.tenRTextBox);
            this.Controls.Add(this.tieuDeFormLabel);
            this.Name = "TaoGiaBanThanhPhamForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Thành phẩm";
            this.Load += new System.EventHandler(this.TaoGiaBanThanhPhamForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tieuDeFormLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tenRTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taoRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huyRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ghiChuRTextCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thanhTienRTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel tieuDeFormLabel;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadTextBox tenRTextBox;
        private Telerik.WinControls.UI.RadButton taoRButton;
        private Telerik.WinControls.UI.RadButton huyRButton;
        private Telerik.WinControls.UI.RadTextBoxControl ghiChuRTextCtrl;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox thanhTienRTextBox;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
