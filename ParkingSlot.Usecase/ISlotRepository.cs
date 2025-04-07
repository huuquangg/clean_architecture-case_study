using ParkingSlot.Entities;

namespace ParkingSlot.Usecase;

public interface ISlotRepository
{
    public Task<IEnumerable<Slot>> GetAllSlot();
    public Task AddSlot(Slot slot);
    public Task DeleteSlot();
    public Task UpdateSlotState();
}

