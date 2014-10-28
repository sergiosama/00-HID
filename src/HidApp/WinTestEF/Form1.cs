using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;


using Data;
using DevExpress.Data;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using Entidades;

namespace WinTestEF
{
  public partial class Form1 : DevExpress.XtraEditors.XtraForm
  {
    private HIDContext _db;
    private enTRecurso _selected;
    private bool _bound;
    private ImageConverter _converter;

    //  Cuando haga el control, deberia bindear a un elemento tipo enTRecurso, luego la grilla elige uno en particular, 
    //  o si estoy editando uno en particular es mas sencillo porque no tengo lista sino el recurso actual

    public Form1()
    {
      GridColumn col;

      InitializeComponent();
      //
      //  Obtenemos el contexto de E-F para guardarlo durante toda la app
      _db = new HIDContext();
      //
      //  Customización del grid lookup
      grdRecursos.Properties.NullText = "[Elegir una persona de la lista...]";
      grdRecursos.Properties.BestFitMode = BestFitMode.BestFitResizePopup;

      Size minSize = grdRecursos.Properties.PopupFormMinSize;
      minSize.Width = grdRecursos.Width;

      grdRecursos.Properties.PopupFormMinSize = minSize;

      grdRecursos.Properties.ValueMember = "IdRecurso";
      //grdRecursos.Properties.ValueMember = "Apellido";
      //grdRecursos.EditValue = "IdRecurso";
      grdRecursos.Properties.DisplayMember = "Apellido";

      //  grdRecursos.Properties.View.OptionsBehavior.AutoPopulateColumns = false;
      col = new GridColumn() {FieldName = "Nombre", VisibleIndex = 0};
      grdRecursos.Properties.View.Columns.Add(col);

      col = new GridColumn() { FieldName = "Apellido", VisibleIndex = 1, SortOrder = ColumnSortOrder.Ascending};
      grdRecursos.Properties.View.Columns.Add(col);

      col = new GridColumn() { FieldName = "Categoria.Detalle", VisibleIndex = 2, Caption = "Actividad / Perfil"};
      grdRecursos.Properties.View.Columns.Add(col);

      _bound = false;
      _converter = new ImageConverter();
    }

    private void TareasHID_Load(object sender, EventArgs e)
    {
      _db.Recursos.Load();

      var recursos = _db.Recursos.Local.ToBindingList();

      //  se produce cuando un item se agrega en la lista recursos (de E-F) o se modifica (si el POCO implementa INotifyPropertyChanged)
      recursos.ListChanged += RecursosOnListChanged;
      
      bsrc.DataSource = recursos;
      //  hasta ahora no se produjo nunca este evento...
      //  bsrc.DataSourceChanged += BsrcOnDataSourceChanged;

      //  OncurrentChanged es cuando cambia la propiedad Current del BindingSource, no cuando el elemento en si se modifica
      //  bsrc.CurrentChanged += BsrcOnCurrentChanged;

      //  lstRecursos.Properties.DisplayMember = "Apellido";
      //  lstRecursos.Properties.ValueMember = "IdRecurso";
      //
      //  lstRecursos.Properties.DataSource = recursos;
      grdRecursos.Properties.DataSource = bsrc;

      //  Bindings
      //  txtNombre.DataBindings.Add(new Binding("Text", bsrc, "Nombre"));
      //  txtApellido.DataBindings.Add(new Binding("Text", bsrc, "Apellido"));

      //  no implemento binding en picture box con eventos de formato porque tengo problemas ...
      //  Binding bind = new Binding("Image", bsrc, "Foto");

      //
      //      bind.Format += BindOnFormat;
      //      bind.Parse += BindOnParse;
      //  bind.ControlUpdateMode = ControlUpdateMode.OnPropertyChanged;
      //  picActual.DataBindings.Add(bind);
    }

//    private void BindOnParse(object sender, ConvertEventArgs args)
//    {
//      Debug.WriteLine("Parse");
//      if (picActual.Tag == "null")
//        args.Value = null;
//    }
//
//    private void BindOnFormat(object sender, ConvertEventArgs args)
//    {
//      if (args.DesiredType == typeof (Image))
//      {
//        Debug.WriteLine("Format");
//        args.Value = global::WinTestEF.Properties.Resources.no_image;
//        picActual.Tag = "null";
//      }
////      if (args.Value == null) 
////        return;
////      Debug.WriteLine("Format SIII");
//    }

    private void BsrcOnCurrentChanged(object sender, EventArgs eventArgs)
    {
      Debug.WriteLine("Cambio Actual");
    }

