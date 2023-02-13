namespace SlunchevIzgrev.Data
{
    public class Room
    {
        public int Id { get; set; }
        public int RoomNumber { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType RoomTypes { get; set; }
        public string Description { get; set; }
        public string Photos { get; set; }
        public decimal PricePerDay { get; set; }
        public DateTime UpDate { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
