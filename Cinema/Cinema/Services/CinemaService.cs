using Cinema.Models;

namespace Cinema.Services
{
    public static class CinemaService
    {
        public static List<Sala> Sale { get; set; } = new List<Sala>
        {
            new Sala { Id = 1, Name = "SALA NORD" },
            new Sala { Id = 2, Name = "SALA EST" },
            new Sala { Id = 3, Name = "SALA SUD" }
        };

        public static List<Ticket> Tickets { get; set; } = new List<Ticket>();

        public static void AddTicket(User user, int salaId, bool isReduced)
        {
            var sala = Sale.FirstOrDefault(h => h.Id == salaId);
            if (sala != null && sala.SoldTickets < sala.TotalSeats)
            {
                Tickets.Add(new Ticket
                {
                    Id = Tickets.Count + 1,
                    User = user,
                    Sala = sala,
                    IsReduced = isReduced
                });

                sala.SoldTickets++;
                if (isReduced)
                {
                    sala.ReducedTickets++;
                }
            }
        }
    }
}