    private void BsrcOnDataSourceChanged(object sender, EventArgs eventArgs)
    {
      Debug.WriteLine("Cambio DS");
    }


    private void RecursosOnListChanged(object sender, ListChangedEventArgs args)
    {
      Debug.WriteLine("Cambio en lista");
    }

    /// <summary>
    /// Utilizar para customizar el texto que aparece como EditValue al elegir un elemento de la grilla
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ListaEditValue(object sender, DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs e)
    {
      //grdRecursos.Properties.View.get
      e.Handled = false;
      e.Value = "La puta madre...";
    }

    private void Open_SeleccionarImagen(object sender, EventArgs e)
    {
      SetImageFile();
    }

    private void SetImageFile()
    {
      dlgOpenImage.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
      dlgOpenImage.FileName = null;
      dlgOpenImage.Filter = "Archivos de imágenes (*.jpg;*.png;*.bmp;*.gif)|*.jpg;*.png;*.bmp;*.gif";
      if (dlgOpenImage.ShowDialog() == DialogResult.OK)
      {
        if ((new FileInfo(dlgOpenImage.FileName)).Length <= 200000)
        {
          //  traer imagen y colocarla como imagen futura
          Bitmap img = new Bitmap(dlgOpenImage.FileName);

          picActual.Image = img;
          //
          //  Ajusto la foto del elemento actual con la seleccionada
          _selected.Foto = (byte[]) _converter.ConvertTo(img, typeof (byte[]));

          //img.Dispose();
        }
        else
          MessageBox.Show(
            "Lo siento... la imagen es demasiado extensa para que ingrese en nuestra base de datos. Intente con una mas chica o de menor resolucion",
            "ERROR: archivo demasiado grande");
      }
    }

    private void SeleccionarImagen_ButtonClick(object sender, ButtonPressedEventArgs e)
    {
      if (e.Button.Kind == ButtonPredefines.Ellipsis)
        SetImageFile();
      else
      {
        //  
        _selected.Foto = null;
        picActual.Image = global::WinTestEF.Properties.Resources.no_image;
      }
    }

    private void Recursos_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
    {
      Debug.WriteLine(string.Format("{0}", e.Value));
    }

    private void Undo_Click(object sender, EventArgs e)
    {
      //  Volver atras todos los cambios => volver a cargar los controles con los valores
    }

    private void Recursos_EditValueChanged(object sender, EventArgs e)
    {
      BindingManagerBase bm = this.BindingContext[grdRecursos.Properties.DataSource];
      int idx = grdRecursos.Properties.GetIndexByKeyValue(grdRecursos.EditValue);
      
      bm.Position = grdRecursos.Properties.View.GetDataSourceRowIndex(idx);
      //object x = grdRecursos.EditValue;

      _selected = bm.Current as enTRecurso;

      //  Esto lo hago porque el binding con Picture no funciona bien o no se como hacerlo andar...
      if (_selected.Foto != null)
      {
        picActual.Image = (Bitmap)_converter.ConvertFrom(_selected.Foto);
      }
      else
        picActual.Image = global::WinTestEF.Properties.Resources.no_image;

      //  Bindings y habilitacion de controles (la primera vez que selecciono un elemento, las siguientes no es mas necesario)
      if (!_bound)
      {
        txtNombre.DataBindings.Add(new Binding("Text", bsrc, "Nombre"));
        txtApellido.DataBindings.Add(new Binding("Text", bsrc, "Apellido"));
        bedtSelectImage.Enabled = true;
        _bound = true;
      }
    }

    private void Update_Click(object sender, EventArgs e)
    {
      //  chequear si alguno de los objetos fue modificado
      if (_db.ChangeTracker.Entries<enTRecurso>().Count(x => x.State == EntityState.Modified) != 0)
      {
        //  guardar cambios
        if (
          MessageBox.Show("Seguro de guardar los cambios?", "CONFIRMAR!!", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
        {
          try
          {
            _db.SaveChanges();
            MessageBox.Show("Cambios guardados exitosamente!!", "TODO OK");
          }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message);
          }
        }
      }
      else
        MessageBox.Show("No se produjeron modificaciones en los datos, no es necesario actualizar la base",
          "Operacion Invalida");
    }

    private void TareasHID_Closed(object sender, FormClosedEventArgs e)
    {
      _db.Dispose();
    }

    private void pictureEdit1_PopupMenuShowing(object sender, DevExpress.XtraEditors.Events.PopupMenuShowingEventArgs e)
    {
        int f = 0;
    }
  }
}
