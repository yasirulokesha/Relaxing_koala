using Microsoft.UI.Xaml.Controls;

using Relaxing_Koala_.ViewModels;

namespace Relaxing_Koala_.Views;

public sealed partial class MakeOrderPage : Page
{
    public MakeOrderViewModel ViewModel
    {
        get;
    }

    public MakeOrderPage()
    {
        ViewModel = App.GetService<MakeOrderViewModel>();
        InitializeComponent();
    }
}
