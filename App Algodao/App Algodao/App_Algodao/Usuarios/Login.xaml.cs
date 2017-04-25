using App_Algodao.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Algodao.Usuarios
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private async void login_Clicked(object sender, EventArgs e)
        {

            //var usuario = new Usuario();

            //String.IsNullOrWhiteSpace é um metodo que verifica se o campo é null, vazio ou tem apenas espaços em branco
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                await DisplayAlert("Nome inválido", "Informe o nome do usuário", "OK");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                await DisplayAlert("Senha inválida", "Informe a senha do usuário", "OK");
                return;
            }

            //Verifica se os valores informados (Equals) - Igual nos campos são os valores corretos!
            if (txtNome.Text.Equals("Carlos") && txtSenha.Text.Equals("eduarda56"))
            {
                //usuario.Nome = txtNome.Text;
                //usuario.Senha = txtSenha.Text;
                //await Navigation.PushAsync(new MenuPage(usuario));
                await Navigation.PushAsync(new MenuPage());
            }
            else
            {
                await Navigation.PushModalAsync(new Erro());
            }


        }

        private async void cancela_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new HomePage());
        }

    }
}
