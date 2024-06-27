using Finance.Model.Data;
using System.Windows.Forms;

namespace Finance
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            using (var dbContext = new FinanceDbContext())
            {
                dbContext.Database.EnsureCreated(); // Garante que o banco de dados seja criado (apenas para fins de desenvolvimento)

                Application.Run(new Form1());
            }
        }
    }
}