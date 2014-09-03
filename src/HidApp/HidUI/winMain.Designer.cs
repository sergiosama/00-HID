namespace HidUI
{
  partial class winMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMain));
      this.ribMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.bbiLogin = new DevExpress.XtraBars.BarButtonItem();
      this.bbiAbout = new DevExpress.XtraBars.BarButtonItem();
      this.bbiLogout = new DevExpress.XtraBars.BarButtonItem();
      this.barUserName = new DevExpress.XtraBars.BarStaticItem();
      this.rbpgInicio = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
      this.repositoryItemPopupContainerEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit();
      this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.pnlContainer = new DevExpress.XtraEditors.XtraUserControl();
      ((System.ComponentModel.ISupportInitialize)(this.ribMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).BeginInit();
      this.SuspendLayout();
      // 
      // ribMain
      // 
      this.ribMain.Cursor = System.Windows.Forms.Cursors.Default;
      this.ribMain.ExpandCollapseItem.Id = 0;
      this.ribMain.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.ribMain.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribMain.ExpandCollapseItem,
            this.bbiLogin,
            this.bbiAbout,
            this.bbiLogout,
            this.barUserName});
      this.ribMain.Location = new System.Drawing.Point(0, 0);
      this.ribMain.MaxItemId = 8;
      this.ribMain.Name = "ribMain";
      this.ribMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpgInicio});
      this.ribMain.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1,
            this.repositoryItemPopupContainerEdit1});
      this.ribMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
      this.ribMain.Size = new System.Drawing.Size(1193, 144);
      this.ribMain.StatusBar = this.ribbonStatusBar1;
      this.ribMain.PageGroupCaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.GrupoClick);
      this.ribMain.SelectedPageChanged += new System.EventHandler(this.Ribbon_CambiarPagina);
      // 
      // bbiLogin
      // 
      this.bbiLogin.Caption = "Login";
      this.bbiLogin.Id = 1;
      this.bbiLogin.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiLogin.LargeGlyph")));
      this.bbiLogin.Name = "bbiLogin";
      // 
      // bbiAbout
      // 
      this.bbiAbout.Caption = "Acerca de...";
      this.bbiAbout.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiAbout.Glyph")));
      this.bbiAbout.Id = 2;
      this.bbiAbout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiAbout.LargeGlyph")));
      this.bbiAbout.Name = "bbiAbout";
      // 
      // bbiLogout
      // 
      this.bbiLogout.Caption = "Logout";
      this.bbiLogout.Enabled = false;
      this.bbiLogout.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiLogout.Glyph")));
      this.bbiLogout.Id = 3;
      this.bbiLogout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiLogout.LargeGlyph")));
      this.bbiLogout.Name = "bbiLogout";
      // 
      // barUserName
      // 
      this.barUserName.Caption = "Desconectado";
      this.barUserName.Glyph = global::HidUI.Properties.Resources.administrator_48;
      this.barUserName.Id = 7;
      this.barUserName.LargeGlyph = global::HidUI.Properties.Resources.administrator_48;
      this.barUserName.Name = "barUserName";
      this.barUserName.TextAlignment = System.Drawing.StringAlignment.Near;
      // 
      // rbpgInicio
      // 
      this.rbpgInicio.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.rbpgInicio.Name = "rbpgInicio";
      this.rbpgInicio.Text = "INICIO";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.bbiLogin);
      this.ribbonPageGroup1.ItemLinks.Add(this.bbiLogout);
      this.ribbonPageGroup1.ItemLinks.Add(this.bbiAbout);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "Acceso";
      // 
      // repositoryItemMemoEdit1
      // 
      this.repositoryItemMemoEdit1.LinesCount = 20;
      this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
      // 
      // repositoryItemPopupContainerEdit1
      // 
      this.repositoryItemPopupContainerEdit1.AutoHeight = false;
      this.repositoryItemPopupContainerEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemPopupContainerEdit1.Name = "repositoryItemPopupContainerEdit1";
      this.repositoryItemPopupContainerEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
      // 
      // ribbonStatusBar1
      // 
      this.ribbonStatusBar1.ItemLinks.Add(this.barUserName);
      this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 791);
      this.ribbonStatusBar1.Name = "ribbonStatusBar1";
      this.ribbonStatusBar1.Ribbon = this.ribMain;
      this.ribbonStatusBar1.Size = new System.Drawing.Size(1193, 31);
      // 
      // pnlContainer
      // 
      this.pnlContainer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.pnlContainer.Appearance.Options.UseBackColor = true;
      this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlContainer.Location = new System.Drawing.Point(0, 144);
      this.pnlContainer.Name = "pnlContainer";
      this.pnlContainer.Size = new System.Drawing.Size(1193, 647);
      this.pnlContainer.TabIndex = 3;
      // 
      // winMain
      // 
      this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1193, 822);
      this.Controls.Add(this.pnlContainer);
      this.Controls.Add(this.ribbonStatusBar1);
      this.Controls.Add(this.ribMain);
      this.Name = "winMain";
      this.Ribbon = this.ribMain;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.StatusBar = this.ribbonStatusBar1;
      this.Text = "HID Sistema - Pantalla Inicial";
      ((System.ComponentModel.ISupportInitialize)(this.ribMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemPopupContainerEdit1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribMain;
    private DevExpress.XtraBars.Ribbon.RibbonPage rbpgInicio;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.BarButtonItem bbiLogin;
    private DevExpress.XtraBars.BarButtonItem bbiAbout;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
    private DevExpress.XtraEditors.XtraUserControl pnlContainer;
    private DevExpress.XtraBars.BarButtonItem bbiLogout;
    private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
    private DevExpress.XtraEditors.Repository.RepositoryItemPopupContainerEdit repositoryItemPopupContainerEdit1;
    private DevExpress.XtraBars.BarStaticItem barUserName;
  }
}

