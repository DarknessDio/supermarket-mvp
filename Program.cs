using Supermarket_mvp_2._Repositories;
using Supermarket_mvp_2.Models;
using Supermarket_mvp_2.Presenters;
using Supermarket_mvp_2.Properties;
using Supermarket_mvp_2.Views;

namespace Supermarket_mvp_2
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
            string sqlConnectionString = Settings.Default.SqlConnection2;
            IMainView view = new MainView();
            new MainPresenter(view, sqlConnectionString);
            Application.Run((Form)view);
        }
    }
}