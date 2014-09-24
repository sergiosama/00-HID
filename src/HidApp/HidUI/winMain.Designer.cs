using HidUI.Views;

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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winMain));
      this.ribMain = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.bbiLogin = new DevExpress.XtraBars.BarButtonItem();
      this.bbiAbout = new DevExpress.XtraBars.BarButtonItem();
      this.bbiLogout = new DevExpress.XtraBars.BarButtonItem();
      this.bbUserConnected = new DevExpress.XtraBars.BarButtonItem();
      this.ppUserInfo = new HidUI.Views.ETPopupControlContainer(this.components);
      this.usrInfo = new HidUI.Views.UserInfoView();
      this.rbpgInicio = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.sbar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.pnlContainer = new DevExpress.XtraEditors.XtraUserControl();
      this.txtHidden = new DevExpress.XtraEditors.TextEdit();
      this.pnlSplit = new DevExpress.XtraEditors.SplitContainerControl();
      this.srchMain = new DevExpress.XtraEditors.SearchControl();
      ((System.ComponentModel.ISupportInitialize)(this.ribMain)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ppUserInfo)).BeginInit();
      this.ppUserInfo.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtHidden.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pnlSplit)).BeginInit();
      this.pnlSplit.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.srchMain.Properties)).BeginInit();
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
            this.bbUserConnected});
      this.ribMain.Location = new System.Drawing.Point(0, 0);
      this.ribMain.MaxItemId = 11;
      this.ribMain.Name = "ribMain";
      this.ribMain.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rbpgInicio});
      this.ribMain.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
      this.ribMain.Size = new System.Drawing.Size(1193, 144);
      this.ribMain.StatusBar = this.sbar;
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
      // bbUserConnected
      // 
      this.bbUserConnected.ActAsDropDown = true;
      this.bbUserConnected.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
      this.bbUserConnected.Caption = "<Indeterminado>";
      this.bbUserConnected.CategoryGuid = new System.Guid("6ffddb2b-9015-4d97-a4c1-91613e0ef537");
      this.bbUserConnected.DropDownControl = this.ppUserInfo;
      this.bbUserConnected.Id = 11;
      this.bbUserConnected.Name = "bbUserConnected";
      // 
      // ppUserInfo
      // 
      this.ppUserInfo.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
      this.ppUserInfo.Controls.Add(this.usrInfo);
      this.ppUserInfo.DropDirection = HidUI.Views.DropDirection.DropUp;
      this.ppUserInfo.Location = new System.Drawing.Point(31, 523);
      this.ppUserInfo.Name = "ppUserInfo";
      this.ppUserInfo.Size = new System.Drawing.Size(300, 160);
      this.ppUserInfo.TabIndex = 6;
      this.ppUserInfo.Visible = false;
      this.ppUserInfo.Popup += new System.EventHandler(this.UserInfo_Popup);
      // 
      // usrInfo
      // 
      this.usrInfo.Location = new System.Drawing.Point(4, 3);
      this.usrInfo.Name = "usrInfo";
      this.usrInfo.Size = new System.Drawing.Size(293, 154);
      this.usrInfo.TabIndex = 13;
      this.usrInfo.VerPerfil += new System.EventHandler(this.ViewPerfilUsuario);
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
      // sbar
      // 
      this.sbar.ItemLinks.Add(this.bbUserConnected);
      this.sbar.Location = new System.Drawing.Point(0, 791);
      this.sbar.Name = "sbar";
      this.sbar.Ribbon = this.ribMain;
      this.sbar.Size = new System.Drawing.Size(1193, 31);
      // 
      // pnlContainer
      // 
      this.pnlContainer.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.pnlContainer.Appearance.Options.UseBackColor = true;
      this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlContainer.Location = new System.Drawing.Point(0, 0);
      this.pnlContainer.Name = "pnlContainer";
      this.pnlContainer.Size = new System.Drawing.Size(1193, 639);
      this.pnlContainer.TabIndex = 3;
      // 
      // txtHidden
      // 
      this.txtHidden.Location = new System.Drawing.Point(784, 727);
      this.txtHidden.MenuManager = this.ribMain;
      this.txtHidden.Name = "txtHidden";
      this.txtHidden.Size = new System.Drawing.Size(248, 20);
      this.txtHidden.TabIndex = 13;
      this.txtHidden.TextChanged += new System.EventHandler(this.CambiarBinding);
      // 
      // pnlSplit
      // 
      this.pnlSplit.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlSplit.Horizontal = false;
      this.pnlSplit.IsSplitterFixed = true;
      this.pnlSplit.Location = new System.Drawing.Point(0, 144);
      this.pnlSplit.Name = "pnlSplit";
      this.pnlSplit.Panel1.Controls.Add(this.srchMain);
      this.pnlSplit.Panel1.Text = "Search";
      this.pnlSplit.Panel2.Controls.Add(this.pnlContainer);
      this.pnlSplit.Panel2.Text = "Content";
      this.pnlSplit.Size = new System.Drawing.Size(1193, 678);
      this.pnlSplit.SplitterPosition = 34;
      this.pnlSplit.TabIndex = 17;
      this.pnlSplit.Text = "splitContainerControl1";
      // 
      // srchMain
      // 
      this.srchMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.srchMain.EditValue = "";
      this.srchMain.Location = new System.Drawing.Point(0, 0);
      this.srchMain.MenuManager = this.ribMain;
      this.srchMain.Name = "srchMain";
      this.srchMain.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.srchMain.Properties.Appearance.Options.UseFont = true;
      this.srchMain.Properties.AutoHeight = false;
      this.srchMain.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton(),
            new DevExpress.XtraEditors.Repository.MRUButton()});
      this.srchMain.Properties.NullValuePrompt = "Ingrese un texto para buscar....";
      this.srchMain.Properties.ShowMRUButton = true;
      this.srchMain.Properties.ShowNullValuePromptWhenFocused = true;
      this.srchMain.Size = new System.Drawing.Size(1193, 34);
      this.srchMain.TabIndex = 0;
      // 
      // winMain
      // 
      this.AllowFormGlass = DevExpress.Utils.DefaultBoolean.True;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1193, 822);
      this.Controls.Add(this.ppUserInfo);
      this.Controls.Add(this.sbar);
      this.Controls.Add(this.pnlSplit);
      this.Controls.Add(this.txtHidden);
      this.Controls.Add(this.ribMain);
      this.Name = "winMain";
      this.Ribbon = this.ribMain;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.StatusBar = this.sbar;
      this.Text = "HID Sistema - Pantalla Inicial";
      ((System.ComponentModel.ISupportInitialize)(this.ribMain)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ppUserInfo)).EndInit();
      this.ppUserInfo.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtHidden.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pnlSplit)).EndInit();
      this.pnlSplit.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.srchMain.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribMain;
    private DevExpress.XtraBars.Ribbon.RibbonPage rbpgInicio;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.BarButtonItem bbiLogin;
    private DevExpress.XtraBars.BarButtonItem bbiAbout;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar sbar;
    private DevExpress.XtraEditors.XtraUserControl pnlContainer;
    private DevExpress.XtraBars.BarButtonItem bbiLogout;
    private DevExpress.XtraBars.BarButtonItem bbUserConnected;
    //
    //  workaround para el control de usuario
    private ETPopupControlContainer ppUserInfo;
    private UserInfoView usrInfo;
    private DevExpress.XtraEditors.TextEdit txtHidden;
    private DevExpress.XtraEditors.SplitContainerControl pnlSplit;
    private DevExpress.XtraEditors.SearchControl srchMain;
  }
}

