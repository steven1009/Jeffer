﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jeffer_FERRETERIA.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class FerreteriaDBEntities : DbContext
    {
        public FerreteriaDBEntities()
            : base("name=FerreteriaDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cargo> Cargo { get; set; }
        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<DetalleProvProd> DetalleProvProd { get; set; }
        public virtual DbSet<DetalleVenta> DetalleVenta { get; set; }
        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Estado> Estado { get; set; }
        public virtual DbSet<Factura> Factura { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<proveedores> proveedores { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<TipoPago> TipoPago { get; set; }
        public virtual DbSet<USUARIO_LOGIN> USUARIO_LOGIN { get; set; }
        public virtual DbSet<Ventas> Ventas { get; set; }
        public virtual DbSet<DetalleEstado> DetalleEstadoes { get; set; }
        public virtual DbSet<DetalleEstadoUsuario> DetalleEstadoUsuarios { get; set; }
        public virtual DbSet<DetalleRole> DetalleRoles { get; set; }
    
        public virtual ObjectResult<Nullable<int>> UserPassword(string usuario, string password)
        {
            var usuarioParameter = usuario != null ?
                new ObjectParameter("usuario", usuario) :
                new ObjectParameter("usuario", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("UserPassword", usuarioParameter, passwordParameter);
        }
    }
}