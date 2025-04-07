using System;
using System.Collections.Generic;

namespace ParkingSlot.Infrastructure.Models;

public partial class Slot
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public bool IsOccupied { get; set; }

    public DateTime? OccupiedAt { get; set; }

    public DateTime? FreeAt { get; set; }
}
