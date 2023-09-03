namespace Shikka.Core.Entities
{
    public class StudentClass
    {
        public virtual Guid StudentClassID { get; set; }
        public Guid StudentID { get; set; }
        public virtual Guid ClassDetailsID { get; set; }
    }
