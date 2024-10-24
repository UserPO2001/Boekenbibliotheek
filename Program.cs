using Microsoft.EntityFrameworkCore; // Ensure you have this using directive for EF Core
using Boekenbibliotheek.Models; // Add this line for LibraryContext

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Change to UseSqlite since you're using SQLite in your LibraryContext
builder.Services.AddDbContext<LibraryContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"))); 

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
