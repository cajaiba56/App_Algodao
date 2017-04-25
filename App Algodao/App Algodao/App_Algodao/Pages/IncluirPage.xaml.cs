using App_Algodao.Model;
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
  
    public partial class IncluirPage : ContentPage
    {
        //AcessoDB accdb = new AcessoDB();
        ObservableCollection<Modulos> colecaoModulos;

        public IncluirPage()
        {
            InitializeComponent();
        }

        public IncluirPage(ObservableCollection<Modulos> _modulos)
        {
            colecaoModulos = _modulos;
            InitializeComponent();
        }


        //private void Salvar_Clicked(object sender, System.EventArgs e)
        //{
        //    Modulos modulo = new Model.Modulos();
        //    modulo.Numero = txtNumero.Text;
        //    modulo.Fazenda = picFazenda.Items.ToString();
        //    modulo.Talhao = txtTalhao.Text;
        //    modulo.Bordadura = bBordadura.On;

        //    //accdb.InserirUsuario(usuario);
        //    App.DataBase.InserirModulo(modulo);
        //    colecaoModulos.Add(modulo);
        //    Navigation.PopAsync();
        //}

        private async void Cancelar_Clicked(object sender, EventArgs e)
        {
           await Navigation.PopAsync();
        }
    }
}
