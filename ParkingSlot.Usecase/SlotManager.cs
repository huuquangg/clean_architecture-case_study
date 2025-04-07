
using System.Threading.Tasks;
using ParkingSlot.Entities;
using ParkingSlot.Usecase;

public class SlotManager
(
    ISlotRepository slotRepository
)
{
    private readonly ISlotRepository _slotRepository = slotRepository;

    public async Task<IEnumerable<Slot>> GetAllSlots()
    {
        try
        {
            return await _slotRepository.GetAllSlot();
        }
        catch
        {
            throw;
        }
    }

    public async Task AddSlot(Slot slot)
    {
        try
        {
            Console.WriteLine("22222222222222222");

            await _slotRepository.AddSlot(slot);
        }
        catch
        {
            throw;
        }
    }
}