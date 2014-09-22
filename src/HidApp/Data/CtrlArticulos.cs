using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.Entity.Validation;

namespace Data
{
    class CtrlArticulos
    {
        private HIDContext ctx { get; set; }
                
        public List<enTArticulo> SelectArticulos()
        {
            return (from a in ctx.Articulos select a).ToList();
        }
        public List<enTArticulo> SelectArticuloByIdArticulo(int _IdArticulo)
        {
            return (from a in ctx.Articulos where a.IdArticulo == _IdArticulo select a).ToList(); 
        }

        public List<enTArticulo> SelectArticuloByIdRecurso(int _IdRecurso)
        {
            return (from a in ctx.Articulos where a.IdRecurso == _IdRecurso select a).ToList();
        }

        public List<enTArticulo> SelectArticuloByCodeBar(string _CodeBar)
        {
            return (from a in ctx.Articulos where a.CodeBar == _CodeBar select a).ToList();
        }


        
        public bool Insertar(enTArticulo entidad)
        {
            try
            {
                ctx.Articulos.Add(entidad);
                ctx.SaveChanges();
            }
            catch ( Exception )
            {
                return false;    
            }
            
            return true;
        }

        public bool Eliminar( int _idArticulo)
        {

            try
            {
                ctx.Articulos.Remove(ctx.Articulos.FirstOrDefault(a => a.IdArticulo == _idArticulo));
                ctx.SaveChanges();
            }
            catch (Exception )
            {
                return false;
            }

            return true;
            
        
        }

    }
}
