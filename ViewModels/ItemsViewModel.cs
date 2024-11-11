using App1.Models;
using App1.Views;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private HocSinh _hs;

        private ObservableCollection<HocSinh> _items;
        public Command LoadItemsCommand { get; }
        public Command AddItemCommand { get; }
        public Command<HocSinh> ItemTapped { get; }

        public ObservableCollection<HocSinh> Items
        {
            get { return _items; }
            set { SetProperty(ref _items, value); }
        }

        public ItemsViewModel()
        {

            Items = new ObservableCollection<HocSinh>();
            // Ví dụ: Lấy dữ liệu từ database hoặc service
            Items.Add(new HocSinh { HoTen = "Nguyễn Văn A", NgaySinh = new DateTime(2000, 1, 1), GioiTinh = true, LopId = "1A" });

            //LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            //AddItemCommand = new Command(async () => await OnAddItem());
            //ItemTapped = new Command<HocSinh>(OnItemSelected);
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }

        public void OnAppearing()
        {
            IsBusy = true;
            hs = null;
        }

        public HocSinh hs
        {
            get => _hs;
            set
            {
                SetProperty(ref _hs, value);
                OnItemSelected(value);
            }
        }

        private async void OnAddItem(object obj)
        {
            await Shell.Current.GoToAsync(nameof(NewItemPage));
        }

        async void OnItemSelected(HocSinh item)
        {
            if (item == null)
                return;

            // This will push the ItemDetailPage onto the navigation stack
            await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?{nameof(ItemDetailViewModel.HocSinhId)}");
        }
    }
}