using LicentaApp.Data;
using LicentaApp.Models;

namespace LicentaApp
{
    public partial class App : Application
    {
        public static CategoryListDatabase Database { get; private set; }
        public App()
        {
            InitializeComponent();
            Database = new CategoryListDatabase(new CategoryService());

            MainPage = new NavigationPage(new AppShell());
        }
    }
}