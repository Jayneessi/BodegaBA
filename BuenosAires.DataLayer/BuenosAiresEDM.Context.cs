﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BuenosAires.DataLayer
{
    using BuenosAires.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class base_datosEntities : DbContext
    {
        public base_datosEntities()
            : base("name=base_datosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AnwoStockProducto> AnwoStockProducto { get; set; }
        public virtual DbSet<auth_group> auth_group { get; set; }
        public virtual DbSet<auth_group_permissions> auth_group_permissions { get; set; }
        public virtual DbSet<auth_permission> auth_permission { get; set; }
        public virtual DbSet<auth_user> auth_user { get; set; }
        public virtual DbSet<auth_user_groups> auth_user_groups { get; set; }
        public virtual DbSet<auth_user_user_permissions> auth_user_user_permissions { get; set; }
        public virtual DbSet<authtoken_token> authtoken_token { get; set; }
        public virtual DbSet<django_admin_log> django_admin_log { get; set; }
        public virtual DbSet<django_content_type> django_content_type { get; set; }
        public virtual DbSet<django_migrations> django_migrations { get; set; }
        public virtual DbSet<django_session> django_session { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<GuiaDespacho> GuiaDespacho { get; set; }
        public virtual DbSet<PerfilUsuario> PerfilUsuario { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<SolicitudServicio> SolicitudServicio { get; set; }
        public virtual DbSet<StockProducto> StockProducto { get; set; }
    }
}
