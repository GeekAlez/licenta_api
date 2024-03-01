using Microsoft.Maui.Controls;
using System;
using System.Collections.ObjectModel;

namespace LicentaApp
{
    public partial class Review : ContentPage
    {
        ObservableCollection<string> reviewsList = new ObservableCollection<string>();
        private string reviewToEdit;

        public Review()
        {
            InitializeComponent();
            ReviewListView.ItemsSource = reviewsList;
        }

        private void OnSendReviewClicked(object sender, EventArgs e)
        {
            // Accesează textul din caseta de text
            string reviewText = ReviewEntry.Text;

            if (!string.IsNullOrWhiteSpace(reviewText))
            {
                if (string.IsNullOrEmpty(reviewToEdit))
                {
                    // Adaugă noul review la lista
                    reviewsList.Add(reviewText);
                }
                else
                {
                    // Editează review-ul existent
                    int index = reviewsList.IndexOf(reviewToEdit);
                    if (index != -1)
                    {
                        reviewsList[index] = reviewText;
                    }

                    // Resetăm variabila de editare
                    reviewToEdit = null;
                }

                // Actualizează afișarea listei de review-uri
                ReviewListView.ItemsSource = null;
                ReviewListView.ItemsSource = reviewsList;

                // Șterge textul din caseta de text după trimitere
                ReviewEntry.Text = "";
            }
        }

        private void OnDeleteReviewClicked(object sender, EventArgs e)
        {
            // Obține review-ul asociat butonului de ștergere
            var reviewToRemove = (sender as Button)?.CommandParameter as string;

            // Verifică și elimină review-ul din lista
            if (!string.IsNullOrWhiteSpace(reviewToRemove))
            {
                reviewsList.Remove(reviewToRemove);
            }
        }

        private void OnEditReviewClicked(object sender, EventArgs e)
        {
            // Obține recenzia asociată butonului de editare
            reviewToEdit = (sender as Button)?.CommandParameter as string;

            // Verificați dacă recenzia pentru editare nu este nulă sau goală
            if (!string.IsNullOrEmpty(reviewToEdit))
            {
                // Actualizați textul din Entry cu recenzia pentru editare
                ReviewEntry.Text = reviewToEdit;
            }
        }
    }
}