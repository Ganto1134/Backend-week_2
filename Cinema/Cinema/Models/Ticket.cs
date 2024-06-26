namespace Cinema.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public User User { get; set; }
        public Sala Sala { get; set; }
        public bool IsReduced { get; set; }
    }
}
