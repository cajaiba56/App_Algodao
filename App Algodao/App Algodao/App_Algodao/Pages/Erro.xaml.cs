using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Algodao.Pages
{
    
    public partial class Erro : ContentPage
    {
        public Erro()
        {
            InitializeComponent();
        }

        private async void retorna_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
