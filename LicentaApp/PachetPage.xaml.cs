using LicentaApp.Models;
using LicentaApp.Data;

namespace LicentaApp;

public partial class PachetPage : ContentPage
{
	public PachetPage()
	{
		InitializeComponent();
	}

    async void OnSaveButtonClicked(object sender, EventArgs e)
    {
        var plist = (Pachet)BindingContext;
        await App.Database.SavePachetAsync(plist);
        await Navigation.PopAsync();
    }
    async void OnDeleteButtonClicked(object sender, EventArgs e)
    {
        var slist = (Pachet)BindingContext;
        await App.Database.DeletePachetAsync(slist);
        await Navigation.PopAsync();
    }
}