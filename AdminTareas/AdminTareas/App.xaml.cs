using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AdminTareas.NewFolder1;
using AdminTareas.NewFolder1;

namespace AdminTareas
{
    public partial class App : Application
    {
        public App()
        {   
            InitializeComponent();
                     
            MainPage = new NavigationPage(new MainPage());
                        
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
