using Shikka.Core.Entities.common;
using System.ComponentModel.DataAnnotations;

namespace Shikka.Core.Entities
{
    public class Student : AuditableBaseEntity
    {
        [Key]
        public virtual Guid StudentID { get; set; }
        [Required]
        [StringLength(250)]
        public string StudentFirstName { get; set; } = string.Empty;
        [Required]
        [StringLength(250)]
        public string StudentLastName { get; set; } = string.Empty;
        [Required]
        public string? StudentEmail { get; set; }
        public string? StudentGender { get; set; }
        public int StudentPhoneNumber { get; set; }
        public DateTime? StudentBirthDate { get; set; }

    }
}
