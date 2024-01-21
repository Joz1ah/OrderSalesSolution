using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using OrderSalesApp.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress)
}) ;

builder.Services.AddScoped<IOrderService, ClientOrderService>();

await builder.Build().RunAsync();
