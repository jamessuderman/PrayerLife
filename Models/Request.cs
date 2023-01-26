namespace PrayerLife.Models;

public class Request
{ 
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }
    public string Body { get; set; }
    public DateTime DateInserted { get; set; } = DateTime.Now;
    public bool IsAnswered { get; set; } = false;
}