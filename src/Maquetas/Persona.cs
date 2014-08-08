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
    [Required(ErrorMessage = "Debe especificarse el apellido de la Persona")]
    public string Apellido { get; set; }

    [Required(ErrorMessage = "Debe especificarse el nombre de la Persona")]
    public string Nombre { get; set; }

    [Required(ErrorMessage = "Debe especificarse el DNI de la Persona")]

    public string DNI { get; set; }
  }
}
