using System;
using DevExpress.XtraEditors;
using HidUI.Common;

namespace HidUI.Views
{
  public partial class StockAlquilablesView : XtraUserControl, IWorkView
  {
    private IWorkViewModel _viewModel;

    public StockAlquilablesView()
    {
      InitializeComponent();
    }

    private void NavTo_StartView(object sender, EventArgs e)
    {

    }

    public void BindCommands(ISupportRibbon parent)
    {
      throw new NotImplementedException();
    }

    public IWorkViewModel ViewModel { get; set; }
  }
}
