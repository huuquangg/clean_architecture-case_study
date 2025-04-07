using Microsoft.AspNetCore.Mvc;
using ParkingSlot.Entities;

public class SlotController : Controller
{
    private readonly SlotManager _slotManager;
    private readonly ILogger<SlotController> _logger;

    public SlotController
    (
        SlotManager slotManager,
        ILogger<SlotController> logger
    )
    {
        _logger = logger;
        _slotManager = slotManager;
    }

    [HttpGet("list")]
    public IActionResult GetAllSlot()
    {
        try
        {
            var slots = _slotManager.GetAllSlots();
            return Ok(slots);
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    [HttpPost("add")]
    public IActionResult AddNewSlot([FromBody] Slot slot)
    {
        try
        {
            Console.WriteLine("111111111111111");
            var slots = _slotManager.AddSlot(slot);
            return Ok(slots);
        }
        catch (System.Exception)
        {
            throw;
        }
    }
}