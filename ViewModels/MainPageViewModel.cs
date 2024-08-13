using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
//using UIKit;

namespace To_Do_List.ViewModels;
public partial class MainPageViewModel : ObservableObject
{
    public MainPageViewModel()
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
        Items.Add(Text);
    }

    [RelayCommand]
    void Remove(string s) {
     if (Items.Contains(s))
        Items.Remove(s);
    }
}
