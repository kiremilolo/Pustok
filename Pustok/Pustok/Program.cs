using Microsoft.EntityFrameworkCore;
using Pustok.DAL;
using Pustok.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddDbContext<PustokDbContext>(opt =>
{
    opt.UseSqlServer("Server=A3-D-02\\SQLEXPRESS;Database=PustokDb;Trusted_Connection=true");
});

builder.Services.AddScoped<LayoutServices>();
//builder.Services.AddSession(opt =>
//{
//    opt.IdleTimeout= TimeSpan.FromSeconds(10);
//});

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
//app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
