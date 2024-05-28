using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using Relaxing_Koala_.ViewModels;

namespace Relaxing_Koala_.Views;

public sealed partial class LoginPage : Page
{
    public LoginViewModel ViewModel
    {
        get;
    }

    public LoginPage()
    {
        ViewModel = App.GetService<LoginViewModel>();
        // InitializeComponent();
    }
    
}
