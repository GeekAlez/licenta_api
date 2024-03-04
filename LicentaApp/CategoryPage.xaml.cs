using LicentaApp.Models;
using Microsoft.Maui.Controls;
using LicentaApp.Data;


namespace LicentaApp;

public partial class CategoryPage : ContentPage
{
	public CategoryPage()
	{
		InitializeComponent();
        BindingContext = new A();

    }

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var slist = (A)BindingContext;
        await App.Database.SaveObjectAsync(slist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var plist = (A)BindingContext;
        await App.Database.DeleteObjectAsync(plist);
        await Navigation.PopAsync();
    }
}
