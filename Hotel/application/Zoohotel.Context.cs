﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotel.application
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ZooHotel_Entities : DbContext
    {
        private static ZooHotel_Entities _context;
        public ZooHotel_Entities()
            : base("name=ZooHotel_Entities")
        {
        }

        public static ZooHotel_Entities Get()
        {
            if (_context == null)
                _context = new ZooHotel_Entities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<Contracts> Contracts { get; set; }
        public virtual DbSet<Maintenance> Maintenance { get; set; }
        public virtual DbSet<Owners> Owners { get; set; }
        public virtual DbSet<Pets> Pets { get; set; }
        public virtual DbSet<Type_of_animal> Type_of_animal { get; set; }
    }
}
