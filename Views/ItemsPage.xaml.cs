using App1.Models;

using App1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    public partial class ItemsPage : ContentPage
    {
        //ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            //BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //_viewModel.OnAppearing();
            lstHocSinh.ItemsSource = await App.db.HocSinhList();
        }

        private void btnAdd_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new NewItemPage());
        }

        private void btnBack_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Admin2Page());
        }
    }
}