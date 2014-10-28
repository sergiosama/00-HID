using System;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors;
using HidUI.Common;
using HidUI.ViewModel;
using System.Data.Entity;
using System.Linq;
using Data;
using System.Windows.Forms;
using Entidades;
using System.Collections.Generic;
using DevExpress.XtraGrid.Columns;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using System.IO;
using System.Drawing;

namespace HidUI.Views
{
  /// <summary>
  /// Una WorkView que DEBE estar dentro de una NavigableView
  /// </summary>
  public partial class StockInsumosView : XtraUserControl, IWorkView
  {
    private StockInsumosViewModel _viewModel;

    public HIDContext _ctx;

    public BindingSource bs;

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

      _ctx = new HIDContext();

      _ctx.Articulos.Load();

      var Art = _ctx.Articulos.Local.ToBindingList();

      bs = new BindingSource();


      bs.DataSource = Art;

      teCodigoBarra.DataBindings.Add( new Binding( "Text", bs ,  "CodeBar"));
      teDetalleArticulo.DataBindings.Add( new Binding("Text", bs, "DetalleArticulo"));
      teStock.DataBindings.Add(new Binding("Value", bs, "Stock"));
      teStockMinimo.DataBindings.Add(new Binding("Value", bs, "StockMinimo"));
      tePrecioAlquiler.DataBindings.Add( new Binding("Text", bs, "PrecioAlquiler"));
      tePrecioCosto.DataBindings.Add( new Binding("Text", bs, "PrecioCosto"));
      tePrecioPublico.DataBindings.Add( new Binding("Text", bs, "PrecioPublico"));
      imgArticulo.DataBindings.Add( new Binding("Image", bs, "Imagen"));


       //LookUpEdit

      leTipoArticulo.DataBindings.Add("EditValue", bs, "IdTipoArticulo");
      leTipoArticulo.Properties.Columns.Add(new LookUpColumnInfo ("DetalleTipoArticulo", "Tipo Artículo"));
      leTipoArticulo.Properties.Columns.Add(new LookUpColumnInfo("IdTipoArticulo", "ID"));
      leTipoArticulo.Properties.Columns["IdTipoArticulo"].Visible = false;

      leIdRecurso.DataBindings.Add("EditValue", bs, "IdRecurso");
      leIdRecurso.Properties.Columns.Add(new LookUpColumnInfo("Apellido", "Apellido"));
      leIdRecurso.Properties.Columns.Add(new LookUpColumnInfo("Nombre", "Nombre"));
      leIdRecurso.Properties.Columns.Add(new LookUpColumnInfo("IdRecurso", "ID"));
      leIdRecurso.Properties.Columns["IdRecurso"].Visible = false;
        
       // leTipoArticulo.Properties.Columns.Add(col);


      
      teDetalleArticulo.EnterMoveNextControl = true;

      
      gviewArticulos.DoubleClick += gviewArticulos_DoubleClick;
      gviewArticulos.KeyDown += gviewArticulos_KeyDown;
      btnAplicar.Click += btnAplicar_Click;

