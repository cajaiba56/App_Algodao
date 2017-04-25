using App_Algodao.Pages;
using App_Algodao.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App_Algodao
{
    public partial class App : Application
    {
        static AcessoDB dbContext;

        public static AcessoDB DataBase
        {
            get
            {
                if (dbContext == null)
                    dbContext = new AcessoDB();

                return dbContext;
            }
        }


        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new HomePage());
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
