namespace HidUI.Views
{
  partial class winSimpleSearch<T>
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
      this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
      this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
      this.txtSearch = new DevExpress.XtraEditors.TextEdit();
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.lblEntityName = new DevExpress.XtraEditors.LabelControl();
      ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
      this.SuspendLayout();
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
      this.btnSearch.Appearance.Options.UseFont = true;
      this.btnSearch.Location = new System.Drawing.Point(431, 122);
      this.btnSearch.Margin = new System.Windows.Forms.Padding(10);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(120, 40);
      this.btnSearch.TabIndex = 7;
      this.btnSearch.Text = "Buscar";
      this.btnSearch.Click += new System.EventHandler(this.Buscar_OnClick);
      // 
      // btnCancelar
      // 
      this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCancelar.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.btnCancelar.Appearance.Options.UseFont = true;
      this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancelar.Location = new System.Drawing.Point(291, 122);
      this.btnCancelar.Margin = new System.Windows.Forms.Padding(10);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(120, 40);
      this.btnCancelar.TabIndex = 9;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.Click += new System.EventHandler(this.Cancelar_OnClick);
      // 
      // txtSearch
      // 
      this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSearch.Location = new System.Drawing.Point(14, 69);
      this.txtSearch.Margin = new System.Windows.Forms.Padding(10);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.txtSearch.Properties.Appearance.Options.UseFont = true;
      this.txtSearch.Size = new System.Drawing.Size(537, 24);
      this.txtSearch.TabIndex = 19;
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
      this.labelControl1.Location = new System.Drawing.Point(14, 26);
      this.labelControl1.Margin = new System.Windows.Forms.Padding(10);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(47, 17);
      this.labelControl1.TabIndex = 20;
      this.labelControl1.Text = "Buscar...";
      // 
      // lblEntityName
      // 
      this.lblEntityName.Appearance.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
      this.lblEntityName.Location = new System.Drawing.Point(81, 19);
      this.lblEntityName.Margin = new System.Windows.Forms.Padding(10);
      this.lblEntityName.Name = "lblEntityName";
      this.lblEntityName.Size = new System.Drawing.Size(105, 30);
      this.lblEntityName.TabIndex = 21;
      this.lblEntityName.Text = "<Entidad>";
      // 
      // winSimpleSearch
      // 
      this.AcceptButton = this.btnSearch;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancelar;
      this.ClientSize = new System.Drawing.Size(570, 181);
      this.Controls.Add(this.lblEntityName);
      this.Controls.Add(this.txtSearch);
      this.Controls.Add(this.labelControl1);
      this.Controls.Add(this.btnSearch);
      this.Controls.Add(this.btnCancelar);
      this.Name = "winSimpleSearch";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Busqueda Simple de Entidad";
      ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private DevExpress.XtraEditors.SimpleButton btnSearch;
    private DevExpress.XtraEditors.SimpleButton btnCancelar;
    private DevExpress.XtraEditors.TextEdit txtSearch;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.LabelControl lblEntityName;
  }
}