namespace TinhGiaInOffset.WFUI
{
    partial class QuanLyGiaInOffsetGiaCongForm
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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition1 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tieuDeFormLabel = new Telerik.WinControls.UI.RadLabel();
            this.nhaInOffsetDropDown = new Telerik.WinControls.UI.RadDropDownList();
            this.huyButton = new Telerik.WinControls.UI.RadButton();
            this.taoGiaRButton = new Telerik.WinControls.UI.RadButton();
            this.suaGiaRButton = new Telerik.WinControls.UI.RadButton();
            this.panel01RPanel = new Telerik.WinControls.UI.RadPanel();
            this.giaInOffsetRGridView = new Telerik.WinControls.UI.RadGridView();
            this.panelHeadOfPanel01RPanel = new Telerik.WinControls.UI.RadPanel();
            this.tatCaNhaInRCheck = new Telerik.WinControls.UI.RadCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.tieuDeFormLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaInOffsetDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taoGiaRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaGiaRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel01RPanel)).BeginInit();
            this.panel01RPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaInOffsetRGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaInOffsetRGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeadOfPanel01RPanel)).BeginInit();
            this.panelHeadOfPanel01RPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tatCaNhaInRCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tieuDeFormLabel
            // 
            this.tieuDeFormLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tieuDeFormLabel.Location = new System.Drawing.Point(244, 12);
            this.tieuDeFormLabel.Name = "tieuDeFormLabel";
            this.tieuDeFormLabel.Size = new System.Drawing.Size(238, 30);
            this.tieuDeFormLabel.TabIndex = 1;
            this.tieuDeFormLabel.Text = "Tạo Giá In Offset Gia Công";
            // 
            // nhaInOffsetDropDown
            // 
            this.nhaInOffsetDropDown.Location = new System.Drawing.Point(88, 8);
            this.nhaInOffsetDropDown.Name = "nhaInOffsetDropDown";
            this.nhaInOffsetDropDown.Size = new System.Drawing.Size(179, 20);
            this.nhaInOffsetDropDown.TabIndex = 2;
            // 
            // huyButton
            // 
            this.huyButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.huyButton.Location = new System.Drawing.Point(326, 336);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(110, 24);
            this.huyButton.TabIndex = 52;
            this.huyButton.Text = "Hủy";
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // taoGiaRButton
            // 
            this.taoGiaRButton.Location = new System.Drawing.Point(289, 6);
            this.taoGiaRButton.Name = "taoGiaRButton";
            this.taoGiaRButton.Size = new System.Drawing.Size(110, 24);
            this.taoGiaRButton.TabIndex = 53;
            this.taoGiaRButton.Text = "Tạo Giá";
            this.taoGiaRButton.Click += new System.EventHandler(this.taoGiaRButton_Click);
            // 
            // suaGiaRButton
            // 
            this.suaGiaRButton.Location = new System.Drawing.Point(405, 5);
            this.suaGiaRButton.Name = "suaGiaRButton";
            this.suaGiaRButton.Size = new System.Drawing.Size(110, 24);
            this.suaGiaRButton.TabIndex = 54;
            this.suaGiaRButton.Text = "Sửa Giá";
            this.suaGiaRButton.Click += new System.EventHandler(this.suaGiaRButton_Click);
            // 
            // panel01RPanel
            // 
            this.panel01RPanel.Controls.Add(this.giaInOffsetRGridView);
            this.panel01RPanel.Controls.Add(this.panelHeadOfPanel01RPanel);
            this.panel01RPanel.Location = new System.Drawing.Point(12, 48);
            this.panel01RPanel.Name = "panel01RPanel";
            this.panel01RPanel.Size = new System.Drawing.Size(761, 272);
            this.panel01RPanel.TabIndex = 55;
            // 
            // giaInOffsetRGridView
            // 
            this.giaInOffsetRGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.giaInOffsetRGridView.Location = new System.Drawing.Point(0, 39);
            // 
            // 
            // 
            this.giaInOffsetRGridView.MasterTemplate.AllowDragToGroup = false;
            this.giaInOffsetRGridView.MasterTemplate.ViewDefinition = tableViewDefinition1;
            this.giaInOffsetRGridView.Name = "giaInOffsetRGridView";
            this.giaInOffsetRGridView.ReadOnly = true;
            this.giaInOffsetRGridView.Size = new System.Drawing.Size(761, 233);
            this.giaInOffsetRGridView.TabIndex = 57;
            // 
            // panelHeadOfPanel01RPanel
            // 
            this.panelHeadOfPanel01RPanel.Controls.Add(this.tatCaNhaInRCheck);
            this.panelHeadOfPanel01RPanel.Controls.Add(this.taoGiaRButton);
            this.panelHeadOfPanel01RPanel.Controls.Add(this.suaGiaRButton);
            this.panelHeadOfPanel01RPanel.Controls.Add(this.nhaInOffsetDropDown);
            this.panelHeadOfPanel01RPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeadOfPanel01RPanel.Location = new System.Drawing.Point(0, 0);
            this.panelHeadOfPanel01RPanel.Name = "panelHeadOfPanel01RPanel";
            this.panelHeadOfPanel01RPanel.Size = new System.Drawing.Size(761, 39);
            this.panelHeadOfPanel01RPanel.TabIndex = 56;
            // 
            // tatCaNhaInRCheck
            // 
            this.tatCaNhaInRCheck.Location = new System.Drawing.Point(14, 9);
            this.tatCaNhaInRCheck.Name = "tatCaNhaInRCheck";
            this.tatCaNhaInRCheck.Size = new System.Drawing.Size(50, 18);
            this.tatCaNhaInRCheck.TabIndex = 55;
            this.tatCaNhaInRCheck.Text = "Tất cả";
            this.tatCaNhaInRCheck.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.tatCaNhaInRCheck_ToggleStateChanged);
            // 
            // QuanLyGiaInOffsetGiaCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 376);
            this.Controls.Add(this.panel01RPanel);
            this.Controls.Add(this.huyButton);
            this.Controls.Add(this.tieuDeFormLabel);
            this.Name = "QuanLyGiaInOffsetGiaCongForm";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "QuanLyGiaInOffsetGiaCongForm";
            this.Resize += new System.EventHandler(this.QuanLyGiaInOffsetGiaCongForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.tieuDeFormLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaInOffsetDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.huyButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.taoGiaRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaGiaRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel01RPanel)).EndInit();
            this.panel01RPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.giaInOffsetRGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaInOffsetRGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeadOfPanel01RPanel)).EndInit();
            this.panelHeadOfPanel01RPanel.ResumeLayout(false);
            this.panelHeadOfPanel01RPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tatCaNhaInRCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel tieuDeFormLabel;
        private Telerik.WinControls.UI.RadDropDownList nhaInOffsetDropDown;
        private Telerik.WinControls.UI.RadButton huyButton;
        private Telerik.WinControls.UI.RadButton taoGiaRButton;
        private Telerik.WinControls.UI.RadButton suaGiaRButton;
        private Telerik.WinControls.UI.RadPanel panel01RPanel;
        private Telerik.WinControls.UI.RadPanel panelHeadOfPanel01RPanel;
        private Telerik.WinControls.UI.RadCheckBox tatCaNhaInRCheck;
        private Telerik.WinControls.UI.RadGridView giaInOffsetRGridView;
    }
}
