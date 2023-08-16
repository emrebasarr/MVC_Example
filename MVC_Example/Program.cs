var builder = WebApplication.CreateBuilder(args);
//Services
builder.Services.AddMvc();//servislere MVC (Model-View-Controller) katman�n� dahil ediyoruz.

//Application
var app = builder.Build();//application derleniyor.

app.UseRouting();//url �zerinde rota tan�mlamas� aktif ediliyor.

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    //https://localhost:7228/home/ComicBook
});

app.Run();