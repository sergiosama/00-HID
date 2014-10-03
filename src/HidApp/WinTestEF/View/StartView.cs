using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using WinTestEF.ViewModel;

namespace WinTestEF.View
{
  public partial class StartView : XtraUserControl
  {
    private StartViewModel _viewModel;

    public StartView()
    {
      InitializeComponent();
      _viewModel = ViewModelSource.Create<StartViewModel>();
    }

    private void Stock_Navigator_Click(object sender, TileItemEventArgs e)
    {
      _viewModel.NavigateToStock();
    }

  }
}
