using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data.Finders;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Entidades;
using HidUI.ViewModel;
using Infraestructura;

namespace HidUI.Views
{
  public partial class winSimpleSearch<T> : DevExpress.XtraEditors.XtraForm
  {
    //  private SimpleSearchViewModel _vm;

    public winSimpleSearch()
    {
      InitializeComponent();
      //  _vm = ViewModelSource.Create(() => new SimpleSearchViewModel());

      lblEntityName.Text = typeof (T).Name;

      //  _vm.ViewMustClose += CloseEvent;

      //  BindCommands();
    }

    public T Resultado { get; private set; }

    //  public Proveedor Resultado { get; private set; }

    //  TODO considerar que puede ser una LISTA de resultados

    #region Event Handlers

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
  }
}