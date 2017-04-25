using App_Algodao.Model;
using App_Algodao.Persistencia;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Algodao.Pages
{
   
    public partial class CadastroPage : ContentPage
    {
        private ObservableCollection<Modulos> _modulos;
        //private AcessoDB accdb = new AcessoDB();

        public CadastroPage()
        {
            InitializeComponent();
            //var modulos = accdb.GetModulos();
            var modulos = App.DataBase.GetModulos();
            _modulos = new ObservableCollection<Modulos>(modulos);
            lvwModulos.ItemsSource = _modulos;
        }

        private async void Novo_Activated(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage(new IncluirPage(_modulos)));
        }

        private async void Alterar_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var modulo = menuItem.CommandParameter as Modulos;
            await Navigation.PushAsync(new AlterarPage(modulo));
        }

        private async void Deletar_Clicked(object sender, EventArgs e)
        {
            var modulo = (sender as MenuItem).CommandParameter as Modulos;
            var resposta = await DisplayAlert("Confirma Exclusão deste registro ?", modulo.Numero, "Sim", "Não");
            if (resposta)
            {
                //accdb.DeletarModulo(modulo);
                App.DataBase.DeletarModulo(modulo);
                _modulos.Remove(modulo);
            }
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            lvwModulos.ItemsSource = App.DataBase.GetModulos(e.NewTextValue); //accdb.GetModulos(e.NewTextValue);
        }

    }
}
