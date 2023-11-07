using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using NewBlogg;
using NewBlogg.Data.Classes;
using NewBlogg.Data.Interfaces;
using NewBlogg.Handler.Classes;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IData, Data>();
builder.Services.AddScoped<Handler>();

await builder.Build().RunAsync();
