using System;
using PersonalApp5910.Views;
using Xamarin.Forms;
using PersonalApp5910.Views.MainAppPages;

namespace PersonalApp5910
{
    public class MainPage : TabbedPage
    {
        public MainPage()
        {
            Page mePage, gamePage, scorePage, charPage, invPage, monsterPage,
            gameitemsPage, battlePage = null;

            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    mePage = new NavigationPage(new MePage())
                    {
                        Title = "Information"
                    };
                    gamePage = new NavigationPage(new GamePage())
                    {
                        Title = "Game"
                    };
                    scorePage = new NavigationPage(new ScorePage())
                    {
                        Title = "Score"
                    };
                    charPage = new NavigationPage(new CharacterPage())
                    {
                        Title = "Character"
                    };

                    invPage = new NavigationPage(new InventoryPage())
                    {
                        Title = "Inventory"
                    };
                    monsterPage = new NavigationPage(new MonstersPage())
                    {
                        Title = "Monsters"
                    };
                    gameitemsPage = new NavigationPage(new GameItemsPage())
                    {
                        Title = "Items"
                    };
                    battlePage = new NavigationPage(new BattlePage())
                    {
                        Title = "Battle"
                    };

                    mePage.Icon = "tab_about.png";
                    gamePage.Icon = "tab_feed.png";
                    scorePage.Icon = "tab_feed.png";
                    charPage.Icon = "tab_about.png";
                    invPage.Icon = "tab_about.png";
                    monsterPage.Icon = "tab_about.png";
                    gameitemsPage.Icon = "tab_about.png";
                    battlePage.Icon = "tab_about.png";
                    //itemsPage.Icon = "tab_feed.png";
                    //aboutPage.Icon = "tab_about.png";
                    break;
                default:
                    mePage = new MePage()
                    {
                        Title = "Me"
                    };
                    gamePage = new GamePage()
                    {
                        Title = "Game"
                    };
                    scorePage = new ScorePage()
                    {
                        Title = "Score"
                    };
                    charPage = new CharacterPage()
                    {
                        Title = "Character"
                    };
                    invPage = new InventoryPage()
                    {
                        Title = "Inventory"
                    };
                    monsterPage = new MonstersPage()
                    {
                        Title = "Monsters"
                    };
                    gameitemsPage = new GameItemsPage()
                    {
                        Title = "Items"
                    };
                    battlePage = new BattlePage()
                    {
                        Title = "Battle"
                    };


                    break;
            }
            Children.Add(mePage);
            Children.Add(gamePage);
            Children.Add(scorePage);
            Children.Add(charPage);
            Children.Add(invPage);
            Children.Add(monsterPage);
            Children.Add(gameitemsPage);
            Children.Add(battlePage);

            Title = Children[0].Title;
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage?.Title ?? string.Empty;
        }
    }
}
