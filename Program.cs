using Microsoft.EntityFrameworkCore;
using LanchesMVC.Models;
using LanchesMVC.Repositories;
using LanchesMVC.Repositories.Interfaces;
using Microsoft.AspNetCore.Identity;
using LanchesMVC.Services;
using ReflectionIT.Mvc.Paging;
using LanchesMVC.Areas.Admin.Services;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddPaging(options =>
    {
        options.ViewName = "Bootstrap4";
        options.PageParameterName = "pageindex";
    }
);

builder.Services.AddEntityFrameworkNpgsql().AddDbContext<AppDBContext>(
    options => options.UseNpgsql("User ID=root;Password=postgres;Host=host.docker.internal;Port=5432;Database=lanches;Pooling=true;")
);

builder.Services.AddIdentity<IdentityUser, IdentityRole>()
    .AddEntityFrameworkStores<AppDBContext>()
    .AddDefaultTokenProviders();

builder.Services.AddTransient<ILanchesRepository, LancheRepository>();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<IPedidoRepository, PedidoRepository>();
builder.Services.AddScoped<RelatorioVendaService>();
builder.Services.Configure<ConfiguracaoImagens>(builder.Configuration.GetSection("ConfiguracaoPastaImagens"));

builder.Services.AddAuthorization(options =>
    {
        options.AddPolicy("Admin",
            politica =>
            {
                politica.RequireRole("Admin");
            }
        );
    }
);

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
app.UseAuthentication();
app.UseAuthorization();

DatabaseManagementService.MigrationInitialisation(app);

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "admin",
    pattern: "{area:exists}/{controller=Admin}/{action=Index}/{id?}"
    );

    endpoints.MapAreaControllerRoute(
        name: "categoriaFiltro",
        areaName: "Lanches",
        pattern: "Lanche/{controller=Lanche}/{action=List}/{categoria?}"
    );

    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}"
    );
});

app.Run();