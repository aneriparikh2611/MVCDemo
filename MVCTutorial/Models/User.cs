namespace MVCTutorial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            UserRoles = new HashSet<UserRole>();
            Users1 = new HashSet<User>();
            Users11 = new HashSet<User>();
            Users12 = new HashSet<User>();
        }

        public long Id { get; set; }

        public int AccessFailedCount { get; set; }

        [StringLength(64)]
        public string AuthenticationSource { get; set; }

        public string ConcurrencyStamp { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public long? DeleterUserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DeletionTime { get; set; }

        [Required]
        [StringLength(256)]
        public string EmailAddress { get; set; }

        [StringLength(328)]
        public string EmailConfirmationCode { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public bool IsEmailConfirmed { get; set; }

        public bool IsLockoutEnabled { get; set; }

        public bool IsPhoneNumberConfirmed { get; set; }

        public bool IsTwoFactorEnabled { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastLoginTime { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastModificationTime { get; set; }

        public long? LastModifierUserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LockoutEndDateUtc { get; set; }

        [Required]
        [StringLength(32)]
        public string Name { get; set; }

        [Required]
        [StringLength(256)]
        public string NormalizedEmailAddress { get; set; }

        [Required]
        [StringLength(32)]
        public string NormalizedUserName { get; set; }

        [Required]
        [StringLength(128)]
        public string Password { get; set; }

        [StringLength(328)]
        public string PasswordResetCode { get; set; }

        public string PhoneNumber { get; set; }

        public Guid? ProfilePictureId { get; set; }

        public string SecurityStamp { get; set; }

        public bool ShouldChangePasswordOnNextLogin { get; set; }

        [Required]
        [StringLength(32)]
        public string Surname { get; set; }

        public int? TenantId { get; set; }

        [Required]
        [StringLength(32)]
        public string UserName { get; set; }

        public string SignInToken { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? SignInTokenExpireTimeUtc { get; set; }

        public string GoogleAuthenticatorKey { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserRole> UserRoles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users1 { get; set; }

        public virtual User User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users11 { get; set; }

        public virtual User User2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users12 { get; set; }

        public virtual User User3 { get; set; }
    }
}
