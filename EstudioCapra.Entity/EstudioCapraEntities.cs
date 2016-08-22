namespace EstudioCapra.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EstudioCapraEntities : DbContext
    {
        public EstudioCapraEntities()
            : base("name=EstudioCapraEntities")
        {
        }

        public virtual DbSet<Cliente> Cliente { get; set; }
        public virtual DbSet<Contrato> Contrato { get; set; }
        public virtual DbSet<ContratoEmpleado> ContratoEmpleado { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Etapa> Etapa { get; set; }
        public virtual DbSet<EtapaRecursoFisico> EtapaRecursoFisico { get; set; }
        public virtual DbSet<ObjetoMultimedia> ObjetoMultimedia { get; set; }
        public virtual DbSet<RecursoFisico> RecursoFisico { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<Servicio> Servicio { get; set; }
        public virtual DbSet<Tarea> Tarea { get; set; }
        public virtual DbSet<TipoServicio> TipoServicio { get; set; }
        public virtual DbSet<TipoTarea> TipoTarea { get; set; }
        public virtual DbSet<ItemMenu> ItemMenu { get; set; }
        public virtual DbSet<RoleMenu> RoleMenu { get; set; }
        public virtual DbSet<TareaEmpleado> TareaEmpleado { get; set; }
        public virtual DbSet<TipoRecursoFisico> TipoRecursoFisico { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
        public virtual DbSet<UsuarioRol> UsuarioRol { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .HasMany(e => e.Contrato)
                .WithRequired(e => e.Cliente)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Contrato>()
                .Property(e => e.Costo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Contrato>()
                .Property(e => e.Saldo)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContratoEmpleado>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<ContratoEmpleado>()
                .Property(e => e.Salario)
                .HasPrecision(19, 4);

            modelBuilder.Entity<ContratoEmpleado>()
                .Property(e => e.ModoDePago)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .Property(e => e.Especializacion)
                .IsUnicode(false);

            modelBuilder.Entity<Empleado>()
                .HasMany(e => e.TareaEmpleado)
                .WithRequired(e => e.Empleado)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Etapa>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Etapa>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Etapa>()
                .HasMany(e => e.Tarea)
                .WithRequired(e => e.Etapa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<EtapaRecursoFisico>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<ObjetoMultimedia>()
                .Property(e => e.Servidor)
                .IsUnicode(false);

            modelBuilder.Entity<ObjetoMultimedia>()
                .Property(e => e.Directorio)
                .IsUnicode(false);

            modelBuilder.Entity<ObjetoMultimedia>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<ObjetoMultimedia>()
                .Property(e => e.Tipo)
                .IsUnicode(false);

            modelBuilder.Entity<RecursoFisico>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<RecursoFisico>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<RecursoFisico>()
                .Property(e => e.Especificaciones)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.RoleMenu)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Rol>()
                .HasMany(e => e.UsuarioRol)
                .WithRequired(e => e.Rol)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Servicio>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Servicio>()
                .HasMany(e => e.Contrato)
                .WithRequired(e => e.Servicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Servicio>()
                .HasMany(e => e.Etapa)
                .WithRequired(e => e.Servicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Tarea>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Tarea>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Tarea>()
                .HasMany(e => e.TareaEmpleado)
                .WithRequired(e => e.Tarea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoServicio>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicio>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicio>()
                .Property(e => e.Atributo1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicio>()
                .Property(e => e.Atributo2)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicio>()
                .Property(e => e.Atributo3)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicio>()
                .Property(e => e.Atributo4)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicio>()
                .Property(e => e.Atributo5)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicio>()
                .Property(e => e.Atributo6)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicio>()
                .Property(e => e.Atributo7)
                .IsUnicode(false);

            modelBuilder.Entity<TipoServicio>()
                .HasMany(e => e.Servicio)
                .WithRequired(e => e.TipoServicio)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TipoTarea>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoTarea>()
                .Property(e => e.TareaTemplate)
                .IsUnicode(false);

            modelBuilder.Entity<TipoTarea>()
                .HasMany(e => e.Tarea)
                .WithRequired(e => e.TipoTarea)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ItemMenu>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<ItemMenu>()
                .Property(e => e.Controlador)
                .IsUnicode(false);

            modelBuilder.Entity<ItemMenu>()
                .Property(e => e.Accion)
                .IsUnicode(false);

            modelBuilder.Entity<ItemMenu>()
                .Property(e => e.Parametros)
                .IsUnicode(false);

            modelBuilder.Entity<TareaEmpleado>()
                .Property(e => e.Estado)
                .IsUnicode(false);

            modelBuilder.Entity<TipoRecursoFisico>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<TipoRecursoFisico>()
                .Property(e => e.Atributo1)
                .IsUnicode(false);

            modelBuilder.Entity<TipoRecursoFisico>()
                .Property(e => e.Atributo2)
                .IsUnicode(false);

            modelBuilder.Entity<TipoRecursoFisico>()
                .Property(e => e.Atrbuto3)
                .IsUnicode(false);

            modelBuilder.Entity<TipoRecursoFisico>()
                .Property(e => e.Atributo4)
                .IsUnicode(false);

            modelBuilder.Entity<TipoRecursoFisico>()
                .Property(e => e.Atributo5)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Contraseña)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefono1)
                .IsUnicode(false);

            modelBuilder.Entity<Usuario>()
                .Property(e => e.Telefono2)
                .IsUnicode(false);
        }
    }
}
