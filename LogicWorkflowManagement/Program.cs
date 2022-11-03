using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace LogicWorkflowManagement
{
    internal static class Program
    {
        public static IConfigurationRoot Configuration { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            IConfigurationBuilder Builder = new ConfigurationBuilder();

#if DEBUG
            Builder = Builder.AddUserSecrets<TestbedSecrets>();

#endif

            Configuration = Builder.Build();

            TestbedSecrets Secrets = Configuration.GetSection(nameof(TestbedSecrets)).Get<TestbedSecrets>();

            Application.Run(new Form1(Secrets));
        }
    }
}