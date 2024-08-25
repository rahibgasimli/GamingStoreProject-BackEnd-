using GamingStoreTekrar.Abstractions;
using GamingStoreTekrar.Data;
using GamingStoreTekrar.Entities;
using GamingStoreTekrar.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});
builder.Services.AddIdentity<AppUser, IdentityRole>()
        .AddDefaultTokenProviders()
        .AddEntityFrameworkStores<AppDbContext>();

builder.Services.ConfigureApplicationCookie(opt =>
{
    opt.LoginPath = "/Auth/Login";
    opt.AccessDeniedPath = "/Auth/Login";
});
builder.Services.AddSession();
builder.Services.AddScoped<IStorageService, LocalStorageService>();
//builder.Services.AddScoped<IStorageService, CloudinaryStorageService>(_ => new CloudinaryStorageService(new()
//{
//    CloudName = builder.Configuration["Cloudinary:CloudName"],
//    ApiKey = builder.Configuration["Cloudinary:ApiKey"],
//    ApiSecret = builder.Configuration["Cloudinary:ApiSecret"],
//}));

builder.Services.AddScoped<IEmailService, EmailService>(_ => new EmailService(new()
{
    Name = builder.Configuration["EmailCredentials:Gmail:Name"],
    From = builder.Configuration["EmailCredentials:Gmail:From"],
    Host = builder.Configuration["EmailCredentials:Gmail:Host"],
    Port = Convert.ToInt32(builder.Configuration["EmailCredentials:Gmail:Port"] ?? "465"),
    User = builder.Configuration["EmailCredentials:Gmail:User"],
    Pass = builder.Configuration["EmailCredentials:Gmail:Pass"],
}));

builder.Services.AddAuthentication()
    .AddCookie("AdminAuth", opt =>
    {
        opt.LoginPath = "/admin_panel/auth/login";
        opt.AccessDeniedPath = "/admin_panel/auth/login";
    });



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

app.UseAuthentication();
app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
