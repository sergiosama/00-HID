using System;
using System.Collections.Generic;

namespace Entidades
{
	public class enTProvincia
	{
		 public enTProvincia()
        {
            this.TLocalidad = new HashSet<enTLocalidad>();
        }
    
        public string Idcodprov { get; set; }
        public string provincia { get; set; }

        public virtual ICollection<enTLocalidad> TLocalidad { get; set; }
	}
}
