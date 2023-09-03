namespace Shikka.Core.Entities
{
    public class ClassHour
    {
        public int ClassHrsId { get; set; }
        public TimeOnly TimeStart { get; set; }
        public TimeOnly TimeEnd { get; set; }
        public int ClassDay { get; set; }

    }
}
