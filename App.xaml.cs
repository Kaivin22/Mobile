using App1.Services;
using App1.Views;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    public partial class App : Application
    {
        private static MockDataStore _db;
        public static MockDataStore db
        {
            get
            {
                if(_db==null)
                    _db=new MockDataStore(Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData), "qlhs.db3"));
                return _db;
            }
        }
       
        public App()
        {
            InitializeComponent();
           NavigationPage MainPage = new NavigationPage (new ItemsPage());

            //DependencyService.Register<MockDataStore>();
            //MainPage = new NavigationPage (new ItemsPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

       
    }
}
