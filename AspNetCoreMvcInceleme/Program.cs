var builder = WebApplication.CreateBuilder(args);


// dependecny injection servisleri....
//builder.Services.AddControllers(); // controller yap�s�
builder.Services.AddControllersWithViews();


var app = builder.Build();

// middlewareleri kullan�yoruz.. Middleware metotlar� use ile ba�lar..

app.UseRouting();

app.UseEndpoints(conf =>
{

    conf.MapControllerRoute(
        name: "urun",
        pattern: "urunlerim/{action}",
        defaults: new { controller = "Product", action = "Index" }
        );

    conf.MapControllerRoute(
        name: "default", // default route b�t�n controllerlar i�in kullan�l�r.
        pattern: "{controller}/{action}",
        defaults: new { controller = "Home", action = "Index" }
        );
});

app.Run();
