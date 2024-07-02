namespace ProyectoHotel.Models;

public class Guest {
    public int GuestId {get; set;}
    public string Name { get; set; }
    public int Rut { get; set; }
    public int CellPhone { get; set; }

    public ICollection<Reservation> Reservations {get; set;} = new List<Reservation>();
    
}