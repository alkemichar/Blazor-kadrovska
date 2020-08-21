using System;
using System.Net.Http;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using AKSoftware.Localization.MultiLanguages;
using System.Reflection;
using System.Globalization;
using BlazorMovies.Client.Helpers;
using BlazorApp.Client.Repository;

namespace BlazorApp.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddSingleton(new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddLangaugeContainer(Assembly.GetExecutingAssembly(), CultureInfo.GetCultureInfo("hr-HR"));
            builder.Services.AddScoped<IHttpService, HttpService>();
            builder.Services.AddScoped<IDjelatnikRepository, DjelatnikRepository>();

            await builder.Build().RunAsync();
        }
    }
}
