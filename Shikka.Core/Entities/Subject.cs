using Shikka.Core.Entities.common;

namespace Shikka.Core.Entities
{
    public class Subject : AuditableBaseEntity
    {
        public int SubjectId { get; set; }
        public int SubjectCode { get; set; }
        public string? SubjectName { get; set; }
    }
}
