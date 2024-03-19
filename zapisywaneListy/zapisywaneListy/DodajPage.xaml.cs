using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zapisywaneListy
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DodajPage : ContentPage
    {
        Produkt Produkt;
        public DodajPage()
        {
            InitializeComponent();
            naglowek.Text = "Dodaj produkt";
            naglowek.TextColor = Color.Green;
            przycisk.Text = "Dodaj";
            przycisk.BackgroundColor = Color.LightGreen;
            przycisk.Clicked += dodaj_Clicked;
        }
        public DodajPage(Produkt produkt)
        {
            InitializeComponent();
            Produkt = produkt;
            naglowek.Text = "Edytuj produkt";
            naglowek.TextColor = Color.Orange;
            przycisk.Text = "Edytuj";
            przycisk.BackgroundColor = Color.Yellow;
            przycisk.Clicked += edytuj_Clicked;
            txtNazwa.Text = Produkt.Nazwa;
            txtCena.Text = Produkt.Cena.ToString();
            txtIlosc.Text = Produkt.Ilosc.ToString();
        }

        private void dodaj_Clicked(object sender, EventArgs e)
        {

        }
        private void edytuj_Clicked(object sender, EventArgs e)
        {

        }
    }
}