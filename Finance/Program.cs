using Finance.Data;
using Finance.View.Planner;
using MeuProjeto;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Finance
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            //var configuration = new ConfigurationBuilder()
            //   .SetBasePath(Directory.GetCurrentDirectory())
            //   .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            //   .Build();

            var services = new ServiceCollection();
            //ConfigureServices(services, configuration);

            //var serviceProvider = services.BuildServiceProvider();
            //var context = serviceProvider.GetRequiredService<FinanceDbContext>();
            //context.Database.EnsureCreated();
            ApplyMigrations();

            Application.SetCompatibleTextRenderingDefault(false);

            //TODO: validar se já existe o usuário cadastrado, se não abrir Login
            Application.Run(new Planner());
        }

        private static void ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FinanceDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
        private static void ApplyMigrations()
        {
            try
            {
                var _context = new FinanceDbContext();

                if (_context.Database.GetPendingMigrations().Any())
                    _context.Database.Migrate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao aplicar migrações: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}