using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Entidades
{
  public class Proveedor
  {
    public Proveedor()
    {
      Habilitado = true;
    }

    public int ID { get; set; }

    [Required]
    public string Nombre { get; set; }

    public string Direccion { get; set; }

    [Required]
    public string CUIT { get; set; }

    public bool Habilitado { get; set; }
  }
}
