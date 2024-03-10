using LicentaApp.Models;
using System.Diagnostics;

namespace LicentaApp;

public partial class RestaurantPage : ContentPage
{
    public RestaurantPage()
    {
        InitializeComponent();
        Restaurant restaurant = new Restaurant();
        BindingContext = restaurant;
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        try
        {
            var slist = (Restaurant)BindingContext;

            if (slist != null)
            {
                // Obiectul BindingContext nu este nul, poți continua cu operațiunile dorite.
                await App.DatabaseRestaurant.SaveRestaurantAsync(slist);
                await Navigation.PopAsync();
            }
            else
            {
                // Obiectul BindingContext este nul, afișează un mesaj de eroare sau iei alte măsuri.
                Console.WriteLine("Obiectul BindingContext este nul în OnSaveButtonClicked.");
            }
        }
        catch (Exception ex)
        {
            Debug.WriteLine($"Eroare la salvare: {ex.Message}");
        }
    }


    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        try
        {
            var plist = (Restaurant)BindingContext;
            await App.DatabaseRestaurant.DeleteRestaurantAsync(plist);
            await Navigation.PopAsync();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare în OnSaveButtonClicked: {ex.Message}");
        }
    }
}