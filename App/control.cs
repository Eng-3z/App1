using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace test2_sql_f
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ControlPage : ContentPage
    {
        public Users user;

        public ControlPage(Users users)
        {
            InitializeComponent();
            this.user = (Users)users;

        }

        private async void create_Clicked(object sender, EventArgs e)
        {
            if ((!string.IsNullOrEmpty(number.Text)) && (!string.IsNullOrEmpty(code.Text)))
            {
                var user = new Users()
                {
                    Number =Convert.ToInt32( number.Text),
                    Code = Convert.ToInt32(code.Text),

                };
                await App.UserSQLite.SaveUserAsync(user);
                await DisplayAlert("Done", "number is added", "Ok");
                await Navigation.PushAsync(new LoginPage());
            }
            else
                await DisplayAlert("Error", "number is empty Or number is already existe", "Ok");
        }

        private async void update_Clicked(object sender, EventArgs e)
        {
            this.user.Number = Convert.ToInt32( number.Text);
            this.user.Code = Convert.ToInt32(code.Text);



            await App.UserSQLite.SaveUserAsync(this.user);
            await Navigation.PushAsync(new LoginPage());
        }

        private async void delete_Clicked(object sender, EventArgs e)
        {

            await App.UserSQLite.DeleteUserAsync(this.user);
            await Navigation.PopToRootAsync();

        }

        private void back_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
