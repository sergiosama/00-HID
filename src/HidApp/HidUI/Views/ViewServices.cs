using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HidUI.Common;

namespace HidUI.Views
{
  public class LoginService : ILoginService
  {
    public void Show()
    {
      winLogin login = new winLogin();
      login.ShowDialog();
    }
  }
}
