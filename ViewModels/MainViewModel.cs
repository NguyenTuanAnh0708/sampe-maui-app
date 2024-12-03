
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace sample_app_mvvm.ViewModels;

public partial class MainViewModel : ObservableObject
{

    public MainViewModel()
    {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
        {
            return;
        }
        Items.Add(Text);
        Text = String.Empty;
    }

    [RelayCommand]
    void Delete(string item)
    {
        if (Items.Contains(item))
        {
            Items.Remove(item);
        }
    }
}
