using ControleDeContatos.Data;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

void Configuration(IConfiguration configuration)
{
    IConfiguration Configuration = configuration;
}

void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews();
    services.AddEntityFrameworkSqlServer()
        .AddDbContext<BancoContext>();
}
