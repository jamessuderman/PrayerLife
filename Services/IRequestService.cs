namespace PrayerLife.Services;

public interface IRequestService
{
    Task<List<Request>> GetRequests();
    Task<int> AddRequest(Request request);
    Task<int> DeleteRequest(Request request);
    Task<int> UpdateRequest(Request request);
}

