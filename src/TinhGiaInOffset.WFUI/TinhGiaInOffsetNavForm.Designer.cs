﻿namespace TinhGiaInOffset.WFUI
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
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).BeginInit();
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
            // TinhGiaInOffsetNavForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 93);
            this.Controls.Add(this.radMenu1);
            this.Name = "TinhGiaInOffsetNavForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Form chính";
            ((System.ComponentModel.ISupportInitialize)(this.radMenu1)).EndInit();
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
    }
}