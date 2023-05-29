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
    public partial class GalleryPage : CarouselPage
    {
        public GalleryPage()
        {
            InitializeComponent();
            car1.Source = ImageSource.FromUri(new Uri("https://e7.pngegg.com/pngimages/189/75/png-clipart-black-audi-v13-tuning-sports-car-car-car-compact-car-sedan-thumbnail.png"));

            car2.Source = ImageSource.FromUri(new Uri("https://e7.pngegg.com/pngimages/133/716/png-clipart-car-poster-automotive-design-car-compact-car-car-accident-thumbnail.png"));
            car3.Source = ImageSource.FromUri(new Uri("https://e7.pngegg.com/pngimages/291/917/png-clipart-car-car-white-thumbnail.png"));
            car4.Source = ImageSource.FromUri(new Uri("https://e7.pngegg.com/pngimages/159/829/png-clipart-hyundai-santa-fe-car-audi-car-compact-car-headlamp-thumbnail.png"));
        }

        private void back_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
