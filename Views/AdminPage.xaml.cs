using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using App1.ViewModels;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AdminPage : ContentPage
    {
        public AdminPage()
        {
            InitializeComponent();
            //imageLo.Source = ImageSource.FromFile("kt.png");

        }
        private  void btnQL_Click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Admin2Page());
        }

        private void btnĐX_Click(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

    }
}
