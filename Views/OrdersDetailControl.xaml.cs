using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

using Relaxing_Koala_.Core.Models;

namespace Relaxing_Koala_.Views;

public sealed partial class OrdersDetailControl : UserControl
{
    public SampleOrder? ListDetailsMenuItem
    {
        get => GetValue(ListDetailsMenuItemProperty) as SampleOrder;
        set => SetValue(ListDetailsMenuItemProperty, value);
    }

    public static readonly DependencyProperty ListDetailsMenuItemProperty = DependencyProperty.Register("ListDetailsMenuItem", typeof(SampleOrder), typeof(OrdersDetailControl), new PropertyMetadata(null, OnListDetailsMenuItemPropertyChanged));

    public OrdersDetailControl()
    {
        InitializeComponent();
    }

    private static void OnListDetailsMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is OrdersDetailControl control)
        {
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
