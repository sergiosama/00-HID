using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using WinTestEF.ViewModel;

namespace WinTestEF.View
{
  public partial class Pagina1WorkView : DevExpress.XtraEditors.XtraUserControl, IWorkView
  {
    public Pagina1WorkView()
    {
      InitializeComponent();
      ViewModel = ViewModelSource.Create(() => new Pagina1WorkViewModel());
    }

    public void BindCommands(ISupportRibbon parent)
    {
    }

    public IWorkViewModel ViewModel { get; set; }
  }
}
