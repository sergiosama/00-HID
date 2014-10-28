using System;
using System.Collections.Generic;

namespace Entidades
{
	public class enTLocalidad
	{
		
        public enTLocalidad()
        {
            this.TObraSocial = new HashSet<enTObraSocial>();
            this.TPaciente = new HashSet<enTPaciente>();
        }
    
        public int Idcodloc { get; set; }
        public string Idcodprov { get; set; }
        public string codpostal { get; set; }
        public string localidad { get; set; }
    
        public virtual enTProvincia TProvincia { get; set; }
        public virtual ICollection<enTObraSocial> TObraSocial { get; set; }
        public virtual ICollection<enTPaciente> TPaciente { get; set; }
	}
}
