using LicentaApp;

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
        
    }

    private void OnButtonClicked(object sender, EventArgs e)
    {
        var categorii = new Categorii();
        Navigation.PushAsync(categorii);
    }
}

