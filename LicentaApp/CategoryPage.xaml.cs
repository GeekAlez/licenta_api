using LicentaApp.Models;
using Microsoft.Maui.Controls;
using LicentaApp.Data;


namespace LicentaApp;

public partial class CategoryPage : ContentPage
{
	public CategoryPage()
	{
		InitializeComponent();
        Category category = new Category(1, "Nunta");
        BindingContext = category;
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (Category)BindingContext;

        if (slist != null)
        {
            // Obiectul BindingContext nu este nul, poți continua cu operațiunile dorite.
            await App.Database.SaveCategoryAsync(slist);
            await Navigation.PopAsync();
        }
        else
        {
            // Obiectul BindingContext este nul, afișează un mesaj de eroare sau iei alte măsuri.
            Console.WriteLine("Obiectul BindingContext este nul în OnSaveButtonClicked.");
        }
    }


    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        try
        {
            var plist = (Category)BindingContext;
            await App.Database.DeleteCategoryAsync(plist);
            await Navigation.PopAsync();
        }catch (Exception ex)
        {
            Console.WriteLine($"Eroare în OnSaveButtonClicked: {ex.Message}");
        }
    }
}
