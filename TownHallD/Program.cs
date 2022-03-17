using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using TownHallD.Controllers;
using TownHallD.DataAccess;
using TownHallD.Repositories;
using TownHallD.Services;

namespace TownHallD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>


        public static ApplicationContext MyAppCxt;

        [STAThread]

        static void Main()
        {
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var form = serviceProvider.GetService<LoginForm>();
                MyAppCxt = new ApplicationContext(form);
                Application.Run(MyAppCxt);

            }

            //CreateHostBuilder().Build().Run(); - pentru crearea bazei de date
        }

        public static IHostBuilder CreateHostBuilder() =>
        Host.CreateDefaultBuilder(Array.Empty<string>())
        .UseWindowsFormsLifetime<LoginForm>()
        .ConfigureServices((hostContext, services) =>
        {
            ConfigureServices(services);
        });

        public static IHostBuilder UseWindowsFormsLifetime<TStartForm>(this IHostBuilder hostBuilder) where TStartForm : Form
        {
            return hostBuilder.ConfigureServices(delegate (HostBuilderContext hostContext, IServiceCollection services)
            {
                services.AddScoped<TStartForm>().AddSingleton((IServiceProvider provider) => new ApplicationContext(provider.GetRequiredService<TStartForm>()));
            });
        }

        static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<LoginForm>()

                .AddScoped<UserController>()
                .AddScoped<DocumentController>()
                .AddScoped<RequestController>()
                .AddScoped<HouseController>()

                .AddScoped<UserRepo>()
                .AddScoped<DocumentRepo>()
                .AddScoped<RequestRepo>()
                .AddScoped<HouseRepo>()

                .AddScoped<UserService>()
                .AddScoped<DocumentService>()
                .AddScoped<RequestService>()
                .AddScoped<HouseService>()

                .AddDbContext<DatabaseContext>(options =>
                {
                    var connectionString = "Server=127.0.0.1;Database=townhall;Uid=root;Pwd=root;";
                    Console.WriteLine(connectionString);
                    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
                })
                .AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}