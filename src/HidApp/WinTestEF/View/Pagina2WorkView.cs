using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using WinTestEF.ViewModel;

namespace WinTestEF.View
{
  public partial class Pagina2WorkView : DevExpress.XtraEditors.XtraUserControl, IWorkView
  {
    public Pagina2WorkView()
    {
      InitializeComponent();
      ViewModel = ViewModelSource.Create(() => new Pagina2WorkViewModel());
    }

    public void BindCommands(ISupportRibbon parent)
    {
      throw new NotImplementedException();
    }

    public IWorkViewModel ViewModel { get; set; }
  }
}
