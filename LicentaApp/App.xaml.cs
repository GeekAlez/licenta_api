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
            Database = new WebAPIDatabase(new LicentaService());

            MainPage = new NavigationPage(new Pachete());
        }
    }
}