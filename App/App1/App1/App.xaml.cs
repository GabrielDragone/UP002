using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

//Gabriel:
using App1.Views;

namespace App1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //Alterado a tela inicial do APP:
            //MainPage = new MainPage();
            var homePage = new HomePage();

            //Stack de Navegação, para navegar de uma página para outra:
            MainPage = new NavigationPage(homePage); //homePage é a root (raiz)
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
