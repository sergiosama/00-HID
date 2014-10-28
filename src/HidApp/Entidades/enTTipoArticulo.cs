using System;
using System.Collections.Generic;

namespace Entidades
{
	public class enTTipoArticulo
	{
        public enTTipoArticulo()
        {
            this.TArticulo = new HashSet<enTArticulo>();
        }
    
        public int IdTipoArticulo { get; set; }
        public string DetalleTipoArticulo { get; set; }
    
        public virtual ICollection<enTArticulo> TArticulo { get; set; }
	}
}
