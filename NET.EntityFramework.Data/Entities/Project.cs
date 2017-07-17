using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnNET.EntityFramework.Data.Entities
{
    [Table("Project")]
    public class Project : Base
    {
        [Required]
        [StringLength(100)]
        [Column("Name", TypeName = "varchar")]
        public string Name { get; set; }        

        public int CustomerId { get; set; }

        [ForeignKey("CustomerId")]
        public virtual Customer Customer { get; set; }
    }
}
