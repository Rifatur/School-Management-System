using Shikka.Core.Entities.common;
using System.ComponentModel.DataAnnotations;

namespace Shikka.Core.Entities
{
    public class ClassRoom : AuditableBaseEntity
    {
        [Key]
        public virtual Guid ClassRoomID { get; set; }
        public string? ClassroomName { get; set; }
        public string? ClassroomNumber { get; set; }
        public int? ClassroomSeat { get; set; }
    }
}
