﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.Infra.Data.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class bdHotelEntities : DbContext
    {
        public bdHotelEntities()
            : base("name=bdHotelEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tCliente> tCliente { get; set; }
        public virtual DbSet<tHabitacion> tHabitacion { get; set; }
        public virtual DbSet<tTipo> tTipo { get; set; }
        public virtual DbSet<tVendedor> tVendedor { get; set; }
        public virtual DbSet<tAlquiler> tAlquiler { get; set; }
    }
}
