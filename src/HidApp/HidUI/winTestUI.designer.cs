namespace HidUI
{
  partial class winTestUI
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(winTestUI));
      DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
      DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.bbnNuevoProveedor = new DevExpress.XtraBars.BarButtonItem();
      this.bbnEditProvedor = new DevExpress.XtraBars.BarButtonItem();
      this.bbnBuscarProveedor = new DevExpress.XtraBars.BarButtonItem();
      this.btxtUsuario = new DevExpress.XtraBars.BarStaticItem();
      this.btxtSearchResult = new DevExpress.XtraBars.BarStaticItem();
      this.bbnNuevoAlquilable = new DevExpress.XtraBars.BarButtonItem();
      this.bbnEditAlquilable = new DevExpress.XtraBars.BarButtonItem();
      this.bbnBuscarAlquilable = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.txtHidden = new System.Windows.Forms.TextBox();
      this.txtHiddenSearch = new System.Windows.Forms.TextBox();
      this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
      this.panelControl1.SuspendLayout();
      this.SuspendLayout();
      // 
      // ribbon
      // 
      this.ribbon.ExpandCollapseItem.Id = 0;
      this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.bbnNuevoProveedor,
            this.bbnEditProvedor,
            this.bbnBuscarProveedor,
            this.btxtUsuario,
            this.btxtSearchResult,
            this.bbnNuevoAlquilable,
            this.bbnEditAlquilable,
            this.bbnBuscarAlquilable});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.MaxItemId = 10;
      this.ribbon.Name = "ribbon";
      this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribbon.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2013;
      this.ribbon.Size = new System.Drawing.Size(876, 144);
      this.ribbon.StatusBar = this.ribbonStatusBar;
      // 
      // bbnNuevoProveedor
      // 
      this.bbnNuevoProveedor.Caption = "Nuevo";
      this.bbnNuevoProveedor.Id = 1;
      this.bbnNuevoProveedor.LargeGlyph = global::HidUI.Properties.Resources.realvista_accounting_basket_48;
      this.bbnNuevoProveedor.Name = "bbnNuevoProveedor";
      // 
      // bbnEditProvedor
      // 
      this.bbnEditProvedor.Caption = "Modificar";
      this.bbnEditProvedor.Glyph = ((System.Drawing.Image)(resources.GetObject("bbnEditProvedor.Glyph")));
      this.bbnEditProvedor.Id = 2;
      this.bbnEditProvedor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbnEditProvedor.LargeGlyph")));
      this.bbnEditProvedor.Name = "bbnEditProvedor";
      // 
      // bbnBuscarProveedor
      // 
      this.bbnBuscarProveedor.Caption = "Buscar";
      this.bbnBuscarProveedor.Glyph = ((System.Drawing.Image)(resources.GetObject("bbnBuscarProveedor.Glyph")));
      this.bbnBuscarProveedor.Id = 3;
      this.bbnBuscarProveedor.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbnBuscarProveedor.LargeGlyph")));
      this.bbnBuscarProveedor.Name = "bbnBuscarProveedor";
      // 
      // btxtUsuario
      // 
      this.btxtUsuario.Caption = "<Desconectado>";
      this.btxtUsuario.Id = 4;
      this.btxtUsuario.ItemAppearance.Normal.BackColor = System.Drawing.Color.Pink;
      this.btxtUsuario.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.btxtUsuario.ItemAppearance.Normal.Options.UseBackColor = true;
      this.btxtUsuario.ItemAppearance.Normal.Options.UseFont = true;
      this.btxtUsuario.Name = "btxtUsuario";
      this.btxtUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
      // 
      // btxtSearchResult
      // 
      this.btxtSearchResult.Caption = "<Resultado de la búsqueda>";
      this.btxtSearchResult.Id = 5;
      this.btxtSearchResult.ItemAppearance.Normal.BackColor = System.Drawing.Color.PaleTurquoise;
      this.btxtSearchResult.ItemAppearance.Normal.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.btxtSearchResult.ItemAppearance.Normal.Options.UseBackColor = true;
      this.btxtSearchResult.ItemAppearance.Normal.Options.UseFont = true;
      this.btxtSearchResult.Name = "btxtSearchResult";
      toolTipTitleItem1.Text = "Resultado de la Busqueda";
      toolTipItem1.LeftIndent = 6;
      toolTipItem1.Text = "Visualiza el ultimo resultado encontrado de cualquier operacion de busqueda dentr" +
    "o de la aplicacion";
      superToolTip1.Items.Add(toolTipTitleItem1);
      superToolTip1.Items.Add(toolTipItem1);
      this.btxtSearchResult.SuperTip = superToolTip1;
      this.btxtSearchResult.TextAlignment = System.Drawing.StringAlignment.Near;
      // 
      // bbnNuevoAlquilable
      // 
      this.bbnNuevoAlquilable.Caption = "Nuevo";
      this.bbnNuevoAlquilable.Id = 7;
      this.bbnNuevoAlquilable.LargeGlyph = global::HidUI.Properties.Resources.realvista_accounting_loan_48;
      this.bbnNuevoAlquilable.Name = "bbnNuevoAlquilable";
      // 
      // bbnEditAlquilable
      // 
      this.bbnEditAlquilable.Caption = "Modificar";
      this.bbnEditAlquilable.Glyph = ((System.Drawing.Image)(resources.GetObject("bbnEditAlquilable.Glyph")));
      this.bbnEditAlquilable.Id = 8;
      this.bbnEditAlquilable.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbnEditAlquilable.LargeGlyph")));
      this.bbnEditAlquilable.Name = "bbnEditAlquilable";
      // 
      // bbnBuscarAlquilable
      // 
      this.bbnBuscarAlquilable.Caption = "Buscar";
      this.bbnBuscarAlquilable.Glyph = ((System.Drawing.Image)(resources.GetObject("bbnBuscarAlquilable.Glyph")));
      this.bbnBuscarAlquilable.Id = 9;
      this.bbnBuscarAlquilable.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbnBuscarAlquilable.LargeGlyph")));
      this.bbnBuscarAlquilable.Name = "bbnBuscarAlquilable";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "PRUEBAS";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.bbnNuevoProveedor);
      this.ribbonPageGroup1.ItemLinks.Add(this.bbnEditProvedor);
      this.ribbonPageGroup1.ItemLinks.Add(this.bbnBuscarProveedor);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.Text = "Proveedores";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.bbnNuevoAlquilable);
      this.ribbonPageGroup2.ItemLinks.Add(this.bbnEditAlquilable);
      this.ribbonPageGroup2.ItemLinks.Add(this.bbnBuscarAlquilable);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "Alquilables";
      // 
      // ribbonStatusBar
      // 
      this.ribbonStatusBar.AutoHeight = true;
      this.ribbonStatusBar.ItemLinks.Add(this.btxtUsuario);
      this.ribbonStatusBar.ItemLinks.Add(this.btxtSearchResult);
      this.ribbonStatusBar.Location = new System.Drawing.Point(0, 495);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new System.Drawing.Size(876, 37);
      // 
      // txtHidden
      // 
      this.txtHidden.Location = new System.Drawing.Point(466, 396);
      this.txtHidden.Name = "txtHidden";
      this.txtHidden.Size = new System.Drawing.Size(272, 21);
      this.txtHidden.TabIndex = 5;
      this.txtHidden.TextChanged += new System.EventHandler(this.Hidden_TextChanged);
      // 
      // txtHiddenSearch
      // 
      this.txtHiddenSearch.Location = new System.Drawing.Point(466, 423);
      this.txtHiddenSearch.Name = "txtHiddenSearch";
      this.txtHiddenSearch.Size = new System.Drawing.Size(272, 21);
      this.txtHiddenSearch.TabIndex = 7;
      this.txtHiddenSearch.TextChanged += new System.EventHandler(this.Hidden_TextChanged);
      // 
      // panelControl1
      // 
      this.panelControl1.Controls.Add(this.labelControl1);
      this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panelControl1.Location = new System.Drawing.Point(0, 144);
      this.panelControl1.Name = "panelControl1";
      this.panelControl1.Size = new System.Drawing.Size(876, 351);
      this.panelControl1.TabIndex = 10;
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl1.Location = new System.Drawing.Point(102, 73);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(342, 115);
      this.labelControl1.TabIndex = 3;
      this.labelControl1.Text = "Esta ventana se utiliza unicamente para testear los diversos formularios de dialo" +
    "go. Se usan servicios para mostrar los diversos dialogos pero no tenemos navegab" +
    "ilidad de ningun tipo, ni login\r\n\r\n";
      // 
      // winTestUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(876, 532);
      this.Controls.Add(this.panelControl1);
      this.Controls.Add(this.txtHiddenSearch);
      this.Controls.Add(this.ribbonStatusBar);
      this.Controls.Add(this.txtHidden);
      this.Controls.Add(this.ribbon);
      this.Name = "winTestUI";
      this.Ribbon = this.ribbon;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Pruebas varias para diferentes vistas";
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
      this.panelControl1.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.BarButtonItem bbnNuevoProveedor;
    private DevExpress.XtraBars.BarButtonItem bbnEditProvedor;
    private DevExpress.XtraBars.BarButtonItem bbnBuscarProveedor;
    private DevExpress.XtraBars.BarStaticItem btxtUsuario;
    private DevExpress.XtraBars.BarStaticItem btxtSearchResult;
    private System.Windows.Forms.TextBox txtHidden;
    private System.Windows.Forms.TextBox txtHiddenSearch;
    private DevExpress.XtraBars.BarButtonItem bbnNuevoAlquilable;
    private DevExpress.XtraBars.BarButtonItem bbnEditAlquilable;
    private DevExpress.XtraBars.BarButtonItem bbnBuscarAlquilable;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraEditors.PanelControl panelControl1;
    private DevExpress.XtraEditors.LabelControl labelControl1;
  }
}