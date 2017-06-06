using Xamarin.Forms;

namespace SigaMATA270.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
            BindingContext = new ViewModels.LoginViewModel();
        }
    }
}
