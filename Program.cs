using Creator.ABA.Forms.Payee;
using Creator.ABA.Forms.Payer;
using Creator.ABA.Forms.Transactions;
using Creator.ABA.Helpers;
using Creator.ABA.Helpers.Interfaces;
using Creator.ABA.Services;
using Creator.ABA.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Creator.ABA
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Set up DI
            var services = new ServiceCollection();

            // Load configuration from appsettings.json
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            // Register HttpClient for AusPayNetHelper (API key retrieval) with base URL from config
            services.AddHttpClient("AusPayNet", client =>
            {
                client.BaseAddress = new Uri(config["ApiEndpoints:AusPayNet"]);
            });

            // Register HttpClient for BsbLookupService (API requests) with base URL from config
            services.AddHttpClient("BsbLookup", client =>
            {
                client.BaseAddress = new Uri(config["ApiEndpoints:BsbLookup"]);
                client.DefaultRequestHeaders.Add("Cache-Control", "no-cache");
                client.DefaultRequestHeaders.Add("Accept", "application/json");
            });


            // Register services
            services.AddSingleton(typeof(ISettingsProvider<>), typeof(SettingsProvider<>));
            services.AddSingleton<IFormFactory, FormFactory>();
            services.AddSingleton<IBsbLookupService, BsbLookupService>();
            services.AddSingleton<IAusPayNetHelper, AusPayNetHelper>();
            services.AddSingleton<IBsbValidationHelper, BsbValidationHelper>();

            // Register forms
            services.AddTransient<Main>();
            services.AddTransient<AddTransaction>();
            services.AddTransient<AddPayee>();
            services.AddTransient<ManagePayee>();
            services.AddTransient<ManagePayees>();
            services.AddTransient<AddPayer>();
            services.AddTransient<ManagePayer>();
            services.AddTransient<ManagePayers>();
            services.AddTransient<SetActivePayer>();

            using var serviceProvider = services.BuildServiceProvider();

            // Run the main form using DI
            var mainForm = serviceProvider.GetRequiredService<Main>();
            Application.Run(mainForm);
        }
    }
}
