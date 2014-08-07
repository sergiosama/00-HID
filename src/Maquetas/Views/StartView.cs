using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using Maquetas.ViewModel;

namespace Maquetas.Views
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
