namespace Specification.Logic.Library.Models
{
    public class Seat
    {
        public int Column { get; set; }
        public int Row { get; set; }
        public Availability Available { get; set; }
    }

    public enum Availability
    {
        Open,
        Closed
    }
}
