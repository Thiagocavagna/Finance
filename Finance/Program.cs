using Finance.Data;
using Finance.Data.Repositories;
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
          
            var services = new ServiceCollection();            
            ApplyMigrations();

            Application.SetCompatibleTextRenderingDefault(false);

            var userRepository = new UserRepository();

            if(userRepository.IsUserRegistered())
                Application.Run(new Login());
            else
                Application.Run(new Register());
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