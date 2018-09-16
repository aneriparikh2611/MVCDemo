namespace MVCTutorial
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Course")]
    public partial class Course
    {
        public int Id { get; set; }

        [Column("Course")]
        [StringLength(50)]
        public string Course1 { get; set; }

        public string CourseDetails { get; set; }
    }
}
