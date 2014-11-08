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
      this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.bbnNuevoProveedor = new DevExpress.XtraBars.BarButtonItem();
      this.bbnEditProvedor = new DevExpress.XtraBars.BarButtonItem();
      this.bbnBuscarProveedor = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.btxtUsuario = new DevExpress.XtraBars.BarStaticItem();
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
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
            this.btxtUsuario});
      this.ribbon.Location = new System.Drawing.Point(0, 0);
      this.ribbon.MaxItemId = 5;
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
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
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
      // ribbonStatusBar
      // 
      this.ribbonStatusBar.ItemLinks.Add(this.btxtUsuario);
      this.ribbonStatusBar.Location = new System.Drawing.Point(0, 501);
      this.ribbonStatusBar.Name = "ribbonStatusBar";
      this.ribbonStatusBar.Ribbon = this.ribbon;
      this.ribbonStatusBar.Size = new System.Drawing.Size(876, 31);
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
      this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl1.Location = new System.Drawing.Point(214, 235);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(342, 115);
      this.labelControl1.TabIndex = 2;
      this.labelControl1.Text = "Esta ventana se utiliza unicamente para testear los diversos formularios de dialo" +
    "go. Se usan servicios para mostrar los diversos dialogos pero no tenemos navegab" +
    "ilidad de ningun tipo, ni login\r\n\r\n";
      // 
      // btxtUsuario
      // 
      this.btxtUsuario.Caption = "<Desconectado>";
      this.btxtUsuario.Id = 4;
      this.btxtUsuario.Name = "btxtUsuario";
      this.btxtUsuario.TextAlignment = System.Drawing.StringAlignment.Near;
      // 
      // winTestUI
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(876, 532);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.ribbonStatusBar);
      this.Controls.Add(this.ribbon);
      this.Name = "winTestUI";
      this.Ribbon = this.ribbon;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.StatusBar = this.ribbonStatusBar;
      this.Text = "Pruebas varias para diferentes vistas";
      ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.XtraBars.BarButtonItem bbnNuevoProveedor;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraBars.BarButtonItem bbnEditProvedor;
    private DevExpress.XtraBars.BarButtonItem bbnBuscarProveedor;
    private DevExpress.XtraBars.BarStaticItem btxtUsuario;
  }
}