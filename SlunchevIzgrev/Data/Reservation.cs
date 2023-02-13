namespace SlunchevIzgrev.Data
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ComeInDate { get; set; }
        public DateTime LastDate { get; set; }
        public string UserId { get; set; }
        public User Users { get; set; }
        public int RoomId { get; set; }
        public Room Rooms { get; set; }
    }
}
