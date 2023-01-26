namespace PrayerLife.Models;

public class Request
{ 
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Body { get; set; }
    public bool IsAnswered { get; set; } = false;
}