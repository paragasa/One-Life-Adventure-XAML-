using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PersonalApp5910.Views.MainAppPages
{
    public partial class MePage : ContentPage
    {
        public MePage()
        {
            InitializeComponent();
        }
        async void ClickButt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GamePage());
        }
    }
}
