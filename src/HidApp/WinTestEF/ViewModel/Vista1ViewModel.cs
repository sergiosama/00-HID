using System;
using System.Diagnostics;
using DevExpress.Mvvm;

namespace WinTestEF.ViewModel
{
  //
  //  Este es un VM que pertenece a una NavigableView, no deberia tener algo que lo distinga?
  //  Si lo pensamos es similar o tiene bastantes similitudes con MainViewModel....
  public class Vista1ViewModel : ViewModelBase
  {
    private ViewType _selectedViewType;
    private object _selectedView;
    private readonly IViewLocator _locator;

    public Vista1ViewModel(IViewLocator locator)
    {
      //  ojo el IViewLocator deberia ser unico para toda la app!!!
      _locator = locator;
    }

    #region Eventos para avisar a la View

    public event EventHandler WorkViewAdded;
    public event EventHandler WorkViewRemoved;
    public event EventHandler SelectedWorkViewChanged;
    public event EventHandler SelectedWorkViewTypeChanged;

    #endregion

    public virtual ViewType SelectedWorkViewType { get; set; }

    public virtual object SelectedWorkView { get; set; }

    protected void OnSelectedWorkViewTypeChanged(ViewType oldType)
    {
      Debug.WriteLine("OnSelectedWorkViewTypeChanged: oldType = {0}", oldType);

      //  aca tenemos que ver si la vista en realidad necesita otra...
      //  lo tiene que decidir el locator
      SelectedWorkView = _locator.GetView(SelectedWorkViewType);
      //  RaiseSelectedViewTypeChanged()

      //  esto tambien es mio... si la vista es tipo navegador, los eventos de navegación deberian replicarse ....
    }

    protected void OnSelectedWorkViewChanged(object oldWorkView)
    {
      //  doy aviso a la vista que elimine o haga lo que quiera con la vista previa
      //  OJO: es solamente un remove VISUAL, si quisiera hacer algo para guardar el estado deberia hacerlo en el logout
      //
      if (oldWorkView != null)
      {
        if (WorkViewRemoved != null)
          WorkViewRemoved(oldWorkView, EventArgs.Empty);
      }
      //  deberia asegurarme que la view tenga la parent view correcta si le hace falta
      //  y que reciba los parametros necesarios
      //  Eso es lo que hace ViewModelHelper...

      //  por ultimo avisar a la vista principal que hay una nueva vista agregada...
      //  esto es lo que realmente la muestra!!
      if (WorkViewAdded != null)
        WorkViewAdded(SelectedWorkView, EventArgs.Empty);
    }

    public void SetCurrentWorkViewType(ViewType _vtActual)
    {
      SelectedWorkViewType = _vtActual;
    }

    public void SetDefaultView()
    {
      //  NO! Es una vista navegable tengo que ir  a la WV por defecto o la que ya estaba
      //  Helpers.MainForm.MainViewModel.NavigateTo(ViewType.StockInsumos);
      SelectedWorkViewType = ViewType.Pagina_1;
    }
  }
}
