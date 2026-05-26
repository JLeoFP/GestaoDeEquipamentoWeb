//ASP.NET Core
//builder de un servidor web local.
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
// MVC
builder.Services.AddControllersWithViews();

// creacion de instancia de servidor web
WebApplication app = builder.Build();

//Middlewares : funciones que realiza en cada llamado que va a recibir nuestro servidor.
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();

app.Run();