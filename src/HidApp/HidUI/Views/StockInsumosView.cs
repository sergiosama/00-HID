using System;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using HidUI.Common;
using HidUI.ViewModel;
using System.Data.Entity;
using Data;
using DevExpress.XtraGrid.Columns;


namespace HidUI.Views
{
  /// <summary>
  /// Una WorkView que DEBE estar dentro de una NavigableView
  /// </summary>
  public partial class StockInsumosView : XtraUserControl, IWorkView
  {
    private StockInsumosViewModel _viewModel;
    private HIDContext dbCtx;
    
    //this.simpleButton1.Click += new System.EventHandler(this.NavTo_StartView);

    public delegate void EventHandler(object sender, System.EventArgs e);


    EventHandler EventHandlerDelegate;

    new public event EventHandler Click
    {
      add
      {
        this.EventHandlerDelegate += value;
      }

      remove
      {
        this.EventHandlerDelegate -= value;
      }
    }


    
    public StockInsumosView()
    {
      InitializeComponent();
      _viewModel = ViewModelSource.Create<StockInsumosViewModel>();

               

      GridColumn _col;
      dbCtx = new HIDContext();

      
           
      

      //Codigo de barra 
      teCodigoBarra.Enter += teCodigoBarra_Enter;
      teCodigoBarra.EnterMoveNextControl = true;

      teDetalleArticulo.EnterMoveNextControl = true;


    


    }

    void teCodigoBarra_Enter(object sender, EventArgs e)
    {
      if (teCodigoBarra.Text != string.Empty)
      {
        bcControl.Text = teCodigoBarra.Text;
      }
    }

      
      
   
  }
}
