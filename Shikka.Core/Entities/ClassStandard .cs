using Shikka.Core.Entities.common;
using System.ComponentModel.DataAnnotations;

namespace Shikka.Core.Entities
{
    public class ClassStandard : AuditableBaseEntity
    {
        [Key]
        public virtual Guid StandardId { get; set; }
        public string? StandardName { get; set; }
        public string? StandardDetails { get; set; }
    }
}
