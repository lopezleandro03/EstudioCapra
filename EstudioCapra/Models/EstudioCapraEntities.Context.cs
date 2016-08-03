﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EstudioCapra.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EstudioCapraEntities : DbContext
    {
        public EstudioCapraEntities()
            : base("name=EstudioCapraEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Contrato> Contratoes { get; set; }
        public virtual DbSet<ContratoEmpleado> ContratoEmpleadoes { get; set; }
        public virtual DbSet<Empleado> Empleadoes { get; set; }
        public virtual DbSet<Etapa> Etapas { get; set; }
        public virtual DbSet<EtapaRecursoFisico> EtapaRecursoFisicoes { get; set; }
        public virtual DbSet<EtapaServicio> EtapaServicios { get; set; }
        public virtual DbSet<ObjetoMultimedia> ObjetoMultimedias { get; set; }
        public virtual DbSet<RecursoFisico> RecursoFisicoes { get; set; }
        public virtual DbSet<Rol> Rols { get; set; }
        public virtual DbSet<TipoServicio> TipoServicios { get; set; }
        public virtual DbSet<TipoTarea> TipoTareas { get; set; }
        public virtual DbSet<EtapaObjectoMultimedia> EtapaObjectoMultimedias { get; set; }
        public virtual DbSet<EtapaTarea> EtapaTareas { get; set; }
        public virtual DbSet<ItemMenu> ItemMenus { get; set; }
        public virtual DbSet<RoleMenu> RoleMenus { get; set; }
        public virtual DbSet<Tarea> Tareas { get; set; }
        public virtual DbSet<TareaEmpleado> TareaEmpleadoes { get; set; }
        public virtual DbSet<TipoRecursoFisico> TipoRecursoFisicoes { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UsuarioRol> UsuarioRols { get; set; }
        public virtual DbSet<Servicio> Servicios { get; set; }
    }
}
