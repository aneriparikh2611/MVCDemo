namespace MVCTutorial.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class WorkItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkItem()
        {
            WorkItems1 = new HashSet<WorkItem>();
        }

        public int Id { get; set; }

        [StringLength(4000)]
        public string Description { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DueDate { get; set; }

        [StringLength(4000)]
        public string InitialComment { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public int? PercentComplete { get; set; }

        public int? Priority { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? StartDate { get; set; }

        [StringLength(255)]
        public string Tags { get; set; }

        public int? TenantId { get; set; }

        public int? ProjectId { get; set; }

        public int? ParentWorkItemId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreationTime { get; set; }

        public long? CreatorUserId { get; set; }

        public long? DeleterUserId { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? DeletionTime { get; set; }

        public bool IsDeleted { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime? LastModificationTime { get; set; }

        public long? LastModifierUserId { get; set; }

        public int Status { get; set; }

        public int? WorkItemTypeId { get; set; }

        public bool AllApprovers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkItem> WorkItems1 { get; set; }

        public virtual WorkItem WorkItem1 { get; set; }
    }
}
