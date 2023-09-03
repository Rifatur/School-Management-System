namespace Shikka.Core.Entities
{
    public class StudentAttendance
    {
        public virtual Guid AttendanceID { get; set; }
        public int AttendanceStatus { get; set; }
        public virtual DateTime AttendanceDate { get; set; }
        public Guid StudentClassID { get; set; }
    }
}
