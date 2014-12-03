using System;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using HidUI.Common;
using HidUI.ViewModel;

namespace HidUI.Views
{
  public partial class StockInsumosView_ : XtraUserControl, IWorkView
  {
    public StockInsumosView_()
    {
      InitializeComponent();
      ViewModel = ViewModelSource.Create(() => new StockAlquilablesViewModel());
    }

    public void BindCommands(ISupportRibbon parent)
    {
      throw new NotImplementedException();
    }

    public IWorkViewModel ViewModel { get; set; }
  }
}
