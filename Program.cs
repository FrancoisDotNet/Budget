using Blazored.LocalStorage;
using Microsoft.AspNetCore.Blazor.Hosting;
using Microsoft.AspNetCore.Components.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Budget
{
    class Program
    {
        static void Main() => BlazorWebAssemblyHost.CreateDefaultBuilder().UseBlazorStartup<Startup>().Build().Run();
    }

    class Startup
    {
        public void ConfigureServices(IServiceCollection c) => c.AddBlazoredLocalStorage();
        public void Configure(IComponentsApplicationBuilder b) => b.AddComponent<Body>("body");
    }
}