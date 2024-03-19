using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace zapisywaneListy
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            OnAppearing();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lista.ItemsSource = Zapisywanie.ReadData();
        }

        private void Dodaj_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DodajPage());
        }

        private void Edytuj_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DodajPage());
        }

        private void Usun_Clicked(object sender, EventArgs e)
        {

        }
    }
}
