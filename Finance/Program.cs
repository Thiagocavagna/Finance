using Finance.Model.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Finance
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var configuration = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
               .Build();

            var services = new ServiceCollection();
            ConfigureServices(services, configuration);

            var serviceProvider = services.BuildServiceProvider();
            var context = serviceProvider.GetRequiredService<FinanceDbContext>();
            context.Database.EnsureCreated();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FinanceDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}