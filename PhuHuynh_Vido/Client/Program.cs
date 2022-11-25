using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using PhuHuynh_Vido.Client;
using PhuHuynh_Vido.Client.Services.IMSServices;
using PhuHuynh_Vido.Client.Services.PhuhuynhServices;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IPhuhuynhService, PhuhuynhService>();
builder.Services.AddScoped<IIMSService, IMSService>();
builder.Services.AddMudServices();
await builder.Build().RunAsync();
