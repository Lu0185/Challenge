using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Challenge.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Challenge.DataAccessLayer
{
    public class ContactContext : DbContext
    {
       
        public ContactContext() : base("ContactContext")
        { 
        }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Addresses> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}