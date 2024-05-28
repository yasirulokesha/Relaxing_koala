using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using Relaxing_Koala_.Contracts.ViewModels;
using Relaxing_Koala_.Core.Contracts.Services;
using Relaxing_Koala_.Core.Models;

namespace Relaxing_Koala_.ViewModels;

public partial class ReservationsViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public ReservationsViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
