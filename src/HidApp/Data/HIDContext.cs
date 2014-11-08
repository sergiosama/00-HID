using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

using Entidades;

namespace Data
{
  public class HIDContext : DbContext
  {
    /* 
       Unable to determine the principal end of an association between the types 'Entidades.enTOrden' and 'Entidades.enTDetalleOrden'. 
      The principal end of this association must be explicitly configured using either the relationship fluent API or data annotations.
    */

    public DbSet<enTCtaCteRecurso> CtaCteRecurso { get; set; }

    public DbSet<enTRecurso> Recursos { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }
    
    public DbSet<AuditInfo> Auditoria { get; set; }
    
    public DbSet<enTArticulo> Articulos { get; set; }
    
    public DbSet<enTCategoriaRecurso> CategoriaRecurso { get; set; }
    
    public DbSet<enTPaciente> Pacientes { get; set; }

    public DbSet<enTCtaCtePaciente> CtaCtePaciente { get; set; }
    
    public DbSet<enTObraSocial> TObraSocial { get; set; }
    
    public DbSet<enTRent> Rent { get; set; }
    
    public DbSet<enTTipoArticulo> TTipoArticulo { get; set; }
    
    public DbSet<enTTipoDocumento> TipoDocumento { get; set; }
    
    public DbSet<enTPlanObraSocial> PlanObraSocial { get; set; }
    
    public DbSet<enTipoFactura> TipoFactura { get; set; }
    
    public DbSet<enTLocalidad> Tlocalidad { get; set; }
    
    public DbSet<enTProvincia> Provincia { get; set; }

    public DbSet<enTDetalleOrden> DetalleOrden { get; set; }
    
    public DbSet<enTOrden> Orden { get; set; }

    public DbSet<enTTipoIVA> TipoIva { get; set; }

    public DbSet<Proveedor> Proveedores { get; set; }
   
    public HIDContext()
      : base("Server=(local)\\SQLExpress;Database=HID;Trusted_Connection=true;")
    {
      
    }

