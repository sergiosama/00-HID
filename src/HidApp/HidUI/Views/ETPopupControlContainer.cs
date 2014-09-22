using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraBars;
using DevExpress.XtraBars.ViewInfo;

namespace HidUI.Views
{
  public enum DropDirection
  {
    DropDown,
    DropUp
  }

  public class ETPopupControlContainer : PopupControlContainer
  {
    public ETPopupControlContainer(IContainer container) : base(container) { DropDirection = DropDirection.DropDown;}

    public ETPopupControlContainer() { DropDirection = DropDirection.DropDown; }

    public DropDirection DropDirection { get; set; }

    protected override LocationInfo CalcLocationInfo(Point p)
    {
      LocationInfo li = base.CalcLocationInfo(p);

      if (DropDirection == DropDirection.DropUp)
      {
        Point newPoint = base.CalcLocationInfo(p).Location;

        newPoint.Y -= (this.Height + (this.Activator as BarButtonItemLink).Item.Height + 6);
        li = new LocationInfo(newPoint);
      }
      return li;
    }
  }
}
