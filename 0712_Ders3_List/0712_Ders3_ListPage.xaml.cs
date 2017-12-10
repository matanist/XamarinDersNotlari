using System.Linq;
using _Ders3_List.Model;
using Xamarin.Forms;

namespace _Ders3_List
{
    public partial class _712_Ders3_ListPage : ContentPage
    {
        void Handle_Refreshing(object sender, System.EventArgs e)
        {
            var people = App.Dummies.OrderByDescending(X => X.Name);
            lstPeople.ItemsSource = people;
            lstPeople.IsRefreshing = false;
        }



        void Handle_Clicked1(object sender, System.EventArgs e)
        {
            if(sender==null){
                DisplayAlert("Uyarı","Lütfen bir kişi seçiniz","OK");
                return;
            }

            MenuItem item = (MenuItem)sender;
            Person person = (Person)item.CommandParameter;
            Navigation.PushModalAsync(new CreatePerson(person));
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new CreatePerson(new Model.Person()));
        }

        public _712_Ders3_ListPage()
        {
            InitializeComponent();

            lstPeople.ItemsSource = App.Dummies;
        }
    }
}
