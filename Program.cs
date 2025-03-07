using Microsoft.EntityFrameworkCore;
using AttendanceApp.Data;                   // Sesuaikan dengan namespace Anda
using Microsoft.OpenApi.Models;             // Untuk OpenAPI info
using Microsoft.Extensions.DependencyInjection; // Pastikan untuk AddSwaggerGen
using Microsoft.AspNetCore.Builder;         // Pastikan untuk UseSwagger/UseSwaggerUI

var builder = WebApplication.CreateBuilder(args);

// 1. Registrasi EF Core InMemory
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("AttendanceDb"));

// 2. Aktifkan controller-based API
builder.Services.AddControllers();

// 3. Aktifkan (opsional) Swagger (OpenAPI)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Attendance API", Version = "v1" });
});

// Build app
var app = builder.Build();

// 4. Gunakan Swagger (OpenAPI) jika environment Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();        // Mem-serve swagger.json
    app.UseSwaggerUI(c =>    // Mem-serve Swagger UI
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "Attendance API v1");
    });
}

// 5. Middleware opsional
app.UseHttpsRedirection();

// 6. Map ke Controller
app.MapControllers();

// 7. Jalankan
app.Run();
