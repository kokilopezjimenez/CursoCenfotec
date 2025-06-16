using Xamarin.Forms;
using HelloXamarin.ViewModels;

namespace HelloXamarin.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainViewModel();
        }
    }
}
