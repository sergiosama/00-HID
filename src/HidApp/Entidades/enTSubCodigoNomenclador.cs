using System;

namespace Entidades
{
	public class enTSubCodigoNomenclador
	{
        public int IdSubCodigoNomenclador { get; set; }
        public Nullable<int> IdCodigoNomenclador { get; set; }
        public string SubCodigo { get; set; }
        public string Descripcion1 { get; set; }
        public string Descripcion2 { get; set; }
        public Nullable<decimal> Honorarios { get; set; }
        public string Valor_H { get; set; }
        public string Tipo { get; set; }
        public Nullable<decimal> Gastos { get; set; }
        public string Valor_G { get; set; }
        public string Nomra1 { get; set; }
        public string Norma2 { get; set; }
        public string Norma3 { get; set; }
	}
}
