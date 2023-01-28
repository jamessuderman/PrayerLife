namespace PrayerLife.Views;

public partial class ErrorIndicator : VerticalStackLayout
{
    public static readonly BindableProperty IsErrorProperty = BindableProperty.Create(
        "IsError",
        typeof(bool),
        typeof(ErrorIndicator),
        false,
        BindingMode.OneWay,
        null,
        SetIsError
    );

    public bool IsError
    {
        get => (bool)this.GetValue(IsErrorProperty);
        set => this.SetValue(IsErrorProperty, value);
    }

    public static void SetIsError(BindableObject bindable, object oldValue, object newValue) =>
        (bindable as ErrorIndicator).IsVisible = (bool)newValue;

    public static readonly BindableProperty ErrorTextProperty = BindableProperty.Create(
        "ErrorText",
        typeof(string),
        typeof(ErrorIndicator),
        string.Empty,
        BindingMode.OneWay,
        null,
        SetErrorText
    );

    public string ErrorText
    {
        get => (string)this.GetValue(ErrorTextProperty);
        set => this.SetValue(ErrorTextProperty, value);
    }

    public static void SetErrorText(BindableObject bindable, object oldValue, object newValue) =>
        (bindable as ErrorIndicator).errorText.Text = (string)newValue;

    public static readonly BindableProperty ErrorImageProperty = BindableProperty.Create(
        "ErrorImage",
        typeof(ImageSource),
        typeof(ErrorIndicator),
        null,
        BindingMode.OneWay,
        null,
        SetErrorImage
    );

    public ImageSource ErrorImage
    {
        get => (ImageSource)this.GetValue(ErrorImageProperty);
        set => this.SetValue(ErrorImageProperty, value);
    }

    public static void SetErrorImage(BindableObject bindable, object oldValue, object newValue) =>
        (bindable as ErrorIndicator).errorImage.Source = (ImageSource)newValue;

    public ErrorIndicator() {
        InitializeComponent();
    }

}
