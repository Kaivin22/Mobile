using App1.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1.Models;
using SQLite;
using System.ComponentModel;
using System.Windows.Input;


namespace App1.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private string _username;
        private string _password;
        private string _message;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged(nameof(Username));
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged(nameof(Password));
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged(nameof(Message));
            }
        }

        public ICommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLogin);
        }

        private async void OnLogin()
        {
            // Kiểm tra thông tin đăng nhập
            if (Username == "admin" && Password == "123")
            {
                Message = "Đăng nhập thành công!";
                // Chuyển đến AdminPage
                await Application.Current.MainPage.Navigation.PushAsync(new AdminPage());
            }
            else
            {
                Message = "Tên đăng nhập hoặc mật khẩu không đúng!";
            }

            // Hiển thị thông báo
            await Application.Current.MainPage.DisplayAlert("Thông báo", Message, "OK");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}