      gcArticulos.DataSource = bs;
      
    }

   
      /// <summary>
      /// 
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
    void btnAplicar_Click(object sender, EventArgs e)
    {
        
        try
        {
            int iIdActual = Convert.ToInt32(teIdArt.Text);
            if (iIdActual <= 0)
            {
                //Inserto...
                Insertar();
            }
            else
            {
                //ACtualizar
                Actualizar(iIdActual);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            gcArticulos.Refresh();
        }
    }



    


    void gviewArticulos_KeyDown(object sender, KeyEventArgs e)
    {

        switch (e.KeyCode)
        { 
            case Keys.Enter:
                {
                    gviewArticulos.PostEditor();

                    gviewArticulos.UpdateCurrentRow();


                }
                break;

            case Keys.Delete:
                {
                    //tomo la posición actual del cursor...
                    if(MessageBox.Show("Verdaderamente desea eliminar el registro actual?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                      //...
                       
                    }
                }
                break;
        }
        
    }



   

    void gviewArticulos_DoubleClick(object sender, EventArgs e)
    {
        object[] obj = ((System.Data.DataRowView)(gviewArticulos.GetFocusedRow())).Row.ItemArray;
        int iIdActual = obj.GetValue(0) == DBNull.Value ? 0 : Convert.ToInt32(obj.GetValue(0));
        
        LoadData( iIdActual );

    }





      /// <summary>
      /// Limpio los controles...
      /// </summary>
    private void Limpiar()
    {
        teIdArt.Text = "0";
        teDetalleArticulo.Text = string.Empty;
        tePrecioAlquiler.Text = string.Empty;
        tePrecioCosto.Text = string.Empty;
        tePrecioPublico.Text = string.Empty;
        teStock.Text = string.Empty;
        teStockMinimo.Text = string.Empty;
        imgArticulo.Image = HidUI.Properties.Resources.no_imagen;
        
    }



    #region Carga de datos en controles.
      /// <summary>
      /// Cargo los controles desde el evento doubleclick en la grilla.
      /// </summary>
      /// <param name="iId"></param>
    private void LoadData( int iId )
    {
       
            IQueryable<enTArticulo> Articulos = from q in _ctx.Articulos 
                                                where q.IdArticulo == iId
                                                select q;
            List<enTArticulo> lArt = Articulos.ToList();

            var OData = lArt[0];
            teIdArt.Text = OData.IdArticulo.ToString();
            teCodigoBarra.Text = OData.CodeBar;
            teDetalleArticulo.Text = OData.DetalleArticulo;
            tePrecioAlquiler.Text = OData.PrecioAlquiler.ToString();
            tePrecioCosto.Text = OData.PrecioCompra.ToString();
            tePrecioPublico.Text = OData.PrecioVenta.ToString();
            teStock.Text = OData.Stock.ToString();
            teStockMinimo.Text = OData.Stockminimo.ToString();
           
           
    }




    private void CargaCombos()
    {
           IQueryable<enTTipoArticulo> TipoArticulo = from q in _ctx.TTipoArticulo
                                                       select q;
            List<enTTipoArticulo> lTipo = TipoArticulo.ToList();
            leTipoArticulo.Properties.DataSource = lTipo;
            leTipoArticulo.Refresh();

            IQueryable<enTRecurso> Rec = from q in _ctx.Recursos
                                              select q;
            List<enTRecurso> lRec = Rec.ToList();
            leIdRecurso.Properties.DataSource = lRec;
            leIdRecurso.Refresh();
    }


    #endregion    Carga de datos en controles.

      /// <summary>
      /// Actualiza Articulos,  desde formulario.
      /// </summary>
      /// <param name="iId"></param>
    private void Actualizar( int iId)
    {
       
            try
            {
                enTArticulo oArt = _ctx.Articulos.SingleOrDefault<enTArticulo>(p => p.IdArticulo == iId);
                
                oArt.CodeBar = teCodigoBarra.Text;
                oArt.DetalleArticulo = teDetalleArticulo.Text;
                oArt.PrecioAlquiler = Convert.ToDecimal(tePrecioAlquiler.Text);
                oArt.PrecioCompra = Convert.ToDecimal(tePrecioCosto.Text);
                oArt.PrecioVenta = Convert.ToDecimal(tePrecioPublico.Text);
                oArt.Stock = Convert.ToInt32(teStock.Text);
                oArt.Stockminimo = Convert.ToInt32(teStockMinimo.Text);

                _ctx.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                gcArticulos.Refresh();
            }
             
            

        
    }

      /// <summary>
      /// Inserta nuevo elemento a la tabla Articulos
      /// </summary>
    private void Insertar()
    {
        try
        {
               enTArticulo et = new enTArticulo
                {
                    DetalleArticulo = teDetalleArticulo.Text,
                    CodeBar = teCodigoBarra.Text,
                    IdRecurso = Convert.ToInt32(leIdRecurso.EditValue.ToString()),
                    IdTipoArticulo = Convert.ToInt32(leTipoArticulo.EditValue.ToString()),
                    PrecioAlquiler = Convert.ToDecimal(tePrecioAlquiler.Text),
                    PrecioVenta = Convert.ToDecimal(tePrecioPublico.Text),
                    PrecioCompra = Convert.ToDecimal(tePrecioCosto.Text),
                    Stock = Convert.ToInt32(teStock.Text),
                    Stockminimo = Convert.ToInt32(teStockMinimo.Text)



                };

                _ctx.Articulos.Add(et);

            
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error...", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        finally
        {
            gcArticulos.Refresh();
        }
    
    }

    public bool Eliminar(int _idArticulo)
    {

     
            try
            {
                _ctx.Articulos.Remove(_ctx.Articulos.FirstOrDefault(a => a.IdArticulo == _idArticulo));
                _ctx.SaveChanges();
            }
            catch (Exception)
            {
                return false;
            }
        
        return true;


    }

    
    
    



  
      
   
  }
}
