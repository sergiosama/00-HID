using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using Maquetas.Common;

namespace Maquetas.ViewModel
{
  public class AboutViewModel : ViewModelBase
  {
    [Command(UseCommandManager = false)]
    public void Close()
    {
      Debug.WriteLine("Cerrar about, volver a la vista previa");

      //  ((ISupportParentViewModel)this).ParentViewModel
      Helpers.MainForm.MainViewModel.CloseView();
    }
  }
}
