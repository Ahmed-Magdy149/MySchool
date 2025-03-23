using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MySchool.Shared.Services;
using MySchool.Web.Client.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

// Add device-specific services used by the MySchool.Shared project
builder.Services.AddSingleton<IFormFactor, FormFactor>();

await builder.Build().RunAsync();
