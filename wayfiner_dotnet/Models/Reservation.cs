using System;

namespace wayfiner_dotnet.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int TripId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Address { get; set; }
        public DateTime Date { get; set; }
        public int Cost { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}