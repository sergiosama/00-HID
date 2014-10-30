using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using HidUI.Common;
using HidUI.ViewModel;
using System.Data.Entity;
using System.Linq;
using Data;

using Entidades;
using DevExpress.Mvvm.POCO;
using DevExpress.XtraEditors.Controls;

namespace HidUI.Views
{
    public partial class PacientesView : DevExpress.XtraEditors.XtraUserControl
    {

        private PacientesViewModel _viewModel;
       
        public BindingSource bs;

        public PacientesView()
        {
            _viewModel = ViewModelSource.Create<PacientesViewModel>();

            InitializeComponent();
            
            bs = new BindingSource();

          

            DB.Context.Pacientes.Load();

            var Pac = DB.Context.Pacientes.Local.ToBindingList();

            bs.DataSource = Pac;

            teNroDni.DataBindings.Add(new Binding("Text", bs, "NroDNI"));
            teApellido.DataBindings.Add(new Binding("Text", bs, "Apellido"));
            teNombres.DataBindings.Add(new Binding("Text", bs, "Nombres"));
            teNroObraSocial.DataBindings.Add(new Binding("Text", bs, "NroObraSocial"));
            teCalle.DataBindings.Add(new Binding("Text", bs, "Calle"));
            teNroDomicilio.DataBindings.Add(new Binding("Text", bs, "NroDomicilio"));
            meComentario.DataBindings.Add(new Binding("Text", bs, "Comentarios"));
            teEmail.DataBindings.Add(new Binding("Text", bs, "email"));
            teTelefono.DataBindings.Add(new Binding("Text", bs, "Telefono"));
            teCelular.DataBindings.Add(new Binding("Text", bs, "Celular"));
            deNacimiento.DataBindings.Add(new Binding("Value", bs, "FechaNacimiento"));
            lueObraSocial.DataBindings.Add(new Binding("EditValue", bs, "IdObraSocial"));
            lueTipoDocumento.DataBindings.Add("EditValue", bs, "IdTipoDocumento");
            luePlan.DataBindings.Add(new Binding("EditValue", bs, "IdPlan"));

            lueTipoDocumento.Properties.Columns.Add(new LookUpColumnInfo("IdTipoDocumento", "ID"));
            lueTipoDocumento.Properties.Columns.Add(new LookUpColumnInfo("TipoDocumento", "Tipo Documento"));

            lueTipoDocumento.Properties.Columns["IdTipoDocumento"].Visible = false;

            lueObraSocial.Properties.Columns.Add(new LookUpColumnInfo("IdObraSocial", "ID"));
            lueObraSocial.Properties.Columns.Add(new LookUpColumnInfo("Mnemonico", "Siglas"));
            lueObraSocial.Properties.Columns.Add(new LookUpColumnInfo("ObraSocial", "Detalle"));


            luePlan.Properties.Columns.Add(new LookUpColumnInfo("IdPlanObraSocial", "ID"));
            luePlan.Properties.Columns.Add(new LookUpColumnInfo("NombrePlan", "Plan"));

        }


        /// <summary>
        /// 
        /// </summary>
        private void CargaLookUp()
        {
               IQueryable<enTTipoDocumento> TipoDoc = from q in DB.Context.TipoDocumento
                                                       select q;
                List<enTTipoDocumento> td = TipoDoc.ToList();
                lueTipoDocumento.Properties.DataSource = td;

    
                IQueryable<enTObraSocial> iqOS = from q in DB.Context.TObraSocial
                                                 select q;

                List<enTObraSocial> lOs = iqOS.ToList();

                lueObraSocial.Properties.DataSource = lOs;

                IQueryable<enTPlanObraSocial> iqPlan = from q in DB.Context.PlanObraSocial
                                                       select q;

                List<enTPlanObraSocial> lPlan = iqPlan.ToList();

                luePlan.Properties.DataSource = lPlan;
         

               
            
        }



    }
}
