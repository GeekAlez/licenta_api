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
        listView.ItemsSource = await App.DatabasePachet.GetPachetAsync();
    }
    async void OnPachetAddedClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new PachetPage
        {
            BindingContext = new Pachet()
        });
    }
    async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        if (e.SelectedItem != null)
        {
            await Navigation.PushAsync(new PachetPage
            {
                BindingContext = e.SelectedItem as Pachet

            });
        }
    }
}