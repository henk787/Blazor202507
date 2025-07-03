using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

namespace BlazorAppAspire.Client;

class Program
{
    static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);

        await builder.Build().RunAsync();
    }
}
