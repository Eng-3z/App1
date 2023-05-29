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
    public partial class HomePage : ContentPage
    {
        Users user;

        public HomePage(Users user)
        {
            InitializeComponent();

        }

        private void login_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new LoginPage());  
        }

        private void cntrol_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ControlPage(user));

        }

        private void gallrey_btn_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new GalleryPage());

        }

        private void close_btn_Clicked(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
