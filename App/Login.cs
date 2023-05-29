using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test2_sql_f
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void login_Clicked(object sender, EventArgs e)
        {
            {
                if (!string.IsNullOrEmpty(number.Text) && !string.IsNullOrEmpty(code.Text))
                {
                    var user = await App.UserSQLite.GetUsernumerAsync(Convert.ToInt16( number.Text));
                    if (user != null)
                    {
                        await Navigation.PushAsync(new FinalPage(user));
                    }
                    else
                        await DisplayAlert("Error", "number is error", "Ok");
                }
                else
                    await DisplayAlert("Error", "number is empty", "Ok");
            }
        }
    


        private void home_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
