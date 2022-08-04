using Blazored.Toast;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using QLSVWasm.Services;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace QLSVWasm
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddBlazoredToast();

            builder.Services.AddTransient<ISinhVienApiClient, SinhVienApiClient>();
            builder.Services.AddTransient<INganhApiClient, NganhApiClient>();
            builder.Services.AddTransient<IMonHocApiClient, MonHocApiClient>();
            builder.Services.AddTransient<ILopApiClient, LopApiClient>();
            builder.Services.AddTransient<IDiemApiClient, DiemApiClient>();
            builder.Services.AddTransient<IUserApiClient, UserApiClient>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:5001") });

            await builder.Build().RunAsync();
        }
    }
}
