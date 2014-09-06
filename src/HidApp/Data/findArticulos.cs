using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Data
{
    class findArticulos
    {
        private HIDContext ctxFind { get; set; }

        private bool Find { get; set; }

        List<enTArticulo> Articulos= new List<enTArticulo>();

        public IList<enTArticulo> articulos
        {
            get { return Articulos; }
        }        




  



    }
}
