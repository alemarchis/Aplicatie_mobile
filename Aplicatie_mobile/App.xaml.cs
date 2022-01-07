using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Aplicatie_mobile.Data;
using System.IO;

namespace Aplicatie_mobile
{
    public partial class App : Application
    {

        static ReviewsDatabase database;
        public static ReviewsDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ReviewsDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.
                    LocalApplicationData), "Reviews.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ListEntryPage());
        }
      
    }    
    
}
