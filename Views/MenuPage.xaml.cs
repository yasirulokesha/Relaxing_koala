using Microsoft.UI.Xaml.Controls;

using Relaxing_Koala_.ViewModels;

namespace Relaxing_Koala_.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class MenuPage : Page
{
    public MenuViewModel ViewModel
    {
        get;
    }

    public MenuPage()
    {
        ViewModel = App.GetService<MenuViewModel>();
        InitializeComponent();
    }
}
