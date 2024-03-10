using LicentaApp;
using LicentaApp.Models;

namespace LicentaApp;

public partial class Categorii : ContentPage
{
    public Categorii()
    {
        InitializeComponent();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetCategoryAsync();
    }
    async void OnCategoryAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new CategoryPage
        {
            BindingContext = new Category()
        }) ;
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new CategoryPage
            {
                BindingContext = e.SelectedItem as Category
            });
        }
    }
}

