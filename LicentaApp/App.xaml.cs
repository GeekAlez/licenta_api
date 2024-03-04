using LicentaApp.Data;
using LicentaApp.Models;

namespace LicentaApp
{
    public partial class App : Application
    {
        public static WebAPIDatabase Database { get; private set; }
        public App()
        {
            InitializeComponent();
            Database = new WebAPIDatabase(new Data.LicentaService<Object>());

            MainPage = new NavigationPage(new AppShell());
        }
    }
}