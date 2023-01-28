namespace PrayerLife.Services;

public class RequestService
{
    public SQLiteAsyncConnection _dbConnection;

    public RequestService() {
        SetupDB();
    }

    private async void SetupDB() {
        if (_dbConnection == null) {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "PrayerLife.db3");
            _dbConnection = new SQLiteAsyncConnection(dbPath);
            await _dbConnection.CreateTableAsync<Request>();
        }
    }

    public Task<List<Request>> GetRequests() {
        return _dbConnection.Table<Request>().ToListAsync();
    }

    public Task<int> AddRequest(Request request)
    {
        return _dbConnection.InsertAsync(request);
    }

    public Task<int> DeleteRequest(Request request)
    {
        return _dbConnection.DeleteAsync(request);
    }

    public Task<int> UpdateRequest(Request request)
    {
        return _dbConnection.UpdateAsync(request);
    }
}

