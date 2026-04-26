using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using eproject_prep2.Data;
using eproject_prep2.Areas.Identity.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("eproject_prep2ContextConnection") ?? throw new InvalidOperationException("Connection string 'eproject_prep2ContextConnection' not found.");;

builder.Services.AddDbContext<eproject_prep2Context>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<eproject_prep2User>(options => options.SignIn.RequireConfirmedAccount = true).AddEntityFrameworkStores<eproject_prep2Context>();

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
