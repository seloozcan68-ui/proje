using Microsoft.EntityFrameworkCore;
using proje.Data;

var builder = WebApplication.CreateBuilder(args);

// SQLite baðlantýsý
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();
