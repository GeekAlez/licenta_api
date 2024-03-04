using LicentaApp.Models;
using System;
using System.Collections.Generic;

namespace LicentaApp
{
    public partial class Restaurante : ContentPage
    {


        public Restaurante()
        {
            InitializeComponent();
        }

        /*    {
                new Restaurant { Nume = "Wonderland", ImageSource = "wonderland.jpg", Capacitate= "2500 locuri", Locatie = "Feleacu, jud.Cluj" },
                new Restaurant { Nume = "Sun Garden", ImageSource = "sungarden.jpg", Capacitate= "450 locuri", Locatie = "Poiana Cerbului 1000, Baciu" },
                new Restaurant { Nume = "Amiral Events & Style", ImageSource = "amiral.jpg", Capacitate= "600 locuri", Locatie = "Str. Câmpina nr.51-53, Cluj-Napoca" },
                new Restaurant { Nume = "Transilvania Events Hall", ImageSource = "transilvania.jpg", Capacitate= "300 persoane", Locatie = "Calea Turzii 203A, Cluj-Napoca" },
                new Restaurant { Nume = "Black Tulip ", ImageSource = "blacktulip.jpg", Capacitate= "450 locuri", Locatie = "Str. Libertății nr.1, Dej" },
                  };

                // Crearea și configurarea interfeței de utilizator pe baza listei 
                var stackLayout = new StackLayout();

                foreach (var Restaurant in restaurants)
                {
                    var image = new Image
                    {
                        Source = Restaurant.ImageSource, //cala catre imagine
                        HeightRequest = 500, // facem modificari ptr inaltimea imaginii
                        WidthRequest = 500, // facem modificari pt latimea imaginii
                        Aspect = Aspect.AspectFit, //modificam aspcetul imaginii
                        Margin = new Thickness(100), // Adaugăm margini
                    };
                    var label = new Label
                    {
                        Text = $"{Restaurant.Nume}\n{Restaurant.Capacitate}\n{Restaurant.Locatie}",
                        FontAttributes = FontAttributes.Bold | FontAttributes.Italic,

                    };

                    stackLayout.Children.Add(image);
                    stackLayout.Children.Add(label);

                }
                var scrollView = new ScrollView
                {
                    Content = stackLayout
                };

                Content = scrollView;
            }

            private void OnCounterClicked(object sender, EventArgs e)
            {
                count++;

                if (count == 1)
                    CounterBtn.Text = $"Clicked {count} time";
                else
                    CounterBtn.Text = $"Clicked {count} times";

                SemanticScreenReader.Announce(CounterBtn.Text);
            }
        }
        */
    }

}