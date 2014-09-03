using System.Diagnostics;
using DevExpress.Mvvm;
using DevExpress.Mvvm.DataAnnotations;
using HidUI.Common;

namespace HidUI.ViewModel
{
  public class AboutViewModel : ViewModelBase
  {
    [Command(UseCommandManager = false)]
    public void Close()
    {
      Debug.WriteLine("Cerrar about, volver a la vista previa");

      //  Me comunico directamente con el ViewModel principal para que manipule la vista
      //
      Helpers.MainForm.MainViewModel.CloseView();
    }
  }
}
