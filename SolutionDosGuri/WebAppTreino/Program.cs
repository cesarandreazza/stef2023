using WebAppTreino.Extensions;
using Microsoft.EntityFrameworkCore;
using WebAppTreino.Databases;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped();
var connectionString = builder.Configuration["MONGODB_URI"];
builder.Services.AddDbContext<AppDbContext>(options => options.UseMongoDB(connectionString, "stef2023"));
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
