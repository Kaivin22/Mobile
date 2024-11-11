using App1.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1.ViewModels
{
    [QueryProperty(nameof(HocSinhId), nameof(HocSinhId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        //private int hocSinhId;
        private string hoTen;
        private DateTime ngaySinh;
        private bool gioiTinh;
        private string lopId;
        public string Id { get; set; }

        public string HoTen
        {
            get => hoTen;
            set => SetProperty(ref hoTen, value);
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

        public string LopId
        {
            get => lopId;
            set => SetProperty(ref lopId, value);
        }

        public int HocSinhId
        {
            get
            {
                return HocSinhId;
            }
            set
            {
                HocSinhId = value;
                
            }
        }

        public async void LoadItemId(int hocsinhId)
        {
            try
            {
                var hocsinh = await DataStore.GetItemAsync(hocsinhId);
                if (hocsinh != null)
                {
                    //HocSinhId = hocsinh.HocSinhId;
                    HoTen = hocsinh.HoTen;
                    NgaySinh = hocsinh.NgaySinh;
                    GioiTinh = hocsinh.GioiTinh;
                    LopId = hocsinh.LopId;
                }
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }
    }
}
