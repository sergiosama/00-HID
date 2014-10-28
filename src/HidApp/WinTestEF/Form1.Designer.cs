namespace WinTestEF
{
  partial class Form1
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtApellido = new DevExpress.XtraEditors.TextEdit();
            this.txtNombre = new DevExpress.XtraEditors.TextEdit();
            this.btnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.grdRecursos = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.picActual = new System.Windows.Forms.PictureBox();
            this.bedtSelectImage = new DevExpress.XtraEditors.ButtonEdit();
            this.lstRecursos = new DevExpress.XtraEditors.LookUpEdit();
            this.dlgOpenImage = new System.Windows.Forms.OpenFileDialog();
            this.bsrc = new System.Windows.Forms.BindingSource();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecursos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedtSelectImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstRecursos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUpdate.Appearance.Options.UseFont = true;
            this.btnUpdate.Location = new System.Drawing.Point(461, 332);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 30);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.Update_Click);
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xtraTabControl1.Location = new System.Drawing.Point(19, 19);
            this.xtraTabControl1.Margin = new System.Windows.Forms.Padding(10);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(608, 417);
            this.xtraTabControl1.TabIndex = 2;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.Header.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xtraTabPage1.Appearance.Header.Options.UseFont = true;
            this.xtraTabPage1.Controls.Add(this.pictureEdit1);
            this.xtraTabPage1.Controls.Add(this.comboBoxEdit1);
            this.xtraTabPage1.Controls.Add(this.textEdit4);
            this.xtraTabPage1.Controls.Add(this.textEdit3);
            this.xtraTabPage1.Controls.Add(this.textEdit2);
            this.xtraTabPage1.Controls.Add(this.labelControl7);
            this.xtraTabPage1.Controls.Add(this.labelControl6);
            this.xtraTabPage1.Controls.Add(this.labelControl5);
            this.xtraTabPage1.Controls.Add(this.textEdit1);
            this.xtraTabPage1.Controls.Add(this.labelControl4);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.txtApellido);
            this.xtraTabPage1.Controls.Add(this.txtNombre);
            this.xtraTabPage1.Controls.Add(this.btnUndo);
            this.xtraTabPage1.Controls.Add(this.grdRecursos);
            this.xtraTabPage1.Controls.Add(this.btnUpdate);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.picActual);
            this.xtraTabPage1.Controls.Add(this.bedtSelectImage);
            this.xtraTabPage1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Padding = new System.Windows.Forms.Padding(20);
            this.xtraTabPage1.Size = new System.Drawing.Size(601, 385);
            this.xtraTabPage1.Text = "Editar Recursos";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(110, 167);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxEdit1.Properties.Appearance.Options.UseFont = true;
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(248, 24);
            this.comboBoxEdit1.TabIndex = 22;
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(176, 209);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Size = new System.Drawing.Size(182, 24);
            this.textEdit4.TabIndex = 21;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(176, 247);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Size = new System.Drawing.Size(177, 24);
            this.textEdit3.TabIndex = 20;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(176, 277);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Size = new System.Drawing.Size(169, 24);
            this.textEdit2.TabIndex = 19;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl7.Location = new System.Drawing.Point(10, 278);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(54, 17);
            this.labelControl7.TabIndex = 18;
            this.labelControl7.Text = "Matricula";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl6.Location = new System.Drawing.Point(10, 241);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(54, 17);
            this.labelControl6.TabIndex = 17;
            this.labelControl6.Text = "Matricula";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl5.Location = new System.Drawing.Point(23, 170);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 17);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "Matricula";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(110, 137);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(248, 24);
            this.textEdit1.TabIndex = 15;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl4.Location = new System.Drawing.Point(23, 140);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(54, 17);
            this.labelControl4.TabIndex = 14;
            this.labelControl4.Text = "Matricula";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl3.Location = new System.Drawing.Point(23, 107);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 17);
            this.labelControl3.TabIndex = 13;
            this.labelControl3.Text = "Apellido";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl1.Location = new System.Drawing.Point(23, 74);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(49, 17);
            this.labelControl1.TabIndex = 12;
            this.labelControl1.Text = "Nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(110, 104);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtApellido.Properties.Appearance.Options.UseFont = true;
            this.txtApellido.Size = new System.Drawing.Size(248, 24);
            this.txtApellido.TabIndex = 11;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(110, 71);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtNombre.Properties.Appearance.Options.UseFont = true;
            this.txtNombre.Size = new System.Drawing.Size(248, 24);
            this.txtNombre.TabIndex = 10;
            // 
            // btnUndo
            // 
            this.btnUndo.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnUndo.Appearance.Options.UseFont = true;
            this.btnUndo.Enabled = false;
            this.btnUndo.Location = new System.Drawing.Point(332, 332);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(110, 30);
            this.btnUndo.TabIndex = 9;
            this.btnUndo.Text = "Deshacer";
            this.btnUndo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // grdRecursos
            // 
            this.grdRecursos.Location = new System.Drawing.Point(167, 27);
            this.grdRecursos.Name = "grdRecursos";
            this.grdRecursos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grdRecursos.Properties.Appearance.Options.UseFont = true;
            this.grdRecursos.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grdRecursos.Properties.AppearanceDropDown.Options.UseFont = true;
            this.grdRecursos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.grdRecursos.Properties.NullText = "";
            this.grdRecursos.Properties.View = this.gridLookUpEdit1View;
            this.grdRecursos.Size = new System.Drawing.Size(404, 24);
            this.grdRecursos.TabIndex = 8;
            this.grdRecursos.EditValueChanged += new System.EventHandler(this.Recursos_EditValueChanged);
            this.grdRecursos.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.Recursos_CustomDisplayText);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEdit1View.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridLookUpEdit1View.Appearance.Row.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gridLookUpEdit1View.Appearance.Row.Options.UseFont = true;
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelControl2.Location = new System.Drawing.Point(30, 30);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(10);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(117, 17);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Seleccionar Recurso";
            // 
            // picActual
            // 
            this.picActual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picActual.Location = new System.Drawing.Point(371, 71);
            this.picActual.Margin = new System.Windows.Forms.Padding(10);
            this.picActual.Name = "picActual";
            this.picActual.Size = new System.Drawing.Size(200, 200);
            this.picActual.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picActual.TabIndex = 2;
            this.picActual.TabStop = false;
            // 
            // bedtSelectImage
            // 
            this.bedtSelectImage.Enabled = false;
            this.bedtSelectImage.Location = new System.Drawing.Point(371, 294);
            this.bedtSelectImage.Margin = new System.Windows.Forms.Padding(10);
            this.bedtSelectImage.Name = "bedtSelectImage";
            this.bedtSelectImage.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bedtSelectImage.Properties.Appearance.Options.UseFont = true;
            this.bedtSelectImage.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "Seleccionar una nueva imagen desde un archivo", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "Eliminar la imagen actual", null, null, true)});
            this.bedtSelectImage.Properties.ReadOnly = true;
            this.bedtSelectImage.Size = new System.Drawing.Size(200, 24);
            this.bedtSelectImage.TabIndex = 0;
            this.bedtSelectImage.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.SeleccionarImagen_ButtonClick);
            // 
            // lstRecursos
            // 
            this.lstRecursos.EditValue = "";
            this.lstRecursos.Location = new System.Drawing.Point(21, 446);
            this.lstRecursos.Name = "lstRecursos";
            this.lstRecursos.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstRecursos.Properties.Appearance.Options.UseFont = true;
            this.lstRecursos.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstRecursos.Properties.AppearanceDropDown.Options.UseFont = true;
            this.lstRecursos.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstRecursos.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.lstRecursos.Properties.AppearanceFocused.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstRecursos.Properties.AppearanceFocused.Options.UseFont = true;
            this.lstRecursos.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            this.lstRecursos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lstRecursos.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Apellido", 150, "apellido"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", 200, "Nombre"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Categoria.Detalle", "Funcion/Especialidad")});
            this.lstRecursos.Size = new System.Drawing.Size(278, 24);
            this.lstRecursos.TabIndex = 8;
            this.lstRecursos.FormatEditValue += new DevExpress.XtraEditors.Controls.ConvertEditValueEventHandler(this.ListaEditValue);
            // 
            // dlgOpenImage
            // 
            this.dlgOpenImage.FileName = "openFileDialog1";
            this.dlgOpenImage.Title = "Seleccionar un archivo de imagen";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Location = new System.Drawing.Point(70, 286);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Size = new System.Drawing.Size(100, 96);
            this.pictureEdit1.TabIndex = 23;
            this.pictureEdit1.PopupMenuShowing += new DevExpress.XtraEditors.Events.PopupMenuShowingEventHandler(this.pictureEdit1_PopupMenuShowing);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 489);
            this.Controls.Add(this.lstRecursos);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.LookAndFeel.SkinName = "Caramel";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tareas HID";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TareasHID_Closed);
            this.Load += new System.EventHandler(this.TareasHID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNombre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdRecursos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bedtSelectImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lstRecursos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsrc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.SimpleButton btnUpdate;
    private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
    private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    private DevExpress.XtraEditors.LabelControl labelControl2;
    private System.Windows.Forms.PictureBox picActual;
    private DevExpress.XtraEditors.ButtonEdit bedtSelectImage;
    private DevExpress.XtraEditors.LookUpEdit lstRecursos;
    private DevExpress.XtraEditors.GridLookUpEdit grdRecursos;
    private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    private System.Windows.Forms.OpenFileDialog dlgOpenImage;
    private DevExpress.XtraEditors.SimpleButton btnUndo;
    private DevExpress.XtraEditors.TextEdit txtApellido;
    private DevExpress.XtraEditors.TextEdit txtNombre;
    private System.Windows.Forms.BindingSource bsrc;
    private DevExpress.XtraEditors.TextEdit textEdit1;
    private DevExpress.XtraEditors.LabelControl labelControl4;
    private DevExpress.XtraEditors.LabelControl labelControl3;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    private DevExpress.XtraEditors.TextEdit textEdit4;
    private DevExpress.XtraEditors.TextEdit textEdit3;
    private DevExpress.XtraEditors.TextEdit textEdit2;
    private DevExpress.XtraEditors.LabelControl labelControl7;
    private DevExpress.XtraEditors.LabelControl labelControl6;
    private DevExpress.XtraEditors.LabelControl labelControl5;
    private DevExpress.XtraEditors.PictureEdit pictureEdit1;

  }
}

