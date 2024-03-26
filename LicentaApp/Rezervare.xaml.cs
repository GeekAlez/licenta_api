using System.Text.RegularExpressions;
namespace LicentaApp;


public partial class Rezervare : ContentPage
{
	public Rezervare()
	{
	InitializeComponent();
    LoadData();
    }

    private async void LoadData()
    {
        try
        {
            // Assuming GetLocationsAsync is a method in App.DatabaseRestaurant that retrieves locations
            var nume = await App.DatabaseRestaurant.GetRestaurantAsync();

            if (nume != null && nume.Any())
            {
                // Bind the retrieved locations to the Picker
                pickerrestaurant.ItemsSource = nume;
            }
            else
            {
                // Handle the case where no locations are available
                // You might want to show an error message or take appropriate action
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading data: {ex.Message}");
        }

    }

}