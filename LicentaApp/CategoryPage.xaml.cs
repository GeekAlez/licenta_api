using LicentaApp.Models;
using Microsoft.Maui.Controls;
using LicentaApp.Data;
using System.Diagnostics;


namespace LicentaApp;

public partial class CategoryPage : ContentPage
{
	public CategoryPage()
	{
		InitializeComponent();
        Category category = new Category();
        BindingContext = category;
    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        try
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
        }catch (Exception ex)
        {
            Debug.WriteLine($"Eroare la salvare: {ex.Message}");
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
