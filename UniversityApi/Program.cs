using Microsoft.EntityFrameworkCore;
using UniversityApi.DataAccess;



var builder = WebApplication.CreateBuilder(args);

const string CONNECTIONNAME = "UniversityDb";
var connection = builder.Configuration.GetConnectionString(CONNECTIONNAME);
ServerVersion version = ServerVersion.AutoDetect(connection);


builder.Services.AddDbContext<UniversityDBContext>(options => options.UseMySql(connection, version));

// Add services to the container.

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
