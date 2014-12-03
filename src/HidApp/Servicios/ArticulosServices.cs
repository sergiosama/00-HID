using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data;
using Entidades;
using Infraestructura;

namespace Servicios
{
  /// <summary>
  /// Incluye BL para la clase Articulos, Insumos, Alquilables y las clases anexas utilizadas
  /// </summary>
  public class ArticulosServices
  {
    public ArticulosServices()
    {
      Errores = new List<HidErrorInfo>();
    }

    /// <summary>
    /// Obtiene la lista de Proveedores habilitados
    /// </summary>
    /// <returns></returns>
    public IList<Proveedor> GetProveedores()
    {
      HIDContext ctx = DB.Context;

      //  return ctx.Proveedores.Local.ToBindingList();
      //  TODO retornar SOLO HABILITADOS!!
      return ctx.Proveedores.Local;
    }

    public IList<enTArticulo> GetInsumos()
    {
      //
      return null;
    }

    /// <summary>
    /// Obtiene la lista de los tipos de articulos habilitados
    /// </summary>
    /// <returns></returns>
    public IList<enTTipoArticulo> GetTipoArticulos()
    {
      HIDContext ctx = DB.Context;

      return ctx.TTipoArticulo.Local;
    }

    public bool AddProveedor(Proveedor nuevo)
    {
      HIDContext ctx = DB.Context;
      bool result = false;

      try
      {
        Errores.Clear();

        ctx.Proveedores.Add(nuevo);
        //  var errorList = ctx.GetValidationErrors();  //  una para cada instancia...ojo...
        var validation = ctx.Entry(nuevo).GetValidationResult();

        if (!validation.IsValid)
        {
          Errores.AddRange(HidErrorInfo.FromEFCollectionError(validation.ValidationErrors));
        }
        else
        {
          ctx.SaveChanges();
          Audit(InfoType.Agregado, "AddProveedor", string.Format("[+] Proveedor: Nombre --> {0} CUIT --> {1}", nuevo.Nombre, nuevo.CUIT));

          result = true;
        }
      }
      catch (Exception ex)
      {
        Errores.Add(HidErrorInfo.FromException(ex));
      }
      return result;
    }

    public bool UpdateProveedor(Proveedor modificado)
    {
      HIDContext ctx = DB.Context;
      bool result = false;

      try
      {
        Errores.Clear();

        //  ctx.Proveedores.Add(nuevo);
        //  var errorList = ctx.GetValidationErrors();  //  una para cada instancia...ojo...
        var validation = ctx.Entry(modificado).GetValidationResult();

        if (!validation.IsValid)
        {
          Errores.AddRange(HidErrorInfo.FromEFCollectionError(validation.ValidationErrors));
        }
        else
        {
          ctx.SaveChanges();
          Audit(InfoType.Modificacion, "UpdateProveedor", 
            string.Format("[M] Proveedor: Nombre --> {0} CUIT --> {1}", modificado.Nombre, modificado.CUIT));

          result = true;
        }
      }
      catch (Exception ex)
      {
        Errores.Add(HidErrorInfo.FromException(ex));
      }
      return result;
    }

    public void Addinsumo(enTArticulo nuevo)
    {
      //
    }

    public bool UpdateInsumo(enTArticulo modificado)
    {
      return false;
    }


    public List<HidErrorInfo> Errores { get; set; }

    private void Audit(InfoType tipo, string subPath, string detalle)
    {
      //  TODO eliminar la dependencia implementando un servicio de registro singleton o una inversion de dependencia con interface
      AuditServices audit = new AuditServices();
      AuditInfo ai = new AuditInfo()
      {
        Detalles = string.Format("[{1}] ==> {0}", detalle, Contexto.Current.Sesion.Usuario.Login), 
        Type = tipo 
      };

      ai.Source = string.Format("ArticulosServices\\{0}", subPath);
      audit.SaveAuditInfo(ai);
    }
  }
}
