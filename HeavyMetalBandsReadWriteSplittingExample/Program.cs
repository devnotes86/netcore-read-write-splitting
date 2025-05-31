using HeavyMetalBandsReadWriteSplittingExample.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using HeavyMetalBandsReadWriteSplittingExample.Services;
using HeavyMetalBandsReadWriteSplittingExample.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

// mapping DbContexts
builder.Services.AddDbContext<DbContext_Write>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("WriteDb")));

builder.Services.AddDbContext<DbContext_Read>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("ReadDb")));

// defining Dependency Injection for Service and repository
builder.Services.AddTransient<IBandsService, BandsService>();
builder.Services.AddTransient<IBandsRepository, BandsRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
