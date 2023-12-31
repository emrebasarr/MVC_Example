var builder = WebApplication.CreateBuilder(args);
//Services
builder.Services.AddMvc();//servislere MVC (Model-View-Controller) katmanını dahil ediyoruz.

//Application
var app = builder.Build();//application derleniyor.

app.UseRouting();//url üzerinde rota tanımlaması aktif ediliyor.

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
    //https://localhost:7228/home/ComicBook
});

app.Run();