    public HIDContext(string cstrConn) : base(cstrConn) { }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      //base.OnModelCreating(modelBuilder);
      modelBuilder.Configurations.Add(new ConfiguracionProvincia());
      modelBuilder.Configurations.Add(new ConfiguracionTipoFactura());
      modelBuilder.Configurations.Add(new ConfiguracionTObraSocial());
      modelBuilder.Configurations.Add(new ConfiguracionUsuarios());
      modelBuilder.Configurations.Add(new ConfiguracionRecursos());
      modelBuilder.Configurations.Add(new ConfiguracionAuditoria());
      modelBuilder.Configurations.Add(new ConfiguracionCtaCteRecurso());      
      modelBuilder.Configurations.Add(new ConfiguracionCategoriaRecurso());
      modelBuilder.Configurations.Add(new ConfiguracionTipoIVA());
      modelBuilder.Configurations.Add(new ConfiguracionArticulos());
      modelBuilder.Configurations.Add(new ConfiguracionRent());
      modelBuilder.Configurations.Add(new ConfiguracionTipoArticulo());
      modelBuilder.Configurations.Add(new ConfiguracionPacientes());
      modelBuilder.Configurations.Add(new ConfiguracionCtaCtePaciente()); 
      modelBuilder.Configurations.Add(new ConfiguracionTipoDocumento());
      modelBuilder.Configurations.Add(new ConfiguracioPlanObraSocial());
      modelBuilder.Configurations.Add(new ConfiguracionTLocalidad());
      modelBuilder.Configurations.Add(new ConfiguracionDetalleOrdenes());
      modelBuilder.Configurations.Add(new ConfiguracionOrden());
      modelBuilder.Configurations.Add(new ConfiguracionProveedores());
    }
  }

  #region Clases para configurar mapeo de E-F

  public class ConfiguracionProvincia : EntityTypeConfiguration<enTProvincia>
  {
    public ConfiguracionProvincia()
    {
      ToTable("TProvincias");
      HasKey(et => et.Idcodprov);
    }
  }

  public class ConfiguracionRent: EntityTypeConfiguration<enTRent>
  {
    public  ConfiguracionRent()
    {
      ToTable("TRent");
      HasKey(et => et.IdRent);
    }
  }

  public class ConfiguracionCtaCteRecurso:EntityTypeConfiguration<enTCtaCteRecurso>
  {
    public ConfiguracionCtaCteRecurso()
    {
      ToTable("TCtaCteRecurso");
      HasKey(et => et.IdCtaCteRecursos);
    }
  }

  public class ConfiguracionTLocalidad : EntityTypeConfiguration<enTLocalidad>
  {
    public ConfiguracionTLocalidad()
    {
      ToTable("TLocalidad");
      HasKey(et => et.Idcodloc);
    }
  }

  public class ConfiguracionTipoFactura : EntityTypeConfiguration<enTipoFactura>
  { 
     public ConfiguracionTipoFactura()
     {
        ToTable("TipoFactura");
        HasKey(et => et.IdTipoFactura);
     }
  }

  public class ConfiguracionTObraSocial : EntityTypeConfiguration<enTObraSocial>
  {
    public ConfiguracionTObraSocial()
    {
      ToTable("TObraSocial");
      HasKey(et => et.IdObraSocial);
    }
  }

  public class ConfiguracioPlanObraSocial : EntityTypeConfiguration<enTPlanObraSocial>
  {
    public ConfiguracioPlanObraSocial()
    {
      ToTable("TPlanObraSocial");
      HasKey(et => et.IdPlanObraSocial);
      //HasRequired(et => et.TObraSocial).WithOptional().Map(x => x.MapKey("IdObraSocial"));
    }
  }

  public class ConfiguracionTipoDocumento : EntityTypeConfiguration<enTTipoDocumento>
  {
    public ConfiguracionTipoDocumento()
    {
      ToTable("TTipoDocumento");
      HasKey(et => et.IdTipoDocumento);
    }
  }

  public class ConfiguracionCtaCtePaciente : EntityTypeConfiguration<enTCtaCtePaciente>
  {
    public ConfiguracionCtaCtePaciente()
    {
      ToTable("TCtaCtePaciente");
      HasKey(et => et.NroCuenta);
    }
  }

  public class ConfiguracionPacientes : EntityTypeConfiguration<enTPaciente>
  {
    public ConfiguracionPacientes()
    {
      ToTable("TPacientes");
      HasKey(et => et.IdPaciente);
    }
  }

  public class ConfiguracionArticulos : EntityTypeConfiguration<enTArticulo>
  {
    public ConfiguracionArticulos()
    {
      ToTable("TArticulos");
      HasKey(et => et.IdArticulo);

      //Mapeo 
      //HasRequired(et => et.TRecurso).WithOptional().Map(x => x.MapKey("IdRecurso"));
      //HasRequired(et => et.TTipoArticulos).WithOptional().Map(x => x.MapKey("IdTipoArticulo"));
      /*
      HasRequired(p => p.TOrden)
        .WithMany()
        .HasForeignKey(a => a.IdArticulo);
      /*
      HasRequired(p => p.TRent)
          .WithMany()
          .HasForeignKey(a => a.IdArticulo);  */
    }
  }

  //  OJO!!! Tiene que tener PK compuesta
  //  Ademas es una tabla de paso para una relacion m x n
  //
  public class ConfiguracionDetalleOrdenes : EntityTypeConfiguration<enTDetalleOrden>
  {
    public ConfiguracionDetalleOrdenes()
    {
      ToTable("TDetalleOrden");
      HasKey(et => et.IdDetalleOrden);

      HasRequired(et => et.TOrden).WithOptional().Map(m => m.MapKey("IdOrder"));
   
      /*
      HasRequired(p => p.TArticulo)
          .WithMany()
          .HasForeignKey(u => u.IdArticulo);
      //*/
    }
  }

  public class ConfiguracionOrden : EntityTypeConfiguration<enTOrden>
  {
    public ConfiguracionOrden()
    {
      ToTable("TOrdenes");
      HasKey(et => et.IdOrder);
      //HasRequired(et => et.TDetalleOrden).WithOptional().Map(m => m.MapKey("IdOrder"));
    }
  }

  public class ConfiguracionUsuarios : EntityTypeConfiguration<Usuario>
  {
    public ConfiguracionUsuarios()
    {
      //  mapear nombre de tabla y campo Login como Key, el resto CREO que es automatico...
      ToTable("tUsuarios");
      HasKey(et => et.Login);
      Property(et => et.PasswordExpireTime).HasColumnName("FechaExpiracionPass");
      Property(et => et.LastLogin).HasColumnName("FechaLastLogin");
      Property(et => et.MustChangePassword).HasColumnName("MustChangePass");

      HasRequired(et => et.Recurso).WithOptional().Map(x => x.MapKey("IdRecurso"));
       
      //HasRequired<enTRecurso>(x => x.Recurso);
    }
  }
    
  public class ConfiguracionRecursos : EntityTypeConfiguration<enTRecurso>
  {
    public ConfiguracionRecursos()
    {
      //  mapear tabla, el campo ID es automatico CREO --> NOP!
      ToTable("TRecursos");
      Property(et => et.IdRecurso).HasColumnName("IdRecurso");
      HasKey(et => et.IdRecurso);

      Property(et => et.Sexo)
        .HasMaxLength(1)
        .HasColumnName("Sexo")
        .HasColumnType("char")
        .IsFixedLength();
      
      //  Mapeos de relaciones (FK)
      //  HasOptional<enTCategoriaRecurso>(et => et.Categoria).WithOptionalDependent();
      HasOptional(et => et.TCategoriaRecurso)
        .WithMany()
        .Map(x => x.MapKey("IdCategoria"));

      HasOptional(et => et.SituacionAFIP)
        .WithMany()
        .Map(x => x.MapKey("IdTipoIVA"));

      //  Mapeos de columnas puntuales
      Property(et => et.Foto)
        .HasColumnName("Foto")
        .HasColumnType("Image");
    }
  }

  public class ConfiguracionAuditoria : EntityTypeConfiguration<AuditInfo>
  {
    public ConfiguracionAuditoria()
    {
      //  mapear tabla en otro schema
      ToTable("tAuditoria", "AUDIT");

      //  mapear clave primaria + identity
      Property(et => et.ID)
        .HasColumnName("IdAuditoria")
        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
      
      //  HasKey no hace falta porque la propiedad ya se llama ID

      //  mapear nombres de campos y propiedades
      Property(et => et.Source)
        .HasColumnName("Origen")
        .IsRequired();

      Property(et => et.Type)
        .HasColumnName("Tipo")
        .IsRequired();
    }
  }

  public class ConfiguracionTipoIVA : EntityTypeConfiguration<enTTipoIVA>
  {
    public ConfiguracionTipoIVA()
    {
      ToTable("TTipoIVA");
      HasKey(et => et.IdTipoIVA);
    }
  }

  public class ConfiguracionCategoriaRecurso : EntityTypeConfiguration<enTCategoriaRecurso>
  {
    public ConfiguracionCategoriaRecurso()
    {
      ToTable("TCategoriaRecurso");
      HasKey(et => et.IdCategoria);
    }
  }

  public class ConfiguracionTipoArticulo : EntityTypeConfiguration<enTTipoArticulo>
  {
    public ConfiguracionTipoArticulo()
    {
      ToTable("TTipoArticulos");
      HasKey(et => et.IdTipoArticulo);
    }
  }

  public class ConfiguracionProveedores : EntityTypeConfiguration<Proveedor>
  {
    public ConfiguracionProveedores()
    {
      ToTable("TProveedores");
      Property(et => et.ID).HasColumnName("IdProveedor");
    }
  }

  #endregion

}
