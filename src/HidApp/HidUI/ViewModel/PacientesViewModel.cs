using DevExpress.Mvvm;

using HidUI.Common;

namespace HidUI.ViewModel
{
    public class PacientesViewModel : ViewModelBase
    {
        public PacientesViewModel()
        {
            Helpers.MainForm.MainViewModel.NavigateTo(ViewType.PacientesView);
        }
    }
}
