using Microsoft.EntityFrameworkCore;
using PS_1_Backend.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


 builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
//using Microsoft.EntityFrameworkCore;
//using PS_1_Backend.Data;

//var builder = WebApplication.CreateBuilder(args);

//// Add DB context
//builder.Services.AddDbContext<ApplicationDbContext>(options =>
//    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//builder.Services.AddControllers();
//var app = builder.Build();

//app.UseAuthorization();
//app.MapControllers();
//app.Run();
