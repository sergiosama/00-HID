using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using Data;
using Entidades;
using Servicios;

namespace TestEF
{
  class Program
  {
    static void Main(string[] args)
    {
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


/*
      var rec = db.Recursos.Where(x => x.Nombre.Contains("Enrique")).FirstOrDefault();

      if (rec.Categoria != null)
      {
        Console.WriteLine(rec.Categoria.Detalle);
        Console.WriteLine(rec.SituacionAFIP.DescripcionIVA);
      }
      Console.ReadLine();

      //  probando stored que retorna 0 o 1
      var xx = db.Database.SqlQuery<int>("SEGU.ValidarUsuarioPassword @p0, @p1", "ethedy", "6nDaANLlLtb68GkKXhdlkeJc5z7b6j29QE2eoi/t9HY=").FirstOrDefault();
      //  var xx = db.Database.SqlQuery<int>("select top 1 IdRecurso from tUsuarios").FirstOrDefault();
*/
      Console.WriteLine("TERMINADO!!");
      Console.ReadLine();
    }

    public void TestAuditoriaSimple()
    {
      HIDContext db = new HIDContext();

      AuditInfo ai = new AuditInfo();

      ai.Detalles = "Hola, mundo!!!!";

      db.Auditoria.Add(ai);

      db.SaveChanges();
    }

    public void TestAuditoria()
    {
      AuditServices audit = new AuditServices();

      audit.SaveAuditInfo(new AuditInfo() { Detalles = "Hola Mundo del Orrrrto!!" });
    }

    public void TestImagen()
    {
      //  cargar una imagen determinada en el ID de un usuario
      HIDContext ctx = new HIDContext();

      enTRecurso yo = ctx.Recursos.FirstOrDefault(x => x.Apellido == "Thedy");

      //ctx.Recursos.Local.ToBindingList();
      //  obtener foto desde archivo
      string path = @"C:\Users\Quiquillo\Pictures\ET_Perfil.jpg";

      FileInfo file = new FileInfo(path);

      if (file.Exists && file.Length < 200000)
      {
        Bitmap imagen = new Bitmap(path);

        //  convertir a byte[]

        //  asignar a la propiedad

        //  Guardar...
        //  ctx.SaveChanges();
        
      }
      else
        Console.WriteLine("El archivo no existe o es demasiado grande para guardarlo como fotografia");
    }
  }
}
