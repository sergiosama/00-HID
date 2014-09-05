using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;


    

namespace HidUI
{
    class Barcode
    {
        public XRBarCode CreateBarCode(string strBarcode, float fHeight, float fWidth)
        {
            XRBarCode bCode = new XRBarCode();

            bCode.Symbology = new EAN13Generator();

            bCode.Text = strBarcode;
            bCode.HeightF = fHeight;
            bCode.WidthF = fWidth;

            return bCode;
        
        }
    }


    
}
