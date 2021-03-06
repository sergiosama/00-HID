﻿using System;
using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using HidUI.Common;
using HidUI.ViewModel;

namespace HidUI.Views
{
  /// <summary>
  /// Vista que permite usar las paginas del ribbon para navegar entre diferentes sub-vistas o vistas de trabajo
  /// Ojo una vista navegable tiene muchas cosas en comun, posiblemente haya que hacer una clase base...
  /// </summary>
  public partial class NavegableView : XtraUserControl, ISupportRibbon, INavigableView
  {
    private readonly NavegableViewModel _viewModel;

    public static void RegisterViews()
    {
      ViewManager.Current.AddView(ViewType.StockInsumos, ViewType.Stock, null);
      ViewManager.Current.AddView(ViewType.StockAlquilables, ViewType.Stock, null);
      ViewManager.Current.AddView(ViewType.StockReportes, ViewType.Stock, null);
    }

    //  public static 
    public NavegableView(IViewLocator locator)
    {
      InitializeComponent();
      //  _viewModel = ViewModelSource.Create(() => new StockViewModel(new Localizador()));
      _viewModel = ViewModelSource.Create(() => new NavegableViewModel(locator));
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      //  TODO cambiar o arregar porque cuando reingreso con otro user no llama de nuevo a OnLoad!!
      //  TODO y eso no seria nada, el problema es que tambien puede pasar con el mismo user
      _viewModel.SetDefaultView();
    }


    #region Command Binding

    //  Tener en cuenta que por ahora tenemos todos los view models accesibles, luego deberiamos bindear solo los necesarios!!

    //  Eventos de cambio de pagina: asociarlos al view model para que cambie tambien

    #endregion



    public DevExpress.XtraBars.Ribbon.RibbonControl Ribbon
    {
      get { return this.ribView; }
    }

    public void SetMainRibbon(RibbonControl ribbon)
    {
      throw new NotImplementedException();
    }

    public void BindEvents()
    {
      throw new NotImplementedException();
    }

    public void FocusOnPage()
    {
      throw new NotImplementedException();
    }

    public void FocusOnPage(DevExpress.XtraBars.Ribbon.RibbonControl ribbon)
    {
      //  ojo: guardar donde estaba posicionado...
      //
      //  ribbon.SelectedPage = ribStock.Pages["INSUMOS"];
      ribbon.SelectedPage = ribView.Pages["PAGINA 1"];
    }

    /// <summary>
    /// Antes de abandonar la vista navegable, tengo que guardar el estado de donde estaba
    /// </summary>
    public void SaveVisualState()
    {
      
    }

    /// <summary>
    /// Cuando la vista navegable vuelve a estar activa
    /// </summary>
    public void RestoreVisualState()
    {
      
    }

    public void SetContainer(Control ctrl)
    {
      throw new NotImplementedException();
    }

    public void UnsetContainer()
    {
      throw new NotImplementedException();
    }
  }
}
