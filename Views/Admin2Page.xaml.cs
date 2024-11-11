using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
//    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Admin2Page : ContentPage
    {
        public Admin2Page() 
        {
            InitializeComponent();
        }

        private void btn10A1_Click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new ItemsPage());
        }

        private void btn10A2_Click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Admin2Page());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new AdminPage());
        }
    }
}
