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
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.DatabaseRestaurant.GetRestaurantAsync();
        }
        async void OnRestaurantAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RestaurantPage
            {
                BindingContext = new Restaurant()
            });
        }
        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new RestaurantPage
                {
                    BindingContext = e.SelectedItem as Restaurant

                });
            }
        }
    }

}