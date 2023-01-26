namespace PrayerLife;

public partial class MainPage : ContentPage
{
    public MainViewModel _viewmodel;

    public MainPage(MainViewModel vm)
    {
        InitializeComponent();
        _viewmodel = vm;
        BindingContext = vm;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        _viewmodel.GetRequests();
    }

}


