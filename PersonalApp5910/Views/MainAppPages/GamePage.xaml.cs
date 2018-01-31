using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace PersonalApp5910.Views.MainAppPages
{
    public partial class GamePage : ContentPage
    {
        public GamePage()
        {
            InitializeComponent();
        }
        async void ClickScore(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScorePage());
        }
        async void ClickChar(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CharacterPage());
        }
        async void ClickInv(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new InventoryPage());
        }
        async void ClickMonster(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MonstersPage());
        }
        async void ClickItems(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GameItemsPage());
        }
        async void ClickBatt(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new BattlePage());
        }
    }

}
