using System.Collections.Generic;
using _Ders3_List.Model;
using Xamarin.Forms;

namespace _Ders3_List
{
    public partial class App : Application
    {
        public static List<Person> Dummies;
        public App()
        {
            Dummies = new List<Person>
            {
                new Person{Name="Ahmet",Surname="Demir"},
                new Person{Name="Mehmet",Surname="Çelik"},
                new Person{Name="Hasan",Surname="Bakır"},
                new Person{Name="Fatih",Surname="Baytar"}
            };
            InitializeComponent();

            MainPage = new _712_Ders3_ListPage();
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
