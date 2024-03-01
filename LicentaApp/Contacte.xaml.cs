namespace LicentaApp;

public partial class Contacte : ContentPage
{
    public Contacte()
    {
        InitializeComponent();

        var numeLabel = new Label
        {
            Text =  "Numele dumneavoastră: ",
            FontAttributes = FontAttributes.Bold,
        };

        var mailLabel = new Label
        {
            Text = "Email-ul dumneavoastră: ",
            FontAttributes = FontAttributes.Bold,
        };

        var mesajLabel = new Label
        {
            Text = "Mesajul dumneavoastră: ",
            FontAttributes = FontAttributes.Bold,
        };

        var submitButton = new Button
        {
            Text = "Trimite",
        };

       submitButton.Clicked += OnSubmitButtonClicked; 

    }

    private void OnSubmitButtonClicked(object sender, EventArgs e)
    {
        DisplayAlert("Mesaj trimis!","Mulțumim pentru mesajul dumneavoastră!!", "Cu drag echipa AgencyEvents");
    }
    private void OnLinkLabelTapped(object sender, EventArgs e)
    {
        var uri = new Uri("");
        Launcher.OpenAsync(uri);
    }
}