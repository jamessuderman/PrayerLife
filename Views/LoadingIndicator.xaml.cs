namespace PrayerLife.Views;

public partial class LoadingIndicator : VerticalStackLayout
{
    public static readonly BindableProperty IsBusyProperty = BindableProperty.Create(
        "IsBusy",
        typeof(bool),
        typeof(LoadingIndicator),
        false,
        BindingMode.OneWay,
        null,
        SetIsBusy
    );

    public bool IsBusy
    {
        get => (bool)this.GetValue(IsBusyProperty);
        set => this.SetValue(IsBusyProperty, value);
    }

    public static void SetIsBusy(BindableObject bindable, object oldValue, object newValue)
    {
        LoadingIndicator indicator = bindable as LoadingIndicator;
        indicator.IsVisible = (bool)newValue;
        indicator.indicator.IsRunning = (bool)newValue;
    }

    public static readonly BindableProperty LoadingTextProperty = BindableProperty.Create(
        "LoadingText",
        typeof(string),
        typeof(ErrorIndicator),
        string.Empty,
        BindingMode.OneWay,
        null,
        SetLoadingText
    );

    public string LoadingText
    {
        get => (string)this.GetValue(LoadingTextProperty);
        set => this.SetValue(LoadingTextProperty, value);
    }

    public static void SetLoadingText(BindableObject bindable, object oldValue, object newValue) =>
        (bindable as LoadingIndicator).activityText.Text = (string)newValue;

    public LoadingIndicator()
    {
        InitializeComponent();
    }
}
