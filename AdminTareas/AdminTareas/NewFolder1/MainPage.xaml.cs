using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using AdminTareas.NewFolder1;

namespace AdminTareas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
                        
        }

        private void Iniciar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Tareas());
        }
    }
}
