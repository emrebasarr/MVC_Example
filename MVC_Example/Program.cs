var builder = WebApplication.CreateBuilder(args);
//Services
builder.Services.AddMvc();//servislere MVC (Model-View-Controller) katmanýný dahil ediyoruz.

//Application
var app = builder.Build();//application derleniyor.

app.UseRouting();//url üzerinde rota tanýmlamasý aktif ediliyor.

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    //https://localhost:7228/home/ComicBook
});

app.Run();