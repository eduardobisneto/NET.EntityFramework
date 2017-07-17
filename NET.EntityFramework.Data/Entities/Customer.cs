using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnNET.EntityFramework.Data.Entities
{
    [Table("Customer")]
    public class Customer : Base
    {
        [Required]
        [StringLength(100)]
        [Column("Name", TypeName = "varchar")]
        public string Name { get; set; }

        [Required]
        [StringLength(100)]
        [Column("Email", TypeName = "varchar")]
        public string Email { get; set; }

        [Required]
        [StringLength(14)]
        [Column("Phone", TypeName = "varchar")]
        public string Phone { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}
