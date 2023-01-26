namespace PrayerLife.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly IRequestService _requestService;

    public MainViewModel(IRequestService requestService)
    {
        _requestService = requestService;
        Requests = new ObservableCollection<Request>();
    }

    [ObservableProperty]
    ObservableCollection<Request> requests;

    [ObservableProperty]
    string entryText;

    [RelayCommand]
    async void Add()
    {
        if (string.IsNullOrWhiteSpace(EntryText))
            return;

        Request newRequest = new Request() {
            Body = EntryText
        };

        var response = await _requestService.AddRequest(newRequest);

        if (response > 0) {
            GetRequests();
        } else {
            await Shell.Current.DisplayAlert("Request Error", "An error occured while saving to databaase", "OK");
        }

        EntryText = string.Empty;
    }

    [RelayCommand]
    async Task Tap(Request request)
    {
        var response = await _requestService.DeleteRequest(request);

        if(response > 0) {
            GetRequests();
        } else {
            await Shell.Current.DisplayAlert("Request Error", "An error occured while deleting from the database", "OK");
        }
    }

    public async void GetRequests() {
        var requests = await _requestService.GetRequests();

        if (requests?.Count > 0) {
            Requests.Clear();
            foreach(var request in requests) {
                Requests.Add(request);
            }
        }

    }
}


