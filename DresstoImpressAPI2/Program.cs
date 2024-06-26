using DresstoImpressAPI.Repositories;
using DresstoImpressAPI2.Data;
using DresstoImpressAPI2.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IOutfitService, OutfitService>();
builder.Services.AddScoped<IClothingSeasonService, ClothingSeasonService>();
builder.Services.AddScoped<IWeatherTypeService, WeatherTypeService>();
Builder.Services.AddScoped<ITemperatureService, TemperatureService>();
Builder.Services.AddScoped<IUserOccupationService, UserOccupationService>();
builder.Services.AddDbContext<DbContextClass>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

