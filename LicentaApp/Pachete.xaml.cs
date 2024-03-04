using LicentaApp.Models;
namespace LicentaApp;

public partial class Pachete : ContentPage
{
    public Pachete()
    {
        InitializeComponent();
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();
        listView.ItemsSource = await App.Database.GetObjectsAsync();
    }
    async void OnPachetAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pachete
        {
            BindingContext = new Object()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new Pachete
            {
                BindingContext = e.SelectedItem as Object
            });
        }
    }
}