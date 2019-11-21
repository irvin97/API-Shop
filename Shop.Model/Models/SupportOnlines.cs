using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.Model.Models
{
    [Table("SupportOnlinnes")]
    public class SupportOnlines
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Required]
        [MaxLength(50)]
        public String Name { get; set; }

        [MaxLength(50)]
        public string Department { get; set; }

        [MaxLength(50)]
        public string Skype { get; set; }

        [MaxLength]
        public string Mobile { get; set; }

        [MaxLength(50)]
        public string Email { get; set; }

        [MaxLength]
        public string Yahoo { get; set; }

        [MaxLength]
        public string Facebook { get; set; }

        [MaxLength(50)]
        public bool Status { get; set; }

        public int? DisplayOrder { get; set; }
    }
}
