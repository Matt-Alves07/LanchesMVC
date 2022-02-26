using Microsoft.EntityFrameworkCore;
using LanchesMVC.Models;
using LanchesMVC.Repositories;
using LanchesMVC.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<AppDBContext>(
    options => options.UseNpgsql("User ID=root;Password=postgres;Host=host.docker.internal;Port=5432;Database=lanches;Pooling=true;")
);

builder.Services.AddTransient<ILanchesRepository, LancheRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();

//Add session pattern
builder.Services.AddMemoryCache();
builder.Services.AddSession();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

builder.Services.AddScoped(sp => CarrinhoCompra.GetCarrinhoCompra(sp));

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
