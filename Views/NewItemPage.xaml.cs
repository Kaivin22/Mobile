using App1.Models;
using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    public partial class NewItemPage : ContentPage
    {


        public NewItemPage()
        {
            InitializeComponent();
            //BindingContext = new NewItemViewModel(); // Create and bind the ViewModel
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ItemsPage());
        }

        private void btnThem_Clicked(object sender, EventArgs e)
        {
                HocSinh hs = new HocSinh();
                hs.HoTen = txtHoTen.Text;
                hs.NgaySinh = txtNgaySinh.Date;
                hs.GioiTinh = (pkGioiTinh.SelectedItem.ToString() == "Nam") ? true : false;
               
                App.db.HocSinhSave(hs);
                Navigation.PopAsync();
        }

    }
}