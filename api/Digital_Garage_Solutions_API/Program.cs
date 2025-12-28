using Digital_Garage_Solutions_API.DBCONTEXT;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// ================= SERVICES =================

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<DataBase>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("constr"));
});

// ✅ CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

var app = builder.Build();

// ================= MIDDLEWARE ORDER (VERY IMPORTANT) =================

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();          // 🔥 THIS WAS MISSING
app.UseCors("AllowAll");   // must be AFTER routing
app.UseAuthorization();

app.MapControllers();

app.Run();

