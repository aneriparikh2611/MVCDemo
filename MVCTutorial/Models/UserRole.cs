namespace MVCTutorial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserRole
    {
        public long Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public int RoleId { get; set; }

        public int? TenantId { get; set; }

        public long UserId { get; set; }

        public virtual User User { get; set; }
    }
}
