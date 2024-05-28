using Microsoft.UI.Xaml.Controls;

using Relaxing_Koala_.ViewModels;

namespace Relaxing_Koala_.Views;

public sealed partial class DashboardPage : Page
{
    public DashboardViewModel ViewModel
    {
        get;
    }

    public DashboardPage()
    {
        ViewModel = App.GetService<DashboardViewModel>();
        InitializeComponent();
    }
}
