using System;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using HidUI.Common;
using HidUI.ViewModel;

namespace HidUI.Views
{
  /// <summary>
  /// Una WorkView que DEBE estar dentro de una NavigableView
  /// </summary>
  public partial class StockInsumosView : XtraUserControl, IWorkView
  {
    private StockInsumosViewModel _viewModel;

    public StockInsumosView()
    {
      InitializeComponent();
      _viewModel = ViewModelSource.Create<StockInsumosViewModel>();
    }

    private void NavTo_StartView(object sender, EventArgs e)
    {

    }
  }
}
