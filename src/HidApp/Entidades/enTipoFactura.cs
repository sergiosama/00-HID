using System;
using System.Collections.Generic;


namespace Entidades
{
    public class enTipoFactura
    {

         public enTipoFactura()
        {
            this.TObraSocial = new HashSet<enTObraSocial>();
        }
    
        public int IdTipoFactura { get; set; }
        public string TipoFactura { get; set; }
    
        public virtual ICollection<enTObraSocial> TObraSocial { get; set; }
    }
}
