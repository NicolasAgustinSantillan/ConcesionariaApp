using Microsoft.Extensions.Configuration;
using Ojeda.Concesionario.DB.DataAccess;
using System.IO;

namespace Ojeda.Concesionario
{
    internal static class Program
    {
        public static string ConnectionString { get; set; }

        [STAThread]
        static void Main()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile(Path.Combine(AppContext.BaseDirectory, "appsettings.json"), optional: false, reloadOnChange: true)
                .Build();

            ConnectionString = config.GetConnectionString("ConcesionariaDb");

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());

        }

    }
}