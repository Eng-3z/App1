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
    public partial class FinalPage : ContentPage
    {
        Users user;

        public FinalPage(Users user)
        {
            InitializeComponent();
            this.user = user;
            number_label.Text = Convert.ToString(user.Number);
            code_label.Text = Convert.ToString(user.Code);


        }

        private void logout_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        private void controlpage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ControlPage(user));
        }

        private async void allinfo_Clicked(object sender, EventArgs e)
        {
            var details = await App.UserSQLite.GetUsersAsync();
            myListView.ItemsSource = details;
        }
    }
}
