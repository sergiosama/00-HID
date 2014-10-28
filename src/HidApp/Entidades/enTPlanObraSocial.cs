using System;
using System.Collections.Generic;

namespace Entidades
{
	public class enTPlanObraSocial
	{

        public enTPlanObraSocial()
        {
            this.TPaciente = new HashSet<enTPaciente>();
        }
    
        public int IdPlanObraSocial { get; set; }
        public Nullable<int> IdObraSocial { get; set; }
        public string NombrePlan { get; set; }
    
        public virtual enTObraSocial TObraSocial { get; set; }
        public virtual ICollection<enTPaciente> TPaciente { get; set; }
	}
}
