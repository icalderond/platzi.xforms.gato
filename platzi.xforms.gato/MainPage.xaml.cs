using System.Linq;
using Xamarin.Forms;

namespace platzi.xforms.gato
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Tapped(object sender, System.EventArgs e)
        {
            var currentGrid = ((Grid)sender);

            if (currentGrid.Children.Any())
            {
                currentGrid.Children.Clear();
            }
            else
            {
                BoxView boxView = new BoxView
                {
                    WidthRequest = 50,
                    HeightRequest = 50,
                    BackgroundColor = Color.Magenta,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                    CornerRadius = 25
                };

                currentGrid.Children.Add(boxView);
            }
        }
    }
}
