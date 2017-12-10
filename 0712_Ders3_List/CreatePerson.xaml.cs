using System;
using System.Collections.Generic;
using _Ders3_List.Model;
using Xamarin.Forms;

namespace _Ders3_List
{
    public partial class CreatePerson : ContentPage
    {
        private readonly Person _person;
        public CreatePerson(Person person)
        {
            InitializeComponent();
            _person = person;
            this.BindingContext = _person;
        }
    }
}
