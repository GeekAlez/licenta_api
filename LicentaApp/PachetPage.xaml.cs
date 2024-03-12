using LicentaApp.Models;
using LicentaApp.Data;
using System.Diagnostics;

namespace LicentaApp;

public partial class PachetPage : ContentPage
{
    public PachetPage()
    {
        InitializeComponent();
        Pachet pachet = new Pachet();
        BindingContext = pachet;
        Task<List<Restaurant>> restaurant= App.DatabaseRestaurant.GetRestaurantAsync();

        // Setează DataContext-ul pentru pagina ta sau controlul dorit
        BindingContext = new { Restaurante = restaurant };

    }

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