using Shikka.Core.Entities.common;
using System.ComponentModel.DataAnnotations;

namespace Shikka.Core.Entities
{
    public class Instuctor : AuditableBaseEntity
    {
        [Key]
        public virtual Guid InstuctorID { get; set; }
        [Required]
        [StringLength(250)]
        public string InstuctorFirstName { get; set; } = string.Empty;
        [Required]
        [StringLength(250)]
        public string InstuctorLastName { get; set; } = string.Empty;
        [Required]
        public string? InstuctorEmail { get; set; }
        public string? InstuctorGender { get; set; }
        public int InstuctorPhoneNumber { get; set; }
        public DateTime? InstuctorBirthDate { get; set; }
    }
}
