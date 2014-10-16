namespace WinTestEF
{
  partial class frmNavegacion
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNavegacion));
      this.ribMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.bbnVista1 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
      this.mainSearch = new DevExpress.XtraEditors.SearchControl();
      this.mainContent = new DevExpress.XtraEditors.XtraUserControl();
      ((System.ComponentModel.ISupportInitialize)(this.ribMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
      this.splitContainerControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.mainSearch.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // ribMain
      // 
      this.ribMain.ExpandCollapseItem.Id = 0;
      this.ribMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribMain.ExpandCollapseItem,
            this.bbnVista1,
            this.barButtonItem2});
      this.ribMain.Location = new System.Drawing.Point(0, 0);
      this.ribMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ribMain.MaxItemId = 3;
      this.ribMain.Name = "ribMain";
      this.ribMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2});
      this.ribMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
      this.ribMain.Size = new System.Drawing.Size(1028, 144);
      this.ribMain.StatusBar = this.ribbonStatusBar;
      this.ribMain.SelectedPageChanged += new System.EventHandler(this.CambioPagina_Principal);
      // 
      // bbnVista1
      // 
      this.bbnVista1.Caption = "VISTA 1";
      this.bbnVista1.Glyph = ((System.Drawing.Image)(resources.GetObject("bbnVista1.Glyph")));
      this.bbnVista1.Id = 1;
      this.bbnVista1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbnVista1.LargeGlyph")));
      this.bbnVista1.Name = "bbnVista1";
      // 
      // barButtonItem2
      // 
      this.barButtonItem2.Caption = "Boton 2";
      this.barButtonItem2.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.Glyph")));
      this.barButtonItem2.Id = 2;
      this.barButtonItem2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.LargeGlyph")));
      this.barButtonItem2.Name = "barButtonItem2";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Tag = "START";
      this.ribbonPage1.Text = "INICIO";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.bbnVista1);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "ribbonPageGroup1";
      // 
      // ribbonPage2
      // 
      this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
      this.ribbonPage2.Name = "ribbonPage2";
      this.ribbonPage2.Tag = "START";
      this.ribbonPage2.Text = "SEGUNDA";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItem2);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "ribbonPageGroup2";
      // 
      // ribbonStatusBar
      // 
      this.ribbonStatusBar.Location = new System.Drawing.Point(0, 693);
      this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribMain;
      this.ribbonStatusBar.Size = new System.Drawing.Size(1028, 31);
      // 
      // splitContainerControl1
      // 
      this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerControl1.Horizontal = false;
      this.splitContainerControl1.IsSplitterFixed = true;
      this.splitContainerControl1.Location = new System.Drawing.Point(0, 144);
      this.splitContainerControl1.Name = "splitContainerControl1";
      this.splitContainerControl1.Panel1.Controls.Add(this.mainSearch);
      this.splitContainerControl1.Panel1.Text = "Search";
      this.splitContainerControl1.Panel2.Controls.Add(this.mainContent);
      this.splitContainerControl1.Panel2.Text = "Content";
      this.splitContainerControl1.Size = new System.Drawing.Size(1028, 549);
      this.splitContainerControl1.SplitterPosition = 34;
      this.splitContainerControl1.TabIndex = 2;
      this.splitContainerControl1.Text = "splitContainerControl1";
      // 
      // mainSearch
      // 
      this.mainSearch.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainSearch.Location = new System.Drawing.Point(0, 0);
      this.mainSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.mainSearch.MenuManager = this.ribMain;
      this.mainSearch.Name = "mainSearch";
      this.mainSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.mainSearch.Properties.Appearance.Options.UseFont = true;
      this.mainSearch.Properties.AutoHeight = false;
      this.mainSearch.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton(),
            new DevExpress.XtraEditors.Repository.MRUButton()});
      this.mainSearch.Properties.NullValuePrompt = "Ingresar texto a buscar...";
      this.mainSearch.Properties.ShowMRUButton = true;
      this.mainSearch.Size = new System.Drawing.Size(1028, 34);
      this.mainSearch.TabIndex = 0;
      // 
      // mainContent
      // 
      this.mainContent.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
      this.mainContent.Appearance.Options.UseBackColor = true;
      this.mainContent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.mainContent.Location = new System.Drawing.Point(0, 0);
      this.mainContent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
      this.mainContent.Name = "mainContent";
      this.mainContent.Size = new System.Drawing.Size(1028, 510);
      this.mainContent.TabIndex = 0;
      // 
      // frmNavegacion
      // 
      this.Appearance.Options.UseFont = true;
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1028, 724);
      this.Controls.Add(this.splitContainerControl1);
      this.Controls.Add(this.ribbonStatusBar);
      this.Controls.Add(this.ribMain);
      this.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "frmNavegacion";
      this.Ribbon = this.ribMain;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "BRANCH NUEVA FEATURE";
      ((System.ComponentModel.ISupportInitialize)(this.ribMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
      this.splitContainerControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.mainSearch.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribMain;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    private DevExpress.XtraEditors.SearchControl mainSearch;
    private DevExpress.XtraEditors.XtraUserControl mainContent;
    private DevExpress.XtraBars.BarButtonItem bbnVista1;
    private DevExpress.XtraBars.BarButtonItem barButtonItem2;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
  }
}