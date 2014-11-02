using System;
using System.Collections.Generic;

namespace Entidades
{
    public class enTObraSocial
    {

        public enTObraSocial()
        {
            this.TPaciente = new HashSet<enTPaciente>();
            this.TPlanObraSocial = new HashSet<enTPlanObraSocial>();
            this.TipoFactura = new HashSet<enTipoFactura>();

        }
    
        public int IdObraSocial { get; set; }
        public string Mnemonico { get; set; }
        public string ObraSocial { get; set; }
        public string Direccion { get; set; }
        public Nullable<int> Idcodloc { get; set; }
        public Nullable<int> IdTipoIVA { get; set; }
        public string CUIT { get; set; }
        public string Telefono { get; set; }
        public string Observaciones { get; set; }
        public Nullable<int> IdTipoFactura { get; set; }
    
        public virtual enTLocalidad TLocalidad { get; set; }
        public virtual ICollection<enTipoFactura> TipoFactura { get; set; }
        public virtual enTTipoIVA TTipoIVA { get; set; }
        public virtual ICollection<enTPaciente> TPaciente { get; set; }
        public virtual ICollection<enTPlanObraSocial> TPlanObraSocial { get; set; }
    }
}
