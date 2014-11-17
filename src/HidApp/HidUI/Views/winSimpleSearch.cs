using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Entidades;
using HidUI.ViewModel;
using Infraestructura;
using Servicios.Finders;

namespace HidUI.Views
{
  //
  //  No voy a usar VM en esta vista porque creo que no va a aparecer nunca en la UI final (solo es de prueba)
  //
  public partial class winSimpleSearch<T> : DevExpress.XtraEditors.XtraForm where T: class 
  {
    //  private SimpleSearchViewModel _vm;

    public winSimpleSearch()
    {
      InitializeComponent();
      //  _vm = ViewModelSource.Create(() => new SimpleSearchViewModel());

      lblEntityName.Text = typeof (T).Name;

      //  _vm.ViewMustClose += CloseEvent;

      //  BindCommands();
      Resultado = null;
    }

    public T Resultado { get; private set; }

    //  TODO considerar que puede ser una LISTA de resultados

    #region Event Handlers

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      txtSearch.Focus();
    }

    private void Buscar_OnClick(object sender, EventArgs e)
    {
      IFinder<T> search = FinderFactory.CreateFinder<T>();

      T result = search.FindByText(txtSearch.Text);

      if (result != null)
      {
        Resultado = result;
        this.Close();
      }
    }

    private void Cancelar_OnClick(object sender, EventArgs e)
    {
      this.Close();
    }

    private void CloseEvent(object sender, EventArgs args)
    {
      this.Close();
    }

    //private void ErrorEvent(object sender, IList<HidErrorInfo> args)
    //{
    //  StringBuilder sb = new StringBuilder();

    //  foreach (var err in args)
    //    sb.AppendLine(err.Descripcion);

    //  MessageBox.Show(sb.ToString(), "ERROR EN EL INGRESO DE DATOS", MessageBoxButtons.OK, MessageBoxIcon.Error);
    //}

    #endregion

    private void BindCommands()
    {
      //  btnSearch.BindCommand(() => _vm.Search(), _vm);
    }
  }
}