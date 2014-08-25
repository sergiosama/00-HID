using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Data;
using Entidades;

namespace TestEF
{
  class Program
  {
    static void Main(string[] args)
    {
      HIDContext db = new HIDContext();

      //db.Configuration.LazyLoadingEnabled = false;
      //foreach (var usuario in db.Usuarios)
      //{
      //  Console.WriteLine(usuario.Login);
      //  Console.WriteLine(usuario.Recurso.Email);
      //}

      //var usr = db.Usuarios.Where(x => x.Login == "ethedy").FirstOrDefault();

      //Console.WriteLine(usr.Recurso.Apellido);
      //Console.ReadLine();

      //var recLoaded = db.Entry(usr).Reference(x => x.Recurso).IsLoaded;

      //if (!recLoaded)
      //{
      //  Console.WriteLine("NO CARGO!!!");
      //  db.Entry(usr).Reference(x => x.Recurso).Load();
      //}
      //else
      //{
      //  Console.WriteLine("SI CARGO PELOTUDOOOOO!!!");
      //}

      //string s = usr.Recurso.Apellido;
      //Console.WriteLine(s);
      //Console.ReadLine();

      var rec = db.Recursos.Where(x => x.Nombre.Contains("Enrique")).FirstOrDefault();

      if (rec.Categoria != null)
      {
        Console.WriteLine(rec.Categoria.Detalle);
        Console.WriteLine(rec.SituacionAFIP.DescripcionIVA);
      }
      Console.ReadLine();
    }
  }
}
