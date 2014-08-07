namespace Maquetas.Views
{
  partial class AboutView
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutView));
      DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
      DevExpress.Utils.ToolTipTitleItem toolTipTitleItem1 = new DevExpress.Utils.ToolTipTitleItem();
      DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
      this.imageSlider1 = new DevExpress.XtraEditors.Controls.ImageSlider();
      this.ribAbout = new DevExpress.XtraBars.Ribbon.RibbonControl();
      this.bbiCloseAbout = new DevExpress.XtraBars.BarButtonItem();
      this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
      this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
      ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribAbout)).BeginInit();
      this.SuspendLayout();
      // 
      // imageSlider1
      // 
      this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images"))));
      this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images1"))));
      this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images2"))));
      this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images3"))));
      this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images4"))));
      this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images5"))));
      this.imageSlider1.Images.Add(((System.Drawing.Image)(resources.GetObject("imageSlider1.Images6"))));
      this.imageSlider1.LayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.Stretch;
      this.imageSlider1.Location = new System.Drawing.Point(13, 148);
      this.imageSlider1.Name = "imageSlider1";
      this.imageSlider1.Size = new System.Drawing.Size(189, 184);
      this.imageSlider1.TabIndex = 0;
      this.imageSlider1.Text = "imageSlider1";
      // 
      // ribAbout
      // 
      this.ribAbout.ExpandCollapseItem.Id = 0;
      this.ribAbout.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribAbout.ExpandCollapseItem,
            this.bbiCloseAbout});
      this.ribAbout.Location = new System.Drawing.Point(0, 0);
      this.ribAbout.MaxItemId = 2;
      this.ribAbout.Name = "ribAbout";
      this.ribAbout.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
      this.ribAbout.Size = new System.Drawing.Size(468, 142);
      this.ribAbout.PageGroupCaptionButtonClick += new DevExpress.XtraBars.Ribbon.RibbonPageGroupEventHandler(this.PageClick);
      this.ribAbout.SelectedPageChanged += new System.EventHandler(this.SelectedPage_Changed);
      // 
      // bbiCloseAbout
      // 
      this.bbiCloseAbout.Caption = "Cerrar";
      this.bbiCloseAbout.Glyph = ((System.Drawing.Image)(resources.GetObject("bbiCloseAbout.Glyph")));
      this.bbiCloseAbout.Id = 1;
      this.bbiCloseAbout.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("bbiCloseAbout.LargeGlyph")));
      this.bbiCloseAbout.Name = "bbiCloseAbout";
      toolTipTitleItem1.Text = "Acerca de la aplicación...";
      toolTipItem1.LeftIndent = 6;
      toolTipItem1.Text = "Quita esta pantalla y vuelve a la ventana principal";
      superToolTip1.Items.Add(toolTipTitleItem1);
      superToolTip1.Items.Add(toolTipItem1);
      this.bbiCloseAbout.SuperTip = superToolTip1;
      // 
      // ribbonPage1
      // 
      this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
      this.ribbonPage1.MergeOrder = 0;
      this.ribbonPage1.Name = "ribbonPage1";
      this.ribbonPage1.Text = "ACERCA DE";
      // 
      // ribbonPageGroup1
      // 
      this.ribbonPageGroup1.AllowTextClipping = false;
      this.ribbonPageGroup1.ItemLinks.Add(this.bbiCloseAbout);
      this.ribbonPageGroup1.Name = "ribbonPageGroup1";
      this.ribbonPageGroup1.ShowCaptionButton = false;
      // 
      // AboutView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.ribAbout);
      this.Controls.Add(this.imageSlider1);
      this.Name = "AboutView";
      this.Size = new System.Drawing.Size(468, 517);
      this.Load += new System.EventHandler(this.AboutView_OnLoad);
      ((System.ComponentModel.ISupportInitialize)(this.imageSlider1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.ribAbout)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.Controls.ImageSlider imageSlider1;
    private DevExpress.XtraBars.Ribbon.RibbonControl ribAbout;
    private DevExpress.XtraBars.BarButtonItem bbiCloseAbout;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
  }
}
