﻿

namespace ApiPersona.Models
{
    using System.Data.Entity;
    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ApiPersona.Models.Persona> Personas { get; set; }
    }
}