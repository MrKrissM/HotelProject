namespace ProyectoHotel.Models;

public class Reservation
{
    public int Id { get; set; }
    public DateTime CheckIn { get; set; }
    public DateTime CheckOut { get; set; }
    public string RoomNumber { get; set; }

    public int GuestId {get; set;}
    public Guest Guest {get; set;}
}