using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplicatie_mobile.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplicatie_mobile.Data;
using System.Globalization;

namespace Aplicatie_mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListEntryPage : ContentPage
    {
        public ListEntryPage()
        {
            InitializeComponent();

        }
        
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            reviewView.ItemsSource = await App.Database.GetReviewsAsync();
        }
        async void OnReviewAddedClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListPage
            {
                BindingContext = new Reviews()
            });
        }
        async void OnReviewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ListPage
                {
                    BindingContext = e.SelectedItem as Reviews
                });
            }
        }

        
    }
}