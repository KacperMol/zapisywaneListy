using System;
using System.Collections;
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
        List<Produkt> produktList = new List<Produkt>();
        public MainPage()
        {
            InitializeComponent();
            OnAppearing();
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            produktList = Zapisywanie.ReadData();
            lista.ItemsSource = produktList;
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
            Produkt zaznaczony = lista.SelectedItem as Produkt;
            if (zaznaczony != null)
            {
                Zapisywanie.DeleteData(Zapisywanie.ReadData(), zaznaczony);
            }
        }
    }
}
