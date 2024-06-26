namespace Cinema.Models
{
    public class Sala
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TotalSeats { get; set; } = 120;
        public int SoldTickets { get; set; }
        public int ReducedTickets { get; set; }
    }
}
