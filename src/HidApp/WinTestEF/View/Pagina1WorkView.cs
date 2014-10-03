using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;

namespace WinTestEF.View
{
  public partial class Pagina1WorkView : DevExpress.XtraEditors.XtraUserControl, IWorkView
  {
    public Pagina1WorkView()
    {
      InitializeComponent();
    }

    public void BindCommands(ISupportRibbon parent)
    {
    }
  }
}
