using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using System.Reflection;
using Villa.Business.Extensions;
using Villa.DataAccess.Context;
using Villa.DataAccess.Extensions;
using Villa.Entity.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.LoadServiceLayerExtension();
builder.Services.LoadDataLayerExtension();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddSession();

builder.Services.ConfigureApplicationCookie(options =>
{
    // Cookie settings
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromDays(5);

    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
    options.SlidingExpiration = true;
});

var mongoDb = new MongoClient(builder
    .Configuration
    .GetConnectionString("MongoConnection"))
    .GetDatabase(builder.Configuration.GetSection("DatabaseName").Value);

builder.Services.AddDbContext<VillaContext>(opt =>
{
    opt.UseMongoDB(mongoDb.Client, mongoDb.DatabaseNamespace.DatabaseName);
});

builder.Services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<VillaContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

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
app.UseSession();
app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute(
        name: "Admin",
        areaName: "Admin",
        pattern: "Admin/{controller=Home}/{action=Index}/{id?}"
        );
    endpoints.MapDefaultControllerRoute();
});
app.Run();
