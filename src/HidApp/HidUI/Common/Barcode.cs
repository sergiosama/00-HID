using DevExpress.XtraPrinting.BarCode;
using DevExpress.XtraReports.UI;

namespace HidUI.Common
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
