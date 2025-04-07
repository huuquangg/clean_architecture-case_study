using Microsoft.EntityFrameworkCore;
using ParkingSlot.Infrastructure;
using ParkingSlot.Infrastructure.Models;
using ParkingSlot.Usecase;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();

builder.Services.AddScoped<ISlotRepository, InMemISlotRepository>();
builder.Services.AddScoped<SlotManager>();

builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseSqlite("Data Source= D:\\SpaceX\\ParkingSlot\\ParkingSlot.Infrastructure\\Database\\parkingslot.db"));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

