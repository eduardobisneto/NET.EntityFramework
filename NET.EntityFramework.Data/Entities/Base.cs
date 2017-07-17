using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LearnNET.EntityFramework.Data.Entities
{
    public abstract class Base
    {
        [Key]
        public int Id { get; set; }

        [Column("CreatedDate", TypeName = "datetime2")]
        public DateTime CreatedDate { get; set; }

        [Column("ModifiedDate", TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }
    }
}
