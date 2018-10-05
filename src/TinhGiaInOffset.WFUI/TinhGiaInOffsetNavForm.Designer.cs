namespace TinhGiaInOffset.WFUI
{
    partial class TinhGiaInOffsetNavForm
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
            this.radMenu1 = new Telerik.WinControls.UI.RadMenu();
            this.radMenuItem1 = new Telerik.WinControls.UI.RadMenuItem();
            this.thoatRMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.radMenuItem2 = new Telerik.WinControls.UI.RadMenuItem();
            this.quanLyGiaInOffsetRMenuItem = new Telerik.WinControls.UI.RadMenuItem();
            this.themTinhGiaOffsetRButton = new Telerik.WinControls.UI.RadButton();
            this.thoatRButton = new Telerik.WinControls.UI.RadButton();
            this.xemBangGiaInOffsetGiaCongRButton = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.themTinhGiaOffsetRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoatRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemBangGiaInOffsetGiaCongRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radMenu1
            // 
            this.radMenu1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.radMenuItem1,
            this.radMenuItem2});
            this.radMenu1.Location = new System.Drawing.Point(0, 0);
            this.radMenu1.Name = "radMenu1";
            this.radMenu1.Size = new System.Drawing.Size(474, 20);
            this.radMenu1.TabIndex = 0;
            // 
            // radMenuItem1
            // 
            this.radMenuItem1.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.thoatRMenuItem});
            this.radMenuItem1.Name = "radMenuItem1";
            this.radMenuItem1.Text = "File";
            // 
            // thoatRMenuItem
            // 
            this.thoatRMenuItem.Name = "thoatRMenuItem";
            this.thoatRMenuItem.Text = "Thoát";
            this.thoatRMenuItem.Click += new System.EventHandler(this.thoatRMenuItem_Click);
            // 
            // radMenuItem2
            // 
            this.radMenuItem2.Items.AddRange(new Telerik.WinControls.RadItem[] {
            this.quanLyGiaInOffsetRMenuItem});
            this.radMenuItem2.Name = "radMenuItem2";
            this.radMenuItem2.Text = "Cài đặt";
            // 
            // quanLyGiaInOffsetRMenuItem
            // 
            this.quanLyGiaInOffsetRMenuItem.Name = "quanLyGiaInOffsetRMenuItem";
            this.quanLyGiaInOffsetRMenuItem.Text = "Quản lý giá in offset";
            this.quanLyGiaInOffsetRMenuItem.Click += new System.EventHandler(this.quanLyGiaInOffsetRMenuItem_Click);
            // 
            // themTinhGiaOffsetRButton
            // 
            this.themTinhGiaOffsetRButton.Location = new System.Drawing.Point(12, 26);
            this.themTinhGiaOffsetRButton.Name = "themTinhGiaOffsetRButton";
            this.themTinhGiaOffsetRButton.Size = new System.Drawing.Size(110, 55);
            this.themTinhGiaOffsetRButton.TabIndex = 0;
            this.themTinhGiaOffsetRButton.Text = "Tính giá Mới";
            this.themTinhGiaOffsetRButton.Click += new System.EventHandler(this.themTinhGiaOffsetRButton_Click);
            // 
            // thoatRButton
            // 
            this.thoatRButton.Location = new System.Drawing.Point(244, 26);
            this.thoatRButton.Name = "thoatRButton";
            this.thoatRButton.Size = new System.Drawing.Size(110, 55);
            this.thoatRButton.TabIndex = 1;
            this.thoatRButton.Text = "Thoát";
            this.thoatRButton.Click += new System.EventHandler(this.thoatRMenuItem_Click);
            // 
            // xemBangGiaInOffsetGiaCongRButton
            // 
            this.xemBangGiaInOffsetGiaCongRButton.Location = new System.Drawing.Point(128, 26);
            this.xemBangGiaInOffsetGiaCongRButton.Name = "xemBangGiaInOffsetGiaCongRButton";
            this.xemBangGiaInOffsetGiaCongRButton.Size = new System.Drawing.Size(110, 55);
            this.xemBangGiaInOffsetGiaCongRButton.TabIndex = 1;
            this.xemBangGiaInOffsetGiaCongRButton.Text = "Xem giá in gia công Offset";
            this.xemBangGiaInOffsetGiaCongRButton.TextWrap = true;
            this.xemBangGiaInOffsetGiaCongRButton.Click += new System.EventHandler(this.xemBangGiaInOffsetGiaCongRButton_Click);
            // 
            // TinhGiaInOffsetNavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 93);
            this.Controls.Add(this.xemBangGiaInOffsetGiaCongRButton);
            this.Controls.Add(this.thoatRButton);
            this.Controls.Add(this.themTinhGiaOffsetRButton);
            this.Controls.Add(this.radMenu1);
            this.MaximizeBox = false;
            this.Name = "TinhGiaInOffsetNavForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form chính";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.themTinhGiaOffsetRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thoatRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xemBangGiaInOffsetGiaCongRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadMenu radMenu1;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem1;
        private Telerik.WinControls.UI.RadMenuItem thoatRMenuItem;
        private Telerik.WinControls.UI.RadMenuItem radMenuItem2;
        private Telerik.WinControls.UI.RadMenuItem quanLyGiaInOffsetRMenuItem;
        private Telerik.WinControls.UI.RadButton themTinhGiaOffsetRButton;
        private Telerik.WinControls.UI.RadButton thoatRButton;
        private Telerik.WinControls.UI.RadButton xemBangGiaInOffsetGiaCongRButton;
    }
}