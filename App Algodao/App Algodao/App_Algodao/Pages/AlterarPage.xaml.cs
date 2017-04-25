using App_Algodao.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Algodao.Pages
{
  
    public partial class AlterarPage : ContentPage
    {
        //AcessoDB accdb = new AcessoDB();
        Modulos moduloAlterado;

        public AlterarPage(Modulos modulo)
        {
            if (modulo == null)
                throw new ArgumentException();

            moduloAlterado = modulo;
            BindingContext = modulo;
            InitializeComponent();
        }

        //private void Alterar_Clicked(object sender, EventArgs e)
        //{
        //    moduloAlterado.Numero = txtNumero.Text;
        //    moduloAlterado.Talhao = txtTalhao.Text;
        //    moduloAlterado.Bordadura = bBordadura.On;

        //    //accdb.AtualizarUsuario(usuarioAlterado);
        //    App.DataBase.AtualizarModulo(moduloAlterado);
        //    Navigation.PopAsync();
        //}

        private async void Cancelar_Clicked(object sender, EventArgs e)
        {
           await Navigation.PopAsync();
        }
    }
}
