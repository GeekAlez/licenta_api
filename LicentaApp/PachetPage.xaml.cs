using LicentaApp.Models;
using LicentaApp.Data;
using System.Diagnostics;
using System.Net.Http.Json;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.iOSSpecific;

namespace LicentaApp;

public partial class PachetPage : ContentPage
{
    //IRestaurantService restaurantService;

    public PachetPage()
    {
        InitializeComponent();
        Pachet pachet = new Pachet();


        BindingContext = pachet;
        //LoadData();
        //LoadCategorie();

    }
   
     /*   private async void LoadData()
    {
        try
        {
            // Assuming GetLocationsAsync is a method in App.DatabaseRestaurant that retrieves locations
            var locatie = await App.DatabaseRestaurant.GetRestaurantAsync();

            if (locatie != null && locatie.Any())
            {
                // Bind the retrieved locations to the Picker
                pickerlocatie.ItemsSource = locatie;
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

    private async void LoadCategorie()
    {
        try
        {
            // Assuming GetLocationsAsync is a method in App.DatabaseRestaurant that retrieves locations
            var eveniment = await App.Database.GetCategoryAsync();

            if (eveniment != null && eveniment.Any())
            {
                // Bind the retrieved locations to the Picker
                pickereveniment.ItemsSource = eveniment;
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

    }*/


    async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            try
            {
                var slist = (Pachet)BindingContext;

                if (slist != null)
                {
                    // Obiectul BindingContext nu este nul, poți continua cu operațiunile dorite.
                    await App.DatabasePachet.SavePachetAsync(slist);
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
                var plist = (Pachet)BindingContext;
                await App.DatabasePachet.DeletePachetAsync(plist);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare în OnSaveButtonClicked: {ex.Message}");
            }

        }
    }

