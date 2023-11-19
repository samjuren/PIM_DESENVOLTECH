using Microsoft.EntityFrameworkCore;
using PIM_DESENVOLTECH.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//String de conexão com o SQL Server
builder.Services.AddDbContext<Contexto>
    (
        options => options.UseSqlServer(
            "Data Source=SAMUEL\\SQLSERVER2022;" +
            "Initial Catalog=DesenvolTech_PIM; " +
            "Integrated Security=SSPI; " +
            "TrustServerCertificate=True; " +
            "Persist Security Info=False; " +
            "User Id=SAMUEL\\sammj")
    );

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
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.Run();
