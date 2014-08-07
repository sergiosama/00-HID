using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Maquetas.Common;

namespace Maquetas.Views
{
  public partial class StockAlquilablesView : XtraUserControl, IWorkView
  {
    public StockAlquilablesView()
    {
      InitializeComponent();
    }

    private void NavTo_StartView(object sender, EventArgs e)
    {

    }
  }
}
