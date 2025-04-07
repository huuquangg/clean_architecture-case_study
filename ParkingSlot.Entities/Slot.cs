namespace ParkingSlot.Entities;

public class Slot
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public bool IsOccupied { get; set; } = false;
    public DateTime? OccupiedAt { get; set; } = null;
    public DateTime? FreeAt { get; set; } = null;
}
