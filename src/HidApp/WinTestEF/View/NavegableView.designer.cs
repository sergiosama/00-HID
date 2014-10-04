namespace WinTestEF.View
{
  partial class NavegableView
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavegableView));
      this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.bbnPagina2 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      this.bbnPagina1 = new DevExpress.XtraBars.BarButtonItem();
      this.ribView = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.barButtonItem7 = new DevExpress.XtraBars.BarButtonItem();
      this.barButtonItem10 = new DevExpress.XtraBars.BarButtonItem();
      ((System.ComponentModel.ISupportInitialize)(this.ribView)).BeginInit();
      this.SuspendLayout();
      // 
      // ribbonPage4
      // 
      this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
      this.ribbonPage4.Name = "ribbonPage4";
      this.ribbonPage4.Text = "PAGINA 3";
      // 
      // ribbonPageGroup4
      // 
      this.ribbonPageGroup4.Name = "ribbonPageGroup4";
      this.ribbonPageGroup4.Text = "ribbonPageGroup4";
      // 
      // ribbonPage2
      // 
      this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
      this.ribbonPage2.Name = "ribbonPage2";
      this.ribbonPage2.Tag = "View";
      this.ribbonPage2.Text = "PAGINA 2";
      // 
      // ribbonPageGroup2
      // 
      this.ribbonPageGroup2.ItemLinks.Add(this.bbnPagina2);
      this.ribbonPageGroup2.Name = "ribbonPageGroup2";
      this.ribbonPageGroup2.Text = "Acciones";
      // 
      // bbnPagina2
      // 
      this.bbnPagina2.Caption = "Nuevo";
      this.bbnPagina2.Glyph = ((System.Drawing.Image)(resources.GetObject("bbnPagina2.Glyph")));
      this.bbnPagina2.Id = 2;
      this.bbnPagina2.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbnPagina2.LargeGlyph")));
      this.bbnPagina2.Name = "bbnPagina2";
      // 
      // barButtonItem3
      // 
      this.barButtonItem3.Caption = "Devolución";
      this.barButtonItem3.Glyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.Glyph")));
      this.barButtonItem3.Id = 3;
      this.barButtonItem3.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.LargeGlyph")));
      this.barButtonItem3.Name = "barButtonItem3";
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "PAGINA 1";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.ItemLinks.Add(this.bbnPagina1);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      // 
      // bbnPagina1
      // 
      this.bbnPagina1.Caption = "Nuevo";
      this.bbnPagina1.Glyph = ((System.Drawing.Image)(resources.GetObject("bbnPagina1.Glyph")));
      this.bbnPagina1.Id = 1;
      this.bbnPagina1.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbnPagina1.LargeGlyph")));
      this.bbnPagina1.Name = "bbnPagina1";
      // 
      // ribView
      // 
      this.ribView.ExpandCollapseItem.Id = 0;
      this.ribView.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribView.ExpandCollapseItem,
            this.bbnPagina1,
            this.bbnPagina2,
            this.barButtonItem3,
            this.barButtonItem7,
            this.barButtonItem10});
      this.ribView.Location = new System.Drawing.Point(0, 0);
      this.ribView.MaxItemId = 12;
      this.ribView.Name = "ribView";
      this.ribView.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage4});
      this.ribView.Size = new System.Drawing.Size(765, 142);
      // 
      // barButtonItem7
      // 
      this.barButtonItem7.Caption = "barButtonItem7";
      this.barButtonItem7.Id = 7;
      this.barButtonItem7.Name = "barButtonItem7";
      // 
      // barButtonItem10
      // 
      this.barButtonItem10.Id = 11;
      this.barButtonItem10.Name = "barButtonItem10";
      // 
      // NavegableView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ribView);
      this.Name = "NavegableView";
      this.Size = new System.Drawing.Size(765, 593);
      ((System.ComponentModel.ISupportInitialize)(this.ribView)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribView;

    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;

    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;

    private DevExpress.XtraBars.BarButtonItem bbnPagina1;
    private DevExpress.XtraBars.BarButtonItem bbnPagina2;
    private DevExpress.XtraBars.BarButtonItem barButtonItem3;
    private DevExpress.XtraBars.BarButtonItem barButtonItem7;
    private DevExpress.XtraBars.BarButtonItem barButtonItem10;

  }
}
