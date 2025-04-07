
using Microsoft.EntityFrameworkCore;
using ParkingSlot.Infrastructure.Models;

namespace ParkingSlot.Infrastructure;

public class InMemISlotRepository : ISlotRepository
{
    private readonly DatabaseContext _dbContext;
    public InMemISlotRepository
    (
        DatabaseContext databaseContext
    )
    {
        _dbContext = databaseContext;
    }

    public async Task<IEnumerable<Entities.Slot>> GetAllSlot()
    {
        try
        {
            var listSlot = await _dbContext.Slots.ToListAsync();
            var result = listSlot.Select(s => new Entities.Slot
            {
                Id = s.Id,
                Name = s.Name!,
                IsOccupied = s.IsOccupied,
                OccupiedAt = s.OccupiedAt,
                FreeAt = s.FreeAt,
            });
            return result;
        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task AddSlot(Entities.Slot slot)
    {
        using var transaction = await _dbContext.Database.BeginTransactionAsync();
        try
        {
            var existSlot = _dbContext.Slots.FirstOrDefault(s => s.Id == slot.Id);
            Console.WriteLine("333333333333333333333");



            if (existSlot == null)
            {
                var newSlot = new Models.Slot()
                {
                    Id = slot.Id,
                    Name = slot.Name,
                    IsOccupied = slot.IsOccupied,
                    OccupiedAt = slot.OccupiedAt,
                    FreeAt = slot.FreeAt
                };

                await _dbContext.Slots.AddAsync(newSlot);
            }

            await _dbContext.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch (Exception)
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    public Task DeleteSlot()
    {
        throw new NotImplementedException();
    }


    public Task UpdateSlotState()
    {
        throw new NotImplementedException();
    }

}
