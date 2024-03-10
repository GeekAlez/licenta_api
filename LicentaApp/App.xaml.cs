using LicentaApp.Data;
using LicentaApp.Models;

namespace LicentaApp
{
    public partial class App : Application
    {
        public static WebAPIDatabase Database { get; private set; }
        public static PachetDatabase DatabasePachet { get; private set; }
        public static RestaurantDatabase DatabaseRestaurant { get; private set; }


        public App()
        {
            InitializeComponent();
            Database = new WebAPIDatabase(new CategoryService());
            DatabasePachet = new PachetDatabase(new PachetService());
            DatabaseRestaurant = new RestaurantDatabase(new RestaurantService());


            MainPage = new NavigationPage(new AppShell());
        }
    }
}