using Digital_Garage_Solutions_API.DBCONTEXT;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataBase>(e =>
{
    e.UseSqlServer(builder.Configuration.GetConnectionString("constr"));
});
builder.Services.AddCors(option =>
{
    option.AddPolicy("AllowFrontend", Policy =>
    {
        Policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowFrontend");

app.UseAuthorization();

app.MapControllers();

app.Run();
