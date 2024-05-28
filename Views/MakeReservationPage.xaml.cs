using Microsoft.UI.Xaml.Controls;

using Relaxing_Koala_.ViewModels;

namespace Relaxing_Koala_.Views;

public sealed partial class MakeReservationPage : Page
{
    public MakeReservationViewModel ViewModel
    {
        get;
    }

    public MakeReservationPage()
    {
        ViewModel = App.GetService<MakeReservationViewModel>();
        InitializeComponent();
    }
}
