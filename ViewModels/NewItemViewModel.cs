using App1.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Windows.Input;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class NewItemViewModel : BaseViewModel
    {
        private int hocSinhId;
        private string hoTen;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string lopId;

        public NewItemViewModel()
        {
            SaveCommand = new Command(OnSave, ValidateSave);
            CancelCommand = new Command(OnCancel);
            this.PropertyChanged +=
                (_, __) => SaveCommand.ChangeCanExecute();
        }

        private bool ValidateSave()
        {
            return !String.IsNullOrWhiteSpace(hoTen)
                && !String.IsNullOrWhiteSpace(lopId);
        }



        public int HocSinhId
        {
            get => hocSinhId;
            set => SetProperty(ref hocSinhId, value);
        }

        public string HoTen
        {
            get => hoTen;
            set => SetProperty(ref hoTen, value);
        }

        public string LopId
        {
            get => lopId;
            set => SetProperty(ref lopId, value);
        }

        public DateTime NgaySinh
        {
            get => ngaySinh;
            set => SetProperty(ref ngaySinh, value);
        }

        public bool GioiTinh
        {
            get => gioiTinh;
            set => SetProperty(ref gioiTinh, value);
        }

        public Command SaveCommand { get; }
        public Command CancelCommand { get; }

        private async void OnCancel()
        {
            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }

        private async void OnSave()
        {
            HocSinh newHocSinh = new HocSinh()
            {
               // HocSinhId = HocSinhId,
                HoTen = hoTen,
                NgaySinh = ngaySinh,
                GioiTinh = gioiTinh,
                LopId = lopId,

            };

            await DataStore.HocSinhList(newHocSinh);

            // This will pop the current page off the navigation stack
            await Shell.Current.GoToAsync("..");
        }
    }
}
