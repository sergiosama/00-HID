namespace HidUI.Views
{
    partial class PacientesView
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
            this.tcPacientes = new DevExpress.XtraTab.XtraTabControl();
            this.tpPaciente = new DevExpress.XtraTab.XtraTabPage();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.cbIdTipoDocumento = new DevExpress.XtraEditors.ComboBoxEdit();
            this.teNroObraSocial = new DevExpress.XtraEditors.TextEdit();
            this.teNroDni = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.teApellido = new DevExpress.XtraEditors.TextEdit();
            this.cbPlan = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.teNombres = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.teCalle = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.cbIdObraSocial = new DevExpress.XtraEditors.ComboBoxEdit();
            this.tpHistorico = new DevExpress.XtraTab.XtraTabPage();
            this.tpCtacte = new DevExpress.XtraTab.XtraTabPage();
            this.gcCuentas = new DevExpress.XtraGrid.GridControl();
            this.gvCuentas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gleCategorias = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.tcPacientes)).BeginInit();
            this.tcPacientes.SuspendLayout();
            this.tpPaciente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdTipoDocumento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNroObraSocial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNroDni.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teApellido.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCalle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdObraSocial.Properties)).BeginInit();
            this.tpHistorico.SuspendLayout();
            this.tpCtacte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCuentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleCategorias.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPacientes
            // 
            this.tcPacientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPacientes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcPacientes.Location = new System.Drawing.Point(4, 4);
            this.tcPacientes.Margin = new System.Windows.Forms.Padding(4);
            this.tcPacientes.Name = "tcPacientes";
            this.tcPacientes.SelectedTabPage = this.tpPaciente;
            this.tcPacientes.Size = new System.Drawing.Size(878, 532);
            this.tcPacientes.TabIndex = 0;
            this.tcPacientes.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.tpPaciente,
            this.tpHistorico,
            this.tpCtacte});
            // 
            // tpPaciente
            // 
            this.tpPaciente.Controls.Add(this.splitContainerControl1);
            this.tpPaciente.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpPaciente.Margin = new System.Windows.Forms.Padding(4);
            this.tpPaciente.Name = "tpPaciente";
            this.tpPaciente.Size = new System.Drawing.Size(872, 504);
            this.tpPaciente.Text = "Datos Paciente";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.memoEdit1);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl8);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbIdTipoDocumento);
            this.splitContainerControl1.Panel1.Controls.Add(this.teNroObraSocial);
            this.splitContainerControl1.Panel1.Controls.Add(this.teNroDni);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl7);
            this.splitContainerControl1.Panel1.Controls.Add(this.teApellido);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbPlan);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl1);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl6);
            this.splitContainerControl1.Panel1.Controls.Add(this.teNombres);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl5);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl2);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.teCalle);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl3);
            this.splitContainerControl1.Panel1.Controls.Add(this.cbIdObraSocial);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.gleCategorias);
            this.splitContainerControl1.Panel2.Controls.Add(this.labelControl9);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(872, 504);
            this.splitContainerControl1.SplitterPosition = 429;
            this.splitContainerControl1.TabIndex = 15;
            this.splitContainerControl1.Text = "splitContainerControl1";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Location = new System.Drawing.Point(121, 262);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.memoEdit1.Properties.Appearance.Options.UseFont = true;
            this.memoEdit1.Size = new System.Drawing.Size(294, 132);
            this.memoEdit1.TabIndex = 17;
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl8.Location = new System.Drawing.Point(24, 262);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(74, 17);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Comentarios";
            // 
            // cbIdTipoDocumento
            // 
            this.cbIdTipoDocumento.Location = new System.Drawing.Point(121, 23);
            this.cbIdTipoDocumento.Margin = new System.Windows.Forms.Padding(4);
            this.cbIdTipoDocumento.Name = "cbIdTipoDocumento";
            this.cbIdTipoDocumento.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbIdTipoDocumento.Properties.Appearance.Options.UseFont = true;
            this.cbIdTipoDocumento.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdTipoDocumento.Size = new System.Drawing.Size(73, 24);
            this.cbIdTipoDocumento.TabIndex = 3;
            // 
            // teNroObraSocial
            // 
            this.teNroObraSocial.Location = new System.Drawing.Point(121, 211);
            this.teNroObraSocial.Margin = new System.Windows.Forms.Padding(4);
            this.teNroObraSocial.Name = "teNroObraSocial";
            this.teNroObraSocial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teNroObraSocial.Properties.Appearance.Options.UseFont = true;
            this.teNroObraSocial.Size = new System.Drawing.Size(294, 24);
            this.teNroObraSocial.TabIndex = 14;
            // 
            // teNroDni
            // 
            this.teNroDni.Location = new System.Drawing.Point(201, 23);
            this.teNroDni.Margin = new System.Windows.Forms.Padding(4);
            this.teNroDni.Name = "teNroDni";
            this.teNroDni.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teNroDni.Properties.Appearance.Options.UseFont = true;
            this.teNroDni.Properties.Mask.EditMask = "f0";
            this.teNroDni.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.teNroDni.Size = new System.Drawing.Size(214, 24);
            this.teNroDni.TabIndex = 0;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl7.Location = new System.Drawing.Point(24, 218);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(53, 17);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Nro. O.S.";
            // 
            // teApellido
            // 
            this.teApellido.Location = new System.Drawing.Point(121, 57);
            this.teApellido.Margin = new System.Windows.Forms.Padding(4);
            this.teApellido.Name = "teApellido";
            this.teApellido.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teApellido.Properties.Appearance.Options.UseFont = true;
            this.teApellido.Size = new System.Drawing.Size(294, 24);
            this.teApellido.TabIndex = 1;
            // 
            // cbPlan
            // 
            this.cbPlan.Location = new System.Drawing.Point(273, 165);
            this.cbPlan.Margin = new System.Windows.Forms.Padding(4);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbPlan.Properties.Appearance.Options.UseFont = true;
            this.cbPlan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbPlan.Size = new System.Drawing.Size(142, 24);
            this.cbPlan.TabIndex = 12;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(23, 64);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 17);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Apellido";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(23, 30);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(90, 17);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "Tipo  Nro. Doc.";
            // 
            // teNombres
            // 
            this.teNombres.Location = new System.Drawing.Point(121, 91);
            this.teNombres.Margin = new System.Windows.Forms.Padding(4);
            this.teNombres.Name = "teNombres";
            this.teNombres.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teNombres.Properties.Appearance.Options.UseFont = true;
            this.teNombres.Size = new System.Drawing.Size(294, 24);
            this.teNombres.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl5.Location = new System.Drawing.Point(23, 132);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(54, 17);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "Dirección";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl2.Location = new System.Drawing.Point(23, 98);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(55, 17);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Nombres";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl4.Location = new System.Drawing.Point(241, 172);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 17);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "Plan";
            // 
            // teCalle
            // 
            this.teCalle.Location = new System.Drawing.Point(121, 125);
            this.teCalle.Margin = new System.Windows.Forms.Padding(4);
            this.teCalle.Name = "teCalle";
            this.teCalle.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.teCalle.Properties.Appearance.Options.UseFont = true;
            this.teCalle.Size = new System.Drawing.Size(294, 24);
            this.teCalle.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.labelControl3.Location = new System.Drawing.Point(23, 172);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 17);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Obra Social";
            // 
            // cbIdObraSocial
            // 
            this.cbIdObraSocial.Location = new System.Drawing.Point(121, 165);
            this.cbIdObraSocial.Margin = new System.Windows.Forms.Padding(4);
            this.cbIdObraSocial.Name = "cbIdObraSocial";
            this.cbIdObraSocial.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.cbIdObraSocial.Properties.Appearance.Options.UseFont = true;
            this.cbIdObraSocial.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbIdObraSocial.Size = new System.Drawing.Size(112, 24);
            this.cbIdObraSocial.TabIndex = 7;
            // 
            // tpHistorico
            // 
            this.tpHistorico.Controls.Add(this.gridControl1);
            this.tpHistorico.Margin = new System.Windows.Forms.Padding(4);
            this.tpHistorico.Name = "tpHistorico";
            this.tpHistorico.Size = new System.Drawing.Size(872, 504);
            this.tpHistorico.Text = "Historial";
            // 
            // tpCtacte
            // 
            this.tpCtacte.Controls.Add(this.gcCuentas);
            this.tpCtacte.Margin = new System.Windows.Forms.Padding(4);
            this.tpCtacte.Name = "tpCtacte";
            this.tpCtacte.Size = new System.Drawing.Size(872, 504);
            this.tpCtacte.Text = "Estado de cuenta";
            // 
            // gcCuentas
            // 
            this.gcCuentas.Cursor = System.Windows.Forms.Cursors.Default;
            this.gcCuentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCuentas.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.gcCuentas.Location = new System.Drawing.Point(0, 0);
            this.gcCuentas.MainView = this.gvCuentas;
            this.gcCuentas.Margin = new System.Windows.Forms.Padding(4);
            this.gcCuentas.Name = "gcCuentas";
            this.gcCuentas.Size = new System.Drawing.Size(872, 504);
            this.gcCuentas.TabIndex = 0;
            this.gcCuentas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCuentas});
            // 
            // gvCuentas
            // 
            this.gvCuentas.GridControl = this.gcCuentas;
            this.gvCuentas.Name = "gvCuentas";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tcPacientes, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.76923F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.230769F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(886, 595);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(10, 4);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(122, 30);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Prestaciones";
            // 
            // gridControl1
            // 
            this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(872, 504);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // gleCategorias
            // 
            this.gleCategorias.Location = new System.Drawing.Point(10, 41);
            this.gleCategorias.Name = "gleCategorias";
            this.gleCategorias.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gleCategorias.Properties.Appearance.Options.UseFont = true;
            this.gleCategorias.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gleCategorias.Properties.View = this.gridLookUpEdit1View;
            this.gleCategorias.Size = new System.Drawing.Size(257, 24);
            this.gleCategorias.TabIndex = 13;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // PacientesView
            // 
            this.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PacientesView";
            this.Size = new System.Drawing.Size(886, 595);
            ((System.ComponentModel.ISupportInitialize)(this.tcPacientes)).EndInit();
            this.tcPacientes.ResumeLayout(false);
            this.tpPaciente.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdTipoDocumento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNroObraSocial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNroDni.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teApellido.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbPlan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teNombres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCalle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbIdObraSocial.Properties)).EndInit();
            this.tpHistorico.ResumeLayout(false);
            this.tpCtacte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCuentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCuentas)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gleCategorias.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl tcPacientes;
        private DevExpress.XtraTab.XtraTabPage tpPaciente;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit cbIdObraSocial;
        private DevExpress.XtraEditors.TextEdit teCalle;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit teNombres;
        private DevExpress.XtraEditors.ComboBoxEdit cbIdTipoDocumento;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit teApellido;
        private DevExpress.XtraEditors.TextEdit teNroDni;
        private DevExpress.XtraTab.XtraTabPage tpHistorico;
        private DevExpress.XtraTab.XtraTabPage tpCtacte;
        private DevExpress.XtraGrid.GridControl gcCuentas;
        private DevExpress.XtraGrid.Views.Grid.GridView gvCuentas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.TextEdit teNroObraSocial;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.ComboBoxEdit cbPlan;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.GridLookUpEdit gleCategorias;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}
