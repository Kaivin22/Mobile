using App1.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {

            InitializeComponent();
            //this.BindingContext = new LoginViewModel();
            //imgLogo.Source = ImageSource.FromFile("logo.png");
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ TextBox và PasswordBox
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            // Kiểm tra thông tin đăng nhập (ở đây chỉ là ví dụ)
            if (username == "admin" && password == "123")
            {
                // Đăng nhập thành công, chuyển đến màn hình chính
               await DisplayAlert("Thông báo", "Đăng nhập thành công!", "OK");
                // ... code để chuyển đến màn hình chính
                Application.Current.MainPage = new NavigationPage(new AdminPage());
            }
            else
            {
               await DisplayAlert("Thông báo", "Tên đăng nhập hoặc mật khẩu không đúng!", "OK");
            }
        }
    }
}