using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;

namespace Maquetas
{
  class Persona
  {
    [Required(ErrorMessage = "Debe especificarse el nombre de la Persona")]
    public string Nombre { get; set; }

    public string DNI { get; set; }
  }
}
