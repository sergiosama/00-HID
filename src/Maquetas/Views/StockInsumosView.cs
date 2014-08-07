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
using Maquetas.Common;
using Maquetas.ViewModel;

namespace Maquetas.Views
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
