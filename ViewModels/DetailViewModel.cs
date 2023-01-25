using CommunityToolkit.Mvvm.ComponentModel;

namespace PrayerLife.ViewModels;

[QueryProperty("Text", "Text")]

public partial class DetailViewModel : ObservableObject
{
    [ObservableProperty]
    string text;
}

