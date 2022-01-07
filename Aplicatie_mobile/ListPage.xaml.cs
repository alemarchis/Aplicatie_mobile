using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplicatie_mobile.Models;

namespace Aplicatie_mobile
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListPage : ContentPage
    {
        public ListPage()
        {
            InitializeComponent();
            
        }

        async void OnSaveButtonClicked(object sender, EventArgs e)
        {
            var rlist = (Reviews)BindingContext;
            rlist.Date = DateTime.UtcNow;
            await App.Database.SaveReviewsAsync(rlist);
            await Navigation.PopAsync();
        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var rlist = (Reviews)BindingContext;
            await App.Database.DeleteReviewsAsync(rlist);
            await Navigation.PopAsync();
        }

        

    }
}