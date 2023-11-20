using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using PIM_DESENVOLTECH.Auxiliar;
using PIM_DESENVOLTECH.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//String de conexão com o SQL Server
builder.Services.AddDbContext<Contexto>
    (
        options => options.UseSqlServer(
            "Data Source=DESKtop01;" +
            "Initial Catalog=DesenvolTech_PIM; " +
            "Integrated Security=SSPI; " +
            "TrustServerCertificate=True; " +
            "Persist Security Info=False; " +
            "User Id=Matheus Borges")
    );

builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
builder.Services.AddScoped<Isessao, Sessao>();

builder.Services.AddSession(o => 
{
    o.Cookie.HttpOnly = true;
    o.Cookie.IsEssential = true;

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
app.UseAuthorization();
app.UseSession();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
