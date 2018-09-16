namespace MVCTutorial.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MvcDemo : DbContext
    {
        public MvcDemo()
            : base("name=MvcDemo")
        {
        }

        public virtual DbSet<UserRole> UserRoles { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<WorkItem> WorkItems { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasMany(e => e.Users1)
                .WithOptional(e => e.User1)
                .HasForeignKey(e => e.CreatorUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Users11)
                .WithOptional(e => e.User2)
                .HasForeignKey(e => e.DeleterUserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Users12)
                .WithOptional(e => e.User3)
                .HasForeignKey(e => e.LastModifierUserId);

            modelBuilder.Entity<WorkItem>()
                .HasMany(e => e.WorkItems1)
                .WithOptional(e => e.WorkItem1)
                .HasForeignKey(e => e.ParentWorkItemId);
        }
    }
}
