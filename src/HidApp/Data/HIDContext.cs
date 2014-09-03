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
    public DbSet<enTRecurso> Recursos { get; set; }

    public DbSet<Usuario> Usuarios { get; set; }

    public DbSet<AuditInfo> Auditoria { get; set; }

    public DbSet<enTArticulo> Articulos { get; set; }

    public HIDContext()
      : base("Server=HAL9000;Database=HID;Trusted_Connection=true;")
    {
      
    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      //base.OnModelCreating(modelBuilder);
      modelBuilder.Configurations.Add(new ConfiguracionUsuarios());
      modelBuilder.Configurations.Add(new ConfiguracionRecursos());
      modelBuilder.Configurations.Add(new ConfiguracionAuditoria());
      //
      modelBuilder.Configurations.Add(new ConfiguracionCategorias());
      modelBuilder.Configurations.Add(new ConfiguracionTipoIVA());
      modelBuilder.Configurations.Add(new ConfiguracionArticulos());

    }
  }

  #region Clases para configurar mapeo de E-F


  public class ConfiguracionArticulos : EntityTypeConfiguration<enTArticulo>
  {
      public ConfiguracionArticulos()
      {
          ToTable("TArticulo");
          HasKey(et => et.IdArticulo);
         
      
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
      //HasOptional<enTCategoriaRecurso>(et => et.Categoria).WithOptionalDependent();
      HasOptional(et => et.Categoria).WithMany().Map(x => x.MapKey("IdCategoria"));
      HasOptional(et => et.SituacionAFIP).WithMany().Map(x => x.MapKey("IdTipoIVA"));
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

  public class ConfiguracionCategorias : EntityTypeConfiguration<enTCategoriaRecurso>
  {
    public ConfiguracionCategorias()
    {
      ToTable("TCategoriaRecurso");
      HasKey(et => et.IdCategoria);
    }
  }

    
  #endregion




}
