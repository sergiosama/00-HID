using System;
using DevExpress.Mvvm;
using HidUI.Common;

namespace HidUI.ViewModel
{
  //
  //  Este es un VM que pertenece a una NavigableView, no deberia tener algo que lo distinga?
  //  Si lo pensamos es similar o tiene bastantes similitudes con MainViewModel....
  public class StockViewModel : ViewModelBase
  {
    private ViewType _selectedViewType;
    private object _selectedView;
    private readonly IViewLocator _locator;

    public StockViewModel(IViewLocator locator)
    {
      //  ojo el IViewLocator deberia ser unico para toda la app!!!
    }

    #region Eventos para avisar a la View

    public event EventHandler WorkViewAdded;
    public event EventHandler WorkViewRemoved;
    public event EventHandler SelectedWorkViewChanged;
    public event EventHandler SelectedWorkViewTypeChanged;

    #endregion

    public virtual ViewType SelectedWorkViewType { get; set; }

    public virtual object SelectedWorkView { get; set; }



    public void SetDefaultView()
    {
      Helpers.MainForm.MainViewModel.NavigateTo(ViewType.StockInsumos);
    }
  }
}
