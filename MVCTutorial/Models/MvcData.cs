namespace MVCTutorial.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MvcData : DbContext
    {
        public MvcData()                                                                                      
            : base("name=MvcData")    
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public System.Data.Entity.DbSet<MVCTutorial.Models.Student> Students { get; set; }
    }
}
