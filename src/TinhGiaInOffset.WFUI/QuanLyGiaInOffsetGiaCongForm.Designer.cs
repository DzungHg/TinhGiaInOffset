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
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.tieuDeFormLabel = new Telerik.WinControls.UI.RadLabel();
            this.nhaInOffsetDropDown = new Telerik.WinControls.UI.RadDropDownList();
            this.huyButton = new Telerik.WinControls.UI.RadButton();
            this.taoRButton = new Telerik.WinControls.UI.RadButton();
            this.suaRButton = new Telerik.WinControls.UI.RadButton();
            this.panel01RPanel = new Telerik.WinControls.UI.RadPanel();
            this.giaInOffsetRGridView = new Telerik.WinControls.UI.RadGridView();
            this.panelHeadOfPanel01RPanel = new Telerik.WinControls.UI.RadPanel();
            this.tatCaNhaInRCheck = new Telerik.WinControls.UI.RadCheckBox();
            this.PageView1 = new Telerik.WinControls.UI.RadPageView();
            this.tabGiaGiaCongPageView = new Telerik.WinControls.UI.RadPageViewPage();
            this.tabMayInPageView = new Telerik.WinControls.UI.RadPageViewPage();
            this.mayInOffsetRGridView = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tieuDeFormLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaInOffsetDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.huyButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.taoRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaRButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel01RPanel)).BeginInit();
            this.panel01RPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.giaInOffsetRGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaInOffsetRGridView.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeadOfPanel01RPanel)).BeginInit();
            this.panelHeadOfPanel01RPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tatCaNhaInRCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageView1)).BeginInit();
            this.PageView1.SuspendLayout();
            this.tabGiaGiaCongPageView.SuspendLayout();
            this.tabMayInPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mayInOffsetRGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayInOffsetRGridView.MasterTemplate)).BeginInit();
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
            this.huyButton.Location = new System.Drawing.Point(359, 541);
            this.huyButton.Name = "huyButton";
            this.huyButton.Size = new System.Drawing.Size(110, 24);
            this.huyButton.TabIndex = 52;
            this.huyButton.Text = "Hủy";
            this.huyButton.Click += new System.EventHandler(this.huyButton_Click);
            // 
            // taoRButton
            // 
            this.taoRButton.Location = new System.Drawing.Point(22, 71);
            this.taoRButton.Name = "taoRButton";
            this.taoRButton.Size = new System.Drawing.Size(110, 24);
            this.taoRButton.TabIndex = 53;
            this.taoRButton.Text = "Tạo";
            this.taoRButton.Click += new System.EventHandler(this.taoGiaRButton_Click);
            // 
            // suaRButton
            // 
            this.suaRButton.Location = new System.Drawing.Point(138, 70);
            this.suaRButton.Name = "suaRButton";
            this.suaRButton.Size = new System.Drawing.Size(110, 24);
            this.suaRButton.TabIndex = 54;
            this.suaRButton.Text = "Sửa";
            this.suaRButton.Click += new System.EventHandler(this.suaGiaRButton_Click);
            // 
            // panel01RPanel
            // 
            this.panel01RPanel.Controls.Add(this.giaInOffsetRGridView);
            this.panel01RPanel.Controls.Add(this.panelHeadOfPanel01RPanel);
            this.panel01RPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel01RPanel.Location = new System.Drawing.Point(0, 0);
            this.panel01RPanel.Name = "panel01RPanel";
            this.panel01RPanel.Size = new System.Drawing.Size(798, 386);
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
            this.giaInOffsetRGridView.Size = new System.Drawing.Size(798, 347);
            this.giaInOffsetRGridView.TabIndex = 57;
            this.giaInOffsetRGridView.CreateCell += new Telerik.WinControls.UI.GridViewCreateCellEventHandler(this.giaInOffsetRGridView_CreateCell);
            // 
            // panelHeadOfPanel01RPanel
            // 
            this.panelHeadOfPanel01RPanel.Controls.Add(this.tatCaNhaInRCheck);
            this.panelHeadOfPanel01RPanel.Controls.Add(this.nhaInOffsetDropDown);
            this.panelHeadOfPanel01RPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeadOfPanel01RPanel.Location = new System.Drawing.Point(0, 0);
            this.panelHeadOfPanel01RPanel.Name = "panelHeadOfPanel01RPanel";
            this.panelHeadOfPanel01RPanel.Size = new System.Drawing.Size(798, 39);
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
            // PageView1
            // 
            this.PageView1.Controls.Add(this.tabGiaGiaCongPageView);
            this.PageView1.Controls.Add(this.tabMayInPageView);
            this.PageView1.Location = new System.Drawing.Point(12, 101);
            this.PageView1.Name = "PageView1";
            this.PageView1.SelectedPage = this.tabGiaGiaCongPageView;
            this.PageView1.Size = new System.Drawing.Size(819, 434);
            this.PageView1.TabIndex = 56;
            // 
            // tabGiaGiaCongPageView
            // 
            this.tabGiaGiaCongPageView.Controls.Add(this.panel01RPanel);
            this.tabGiaGiaCongPageView.ItemSize = new System.Drawing.SizeF(79F, 28F);
            this.tabGiaGiaCongPageView.Location = new System.Drawing.Point(10, 37);
            this.tabGiaGiaCongPageView.Name = "tabGiaGiaCongPageView";
            this.tabGiaGiaCongPageView.Size = new System.Drawing.Size(798, 386);
            this.tabGiaGiaCongPageView.Text = "Giá gia công";
            // 
            // tabMayInPageView
            // 
            this.tabMayInPageView.Controls.Add(this.mayInOffsetRGridView);
            this.tabMayInPageView.ItemSize = new System.Drawing.SizeF(83F, 28F);
            this.tabMayInPageView.Location = new System.Drawing.Point(10, 37);
            this.tabMayInPageView.Name = "tabMayInPageView";
            this.tabMayInPageView.Size = new System.Drawing.Size(798, 386);
            this.tabMayInPageView.Text = "Máy in Offset";
            // 
            // mayInOffsetRGridView
            // 
            this.mayInOffsetRGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mayInOffsetRGridView.Location = new System.Drawing.Point(0, 0);
            // 
            // 
            // 
            this.mayInOffsetRGridView.MasterTemplate.AllowDragToGroup = false;
            this.mayInOffsetRGridView.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.mayInOffsetRGridView.Name = "mayInOffsetRGridView";
            this.mayInOffsetRGridView.ReadOnly = true;
            this.mayInOffsetRGridView.Size = new System.Drawing.Size(798, 386);
            this.mayInOffsetRGridView.TabIndex = 58;
            // 
            // QuanLyGiaInOffsetGiaCongForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 580);
            this.Controls.Add(this.PageView1);
            this.Controls.Add(this.taoRButton);
            this.Controls.Add(this.suaRButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.taoRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suaRButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panel01RPanel)).EndInit();
            this.panel01RPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.giaInOffsetRGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giaInOffsetRGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeadOfPanel01RPanel)).EndInit();
            this.panelHeadOfPanel01RPanel.ResumeLayout(false);
            this.panelHeadOfPanel01RPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tatCaNhaInRCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PageView1)).EndInit();
            this.PageView1.ResumeLayout(false);
            this.tabGiaGiaCongPageView.ResumeLayout(false);
            this.tabMayInPageView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mayInOffsetRGridView.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mayInOffsetRGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel tieuDeFormLabel;
        private Telerik.WinControls.UI.RadDropDownList nhaInOffsetDropDown;
        private Telerik.WinControls.UI.RadButton huyButton;
        private Telerik.WinControls.UI.RadButton taoRButton;
        private Telerik.WinControls.UI.RadButton suaRButton;
        private Telerik.WinControls.UI.RadPanel panel01RPanel;
        private Telerik.WinControls.UI.RadPanel panelHeadOfPanel01RPanel;
        private Telerik.WinControls.UI.RadCheckBox tatCaNhaInRCheck;
        private Telerik.WinControls.UI.RadGridView giaInOffsetRGridView;
        private Telerik.WinControls.UI.RadPageView PageView1;
        private Telerik.WinControls.UI.RadPageViewPage tabGiaGiaCongPageView;
        private Telerik.WinControls.UI.RadPageViewPage tabMayInPageView;
        private Telerik.WinControls.UI.RadGridView mayInOffsetRGridView;
    }
}
